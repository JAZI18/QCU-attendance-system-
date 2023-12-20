
Imports Luxand

Namespace Erenjhun.Utils
    Public Class FaceRecognition
        Friend face_id,
            curr_face_id,
            prev_face_id,
            cameraHandle As Integer

        Friend tracker As Integer = 0  ' creating a Tracker
        Private ReadOnly trackerStateManager As StateManager
        Friend cam_pic_box As PictureBox

        Friend form As Form
        Private active As Boolean = False

        Public Sub New(statesarr As State(), form As Form, Optional cam_pic_box As PictureBox = Nothing)
            Me.trackerStateManager = New StateManager(statesarr, Me)
            Me.form = form
            Me.cam_pic_box = cam_pic_box
        End Sub


        Public Sub Run()

            Dim image As FSDK.CImage
            Dim frameImage As Image

            While active
                Dim ImageHandle As Integer

                ' grab the current frame from the camera
                If (FSDKCam.GrabFrame(cameraHandle, ImageHandle) <> FSDK.FSDKE_OK) Then
                    If (cameraHandle = 0) Then Throw New Exception("CAMERA IS NOT YET OPEN. call start_cam()")
                    Application.DoEvents()
                    Continue While
                End If

                image = New FSDK.CImage(ImageHandle)
                frameImage = image.ToCLRImage()


#Region "tracker api doing magic"
                Dim IDs As Long()
                ReDim IDs(0 To 256)
                Dim faceCount As Long
                Dim sizeOfLong = 8
                FSDK.FeedFrame(tracker, 0, ImageHandle, faceCount, IDs, sizeOfLong) ' maximum 1 face detected
#End Region

                face_id = IDs.First
                trackerStateManager.Run(face_id)

                Draw_Rect(face_id, frameImage)
                Display_vid(frameImage)
            End While

        End Sub




#Region "drawing and video display"
        Private Sub Display_vid(frameImage As Image)
            frameImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
            cam_pic_box.Image = frameImage ' display current frame
            GC.Collect() ' collect the garbage after the deletion
            Application.DoEvents() ' make UI controls accessible
        End Sub

        Private Sub Draw_Rect(id As Integer, frameimage As Image)
            If id = 0 Then Exit Sub ' dont draw if id = 0 because no face found
            Dim gr As Graphics
            gr = Graphics.FromImage(frameimage)

            Dim facePosition As FSDK.TFacePosition = New FSDK.TFacePosition
            FSDK.GetTrackerFacePosition(tracker, 0, id, facePosition)

            Dim left As Integer = facePosition.xc - CInt(facePosition.w * 0.6)
            Dim top As Integer = facePosition.yc - CInt(facePosition.w * 0.5)
            Dim w As Integer = facePosition.w * 1.2

            Dim pen As New Pen(Color.LightGreen, 6)
            gr.DrawRectangle(pen, left, top, w, w)
        End Sub




        Friend Function Enroll_face(id As Integer, name As String) As Boolean
            Dim res = False

            If (FSDK.FSDKE_OK = FSDK.LockID(tracker, id)) Then

                If name Is Nothing Or name.Length <= 0 Then
                    FSDK.SetName(tracker, id, "")
                    FSDK.PurgeID(tracker, id)
                Else
                    FSDK.SetName(tracker, id, name)
                End If
                FSDK.UnlockID(tracker, id)
                res = True
            End If
            Return res
        End Function
#End Region


#Region "inits and cam"
        Public Sub Init()
            If (FSDK.ActivateLibrary("fVrFCzYC5wOtEVspKM/zfLWVcSIZA4RNqx74s+QngdvRiCC7z7MHlSf2w3+OUyAZkTFeD4kSpfVPcRVIqAKWUZzJG975b/P4HNNzpl11edXGIyGrTO/DImoZksDSRs6wktvgr8lnNCB5IukIPV5j/jBKlgL5aqiwSfyCR8UdC9s=") <> FSDK.FSDKE_OK) Then
                MessageBox.Show("Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", "Error activating FaceSDK")
                form.Close()
            End If
            FSDK.InitializeLibrary()
            trackerStateManager.Init()
        End Sub

        Public Sub Close_cam()
            active = False
            FSDKCam.CloseVideoCamera(cameraHandle)
            FSDKCam.FinalizeCapturing()
        End Sub

        Public Sub Start_cam()

            FSDKCam.InitializeCapturing()

            Dim cameralist() As String = Nothing
            Dim count As Integer
            FSDKCam.GetCameraList(cameralist, count)


            If (0 = count) Then
                MessageBox.Show("Please attach a camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                form.Close()
            End If

            Dim formatList() As FSDKCam.VideoFormatInfo = Nothing


            FSDKCam.GetVideoFormatList(cameralist(0), formatList, count)



            Dim cameraName As String
            cameraName = cameralist(0)
            If (FSDKCam.OpenVideoCamera(cameraName, cameraHandle) <> FSDK.FSDKE_OK) Then
                MessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                form.Close()
            End If

            active = True
        End Sub
#End Region


#Region "Trackers"
        Friend Sub Create_tracker(Optional tracker As Integer = 0)
            If (FSDK.FSDKE_OK <> Retrieve_tracker(tracker)) Then ' try to load saved tracker state

                FSDK.CreateTracker(tracker) ' if could not be loaded, create a new tracker
                MsgBox("new tracker", MessageBoxButtons.OK, "start up")
            End If

            Dim err As Integer = 0 ' set realtime face detection parameters
            FSDK.SetTrackerMultipleParameters(tracker, "HandleArbitraryRotations=true; DetermineFaceRotationAngle=false; InternalResizeWidth=200; FaceDetectionThreshold=5;", err)
        End Sub


        Friend Sub Save_tracker()
            Dim bufferSize(0) As Long
            FSDK.GetTrackerMemoryBufferSize(tracker, bufferSize(0))
            Dim trackerBuffer(bufferSize(0)) As Byte
            FSDK.SaveTrackerMemoryToBuffer(tracker, trackerBuffer, 256 * 50000)

            NewQuery("INSERT INTO face_recog (id,tracker) VALUES (1,@tracker)
                                  oN DUPLICATE KEY UPDATE tracker = @tracker", {trackerBuffer}).ExecuteNonQuery()
        End Sub

        Private Function Retrieve_tracker(tracker) As Integer
            Dim res = -1

            Try
                Dim trackerBuffer As Byte() = selectScalarQuery("tracker", "face_recog")
                res = FSDK.LoadTrackerMemoryFromBuffer(tracker, trackerBuffer)
            Catch ex As Exception

            End Try


            Return res
        End Function

        Friend Sub Unenroll_face(Optional id As Integer = Nothing)
            If IsNothing(id) Then id = curr_face_id
            FSDK.SetName(tracker, curr_face_id, "")
            FSDK.PurgeID(tracker, curr_face_id)
        End Sub

        Friend Sub Refresh()
            trackerStateManager.SetState("UnlockingState")
        End Sub
#End Region
    End Class

End Namespace