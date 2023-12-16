Imports Luxand
Imports MySql.Data.MySqlClient
Imports WinFormsApp2.Erenjhun.Utils


Public Class mainform


    Dim facerecog As FaceRecognition


    ' WinAPI procedure to release HBITMAP handles returned by FSDKCam.GrabFrame
    Declare Auto Function DeleteObject Lib "gdi32.dll" (hObject As IntPtr) As Boolean


    Private Sub cam_pic_box_Click(sender As Object, e As EventArgs) Handles cam_pic_box.Click
        Dim username = InputBox("Your name:", "Enter your name") 'get the user name
        facerecog.Enroll_face(facerecog.face_id, username)
    End Sub


    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time_lb.Text = DateTime.Now.ToString("hh:mm:ss tt")
        date_lb.Text = Date.Now.ToString("MMMM dd, yyyy")


        facerecog = New FaceRecognition({
                                        New MainformStates.FindingState(),
                                        New MainformStates.UnrecognizedFaceFoundState(),
                                        New MainformStates.RecognizedFaceFoundState(),
                                        New FoundState(),
                                        New UnlockingState()
                                        }, Me, cam_pic_box)

        facerecog.Init()
        facerecog.Create_tracker()

        Start_timer(Sub()
                        facerecog.Start_cam()
                        facerecog.Run()
                    End Sub, "s")
    End Sub



    Public Sub Face_detected(image_tag_name)
        employee_id_tb.Text = image_tag_name
        fetch_all()
    End Sub

    Private Sub employee_code_tb_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Insert_attendance()
        End If
    End Sub

    Private Sub Insert_attendance()
        Throw New NotImplementedException()
    End Sub


    Private Sub mainform_back_btn_(sender As Object, e As EventArgs) Handles mainform_back_btn.Click
        staffadminbtns.Show()
        Close()
    End Sub


    Private Sub employee_id_tb_KeyDown(sender As Object, e As KeyEventArgs)
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
                time_in_tb.Text = ntime_in.ToString("hh:mm tt")
            Else

            End If
            Exit Sub
        End If
        EmpNotFound()
    End Sub


    Sub EmpNotFound()
        MsgBox("not found", MsgBoxStyle.Exclamation, "ooops!")
        Refresh_fields()
        facerecog.unenroll_face()
    End Sub

    Public Sub Refresh_fields()
        employee_id_tb.Clear()
        time_in_tb.Clear()
        fullname_lb.Text = "--------,----- ------"
        sched_lb.Text = "--:-- -- to --:-- --"
    End Sub


    Sub Fetch_employee_scheds(id As String)

        Dim reader As MySqlDataReader = SelectQuery("*", "employee_schedule", {id}, "employee_id = @id")
        If reader.Read() Then
            sched_lb.Text = $"{New DateTime(1, 1, 1).Add(reader("shift_start_time")).ToString("hh:mm tt")} to {New DateTime(1, 1, 1).Add(reader("shift_end_time")).ToString("hh:mm tt")}"
        End If
    End Sub

    Private Sub mainform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Close_save()
    End Sub

    Private Sub Close_save()
        facerecog.Save_tracker()
        facerecog.Close_cam()
    End Sub

End Class