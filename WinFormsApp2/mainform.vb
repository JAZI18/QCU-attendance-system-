Imports MySql.Data.MySqlClient
Imports Luxand
Imports System.Timers

Public Class mainform

    Private timers As New Dictionary(Of String, Timer)

    Dim cameraHandle As Integer
    Dim needClose As Boolean = True
    Dim userName As String
    Dim tracker As Integer = 0  ' creating a Tracker

    Dim curr_emp_id As Integer = -1
    Dim prev_emp_id As Integer = -2

    Dim unenrolled_id As Integer = -1 'for testing

#Region "enums and states"
    Enum tracker_states
        finding_face
        unlocking_face
        found_face
    End Enum
    Dim tracker_state As tracker_states = tracker_states.finding_face
#End Region

    ' WinAPI procedure to release HBITMAP handles returned by FSDKCam.GrabFrame
    Declare Auto Function DeleteObject Lib "gdi32.dll" (hObject As IntPtr) As Boolean


    Private Sub cam_pic_box_Click(sender As Object, e As EventArgs) Handles cam_pic_box.Click
        Enroll_face(unenrolled_id)
    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init_fsdk()
        Start_cam()

        Create_tracker()

        Start_timer(Sub()
                        Live_feed()
                    End Sub, "s")
    End Sub

    Private Sub Live_feed()
        needClose = False

        Dim image As FSDK.CImage
        Dim frameImage As Image


        While Not needClose
            Dim ImageHandle As Integer


            ' grab the current frame from the camera
            If (FSDKCam.GrabFrame(cameraHandle, ImageHandle) <> FSDK.FSDKE_OK) Then
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


            Dim id = IDs.First

            Draw_Rect(id, frameImage)
            Display_vid(frameImage)


            If id = 0 Then
                'if no face detected

                If curr_emp_id = -1 Then
                    'if there is no recent face detected
                    pic_border.BackColor = Color.Blue
                Else
                    If tracker_state = tracker_states.unlocking_face Then Continue While
                    tracker_state = tracker_states.unlocking_face

                    'find face again after 1 second
                    Start_timer(Sub()
                                    Refresh_fields()
                                    curr_emp_id = -1
                                    pic_border.BackColor = Color.Blue
                                    tracker_state = tracker_states.finding_face
                                End Sub, "unlocking face", 600)
                End If
                unenrolled_id = -1
            Else
                'face detected
                Dim image_tag_name As String = ""
                Dim res As Integer = FSDK.GetAllNames(tracker, id, image_tag_name, 100) ' maximum of 100 characters

                If image_tag_name.Length > 0 Then
                    'if face is recognized


                    If tracker_state <> tracker_states.found_face Then
                        'first time
                        Face_detected(image_tag_name)

                    Else
                        If prev_emp_id <> id Then
                            Face_detected(image_tag_name)
                        End If
                        'not the same as last
                        Stop_timer("unlocking face")
                    End If

                    curr_emp_id = id 'set the curr_emp_id
                    pic_border.BackColor = Color.LightGreen
                    tracker_state = tracker_states.found_face
                    unenrolled_id = -1
                Else
                    'face not recognized
                    Refresh_fields()
                    pic_border.BackColor = Color.Red
                    unenrolled_id = id
                End If
            End If
        End While
    End Sub


    Private Sub Display_vid(frameImage As Image)
        frameImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
        cam_pic_box.Image = frameImage ' display current frame
        GC.Collect() ' collect the garbage after the deletion
        Application.DoEvents() ' make UI controls accessible
    End Sub


    Private Sub Face_detected(image_tag_name)
        employee_id_tb.Text = image_tag_name
        fetch_all()
    End Sub

    Private Sub employee_code_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles employee_code_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            insert_attendance()
        End If
    End Sub

    Private Sub insert_attendance()
        Throw New NotImplementedException()
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

    Private Sub Enroll_face(id As Integer)

        If id = -1 Then
            MsgBox("no face detected")
            Exit Sub
        End If


        If (FSDK.FSDKE_OK = FSDK.LockID(tracker, id)) Then

            userName = InputBox("Your name:", "Enter your name") 'get the user name
            If userName Is Nothing Or userName.Length <= 0 Then
                FSDK.SetName(tracker, id, "")
                FSDK.PurgeID(tracker, id)

            Else
                FSDK.SetName(tracker, id, userName)
                unenrolled_id = -1
            End If
            FSDK.UnlockID(tracker, id)
        End If

        Save_tracker()
    End Sub



    Private Sub close_save()
        Save_tracker()
        FSDKCam.CloseVideoCamera(cameraHandle)
        FSDKCam.FinalizeCapturing()
    End Sub

    Private Sub mainform_back_btn_(sender As Object, e As EventArgs) Handles mainform_back_btn.Click
        staffadminbtns.Show()
        Close()
    End Sub


    Private Sub employee_id_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles employee_id_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            fetch_all()
        End If
    End Sub

    Private Sub fetch_all()
        Try
            Fetch_employee_details(employee_id_tb.Text)
            Fetch_employee_scheds(employee_id_tb.Text)
        Catch ex As Exception
            MsgBox($"ooops cannot load details! \n {ex.Message}", MsgBoxStyle.OkOnly, "something went wrong!")
            Refresh_fields()
        End Try

    End Sub

    Sub Fetch_employee_details(id As String)

        Dim reader As MySqlDataReader = SelectQuery("*", "employee_info", {id}, "employee_id = @id")

        If reader.Read() Then
            fullname_lb.Text = $"{reader("last_name")}, {reader("first_name")} {reader("middle_name").substring(0, 1)}."
            Dim time_in = selectScalarQuery("CASE WHEN time_in IS  NULL THEN  'null'  ELSE time_in  END AS timed_in", "emp_attendance", {id}, "employee_id  = @eid AND emp_attendance.date = CURDATE()")
            Dim ntime_in = If(time_in = Nothing, Date.Now, CDate(time_in))

            If (time_in Is Nothing) Then
                morning_in_tb.Text = ntime_in.ToString("hh:mm tt")
            Else

            End If
            Exit Sub
        End If
        EmpNotFound()
    End Sub


    Sub EmpNotFound()
        MsgBox("not found", MsgBoxStyle.Exclamation, "ooops!")
        Refresh_fields()

        FSDK.SetName(tracker, curr_emp_id, "")
        FSDK.PurgeID(tracker, curr_emp_id)
    End Sub

    Private Sub Refresh_fields()
        employee_id_tb.Clear()
        morning_in_tb.Clear()
        fullname_lb.Text = "-------------------"
        sched_lb.Text = "--:----- to --:----"
    End Sub


    Sub Fetch_employee_scheds(id As String)

        Dim reader As MySqlDataReader = SelectQuery("*", "employee_schedule", {id}, "employee_id = @id")
        If reader.Read() Then
            sched_lb.Text = $"{New DateTime(1, 1, 1).Add(reader("shift_start_time")).ToString("hh:mm tt")} to {New DateTime(1, 1, 1).Add(reader("shift_end_time")).ToString("hh:mm tt")}"
        End If
    End Sub


    Private Sub mainform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        close_save()
    End Sub





#Region "helper functions"

    Private Sub Start_timer(f As Action, t_name As String, Optional interval As Integer = 1000)


        If timers.ContainsKey(t_name) Then
            With timers.Item(t_name)
                .Stop()
                .Dispose()
            End With

            timers.Remove(t_name)
        End If

        Dim delay_timer As New Timer With {
            .Interval = interval,
            .AutoReset = False
        }

        AddHandler delay_timer.Elapsed, Sub()
                                            f()
                                            With delay_timer
                                                .Stop()
                                                .Dispose()
                                            End With
                                            timers.Remove(t_name)
                                        End Sub

        timers.Add(t_name, delay_timer)
        delay_timer.Start()
    End Sub


    Private Sub Stop_timer(t_name As String)
        Try
            timers.Item(t_name).Dispose()
        Catch ex As Exception
        End Try

        timers.Remove(t_name)
    End Sub

    Private Sub Init_fsdk()
        If (FSDK.ActivateLibrary("fVrFCzYC5wOtEVspKM/zfLWVcSIZA4RNqx74s+QngdvRiCC7z7MHlSf2w3+OUyAZkTFeD4kSpfVPcRVIqAKWUZzJG975b/P4HNNzpl11edXGIyGrTO/DImoZksDSRs6wktvgr8lnNCB5IukIPV5j/jBKlgL5aqiwSfyCR8UdC9s=") <> FSDK.FSDKE_OK) Then
            MessageBox.Show("Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", "Error activating FaceSDK")
            Close()
        End If

        FSDK.InitializeLibrary()
    End Sub


    Private Sub Start_cam()
        FSDKCam.InitializeCapturing()

        Dim cameralist() As String = Nothing
        Dim count As Integer
        FSDKCam.GetCameraList(cameralist, count)


        If (0 = count) Then
            MessageBox.Show("Please attach a camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If

        Dim formatList() As FSDKCam.VideoFormatInfo = Nothing


        FSDKCam.GetVideoFormatList(cameralist(0), formatList, count)



        Dim cameraName As String
        cameraName = cameralist(0)
        If (FSDKCam.OpenVideoCamera(cameraName, cameraHandle) <> FSDK.FSDKE_OK) Then
            MessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If
    End Sub


    Private Sub Create_tracker()
        If (FSDK.FSDKE_OK <> Retrieve_tracker()) Then ' try to load saved tracker state
            MsgBox("creating new tracker!")
            FSDK.CreateTracker(tracker) ' if could not be loaded, create a new tracker
        End If

        Dim err As Integer = 0 ' set realtime face detection parameters
        FSDK.SetTrackerMultipleParameters(tracker, "HandleArbitraryRotations=true; DetermineFaceRotationAngle=false; InternalResizeWidth=200; FaceDetectionThreshold=5;", err)
    End Sub


    Private Sub Save_tracker()
        Dim bufferSize(0) As Long
        FSDK.GetTrackerMemoryBufferSize(tracker, bufferSize(0))
        Dim trackerBuffer(bufferSize(0)) As Byte
        FSDK.SaveTrackerMemoryToBuffer(tracker, trackerBuffer, 256 * 5000)

        UpdateQuery("face_recog", "tracker", {trackerBuffer})
    End Sub

    Private Function Retrieve_tracker() As Integer
        Try
            Dim trackerBuffer As Byte() = selectScalarQuery("tracker", "face_recog")
            Return FSDK.LoadTrackerMemoryFromBuffer(tracker, trackerBuffer)
        Catch ex As Exception
        End Try
        Return -1
    End Function

#End Region

End Class