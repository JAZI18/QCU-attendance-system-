Imports Luxand
Imports MySql.Data.MySqlClient
Imports WinFormsApp2.Erenjhun.Utils


Public Class mainform


    Dim facerecog As FaceRecognition
    Dim last_attendance_id = -1

    ' WinAPI procedure to release HBITMAP handles returned by FSDKCam.GrabFrame
    Declare Auto Function DeleteObject Lib "gdi32.dll" (hObject As IntPtr) As Boolean

    Private Sub Insert_attendance()

        Dim tin = time_in_tb.Text
        Dim tout = time_out_tb.Text
        Dim id = employee_id_tb.Text


        Try

            If tout <> "" Then
                'assume that the record has already the time in
                'sojust update the timeout part
                UpdateQuery("emp_attendance",
                            "time_out", {tout, id},
                             "employee_id = @id AND emp_attendance.date = CURDATE()")
                Exit Try
            End If

            InsertQuery("emp_attendance", "employee_id,workday,date,time_in,time_out,over_time_in,over_time_out", {
              id, Now.ToString("dddd"), Now, tin, tout,
              overtime_in_tb.Text, overtime_out_tb.Text
        })

            MessageBox.Show(Me, $"SUCCESS!!! TIME {If(tout = "", "IN", "OUT")} : {If(tout = "", tin, tout)}", $"TIME {If(tout = "", "IN", "OUT")}", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(Me, $"OOPS!!! SOMETHING WENT WRONG : {ex.Message} {vbCrLf} enter code to try again", $"TIME {If(tout = "", "IN", "OUT")}", MessageBoxButtons.OK)
            employee_code_tb.Clear()
        End Try
        Refresh_fields()
    End Sub



    Private Sub update_date_time_labels()
        Dim date_timer As New Timer()

        'date_timer.Interval =  Now.to

        date_timer.Interval = 600
        date_timer.Start()

        AddHandler date_timer.Tick, Sub()
                                        time_lb.Text = Now.ToString("hh:mm:ss tt")
                                        date_lb.Text = Now.ToString("MMMM dd, yyyy")
                                    End Sub
    End Sub

    Private Sub cam_pic_box_Click(sender As Object, e As EventArgs) Handles cam_pic_box.Click
        Dim username = InputBox("Your name:", "Enter your name") 'get the user name
        facerecog.Enroll_face(facerecog.face_id, username)
    End Sub


    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        update_date_time_labels()

        facerecog = New FaceRecognition({
                                        New MainformStates.FindingState(),
                                        New MainformStates.UnrecognizedFaceFoundState(),
                                        New MainformStates.RecognizedFaceFoundState(),
                                        New FoundState(),
                                        New UnlockingState()
                                        }, Me, cam_pic_box)

        facerecog.Init()

        While True
            Try
                facerecog.Create_tracker()

                Exit While
            Catch ex As Exception
                Dim res As Integer = MessageBox.Show($"{ex.Message}", "oops!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                If res = DialogResult.Cancel Then
                    staffadminbtns.Show()
                    Me.Close()
                End If
            End Try
        End While



        Start_timer(Sub()
                        facerecog.Start_cam()
                        facerecog.Run()

                    End Sub, "s")
    End Sub



    Public Sub Face_detected(image_tag_name)
        employee_id_tb.Text = image_tag_name
        fetch_all()
    End Sub

    Private Sub employee_code_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles employee_code_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Insert_attendance()
        End If
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

        Dim time_out = selectScalarQuery("time_out", "emp_attendance", {id}, "employee_id  = @eid AND emp_attendance.date = CURDATE()")

        Try
            If time_out.ToString() <> "00:00:00" Then
                cam_pic_box.Image = My.Resources.roblox

                Dim res = MessageBox.Show($"You have already TIMED OUT{vbCrLf}Do you want to continue?", "time out warning", MessageBoxButtons.YesNo)

                If res = DialogResult.No Then
                    Refresh_fields()
                    Exit Sub
                End If

            End If
        Catch ex As Exception

        End Try


        Dim reader As MySqlDataReader = SelectQuery("*", "employee_info", {id}, "employee_id = @id")

        If reader.Read() Then





            fullname_lb.Text = $"{reader("last_name")}, {reader("first_name")} {reader("middle_name").substring(0, 1)}."
            Dim time_in = selectScalarQuery("CASE WHEN time_in IS  NULL THEN  'null'  ELSE time_in  END AS timed_in", "emp_attendance", {id}, "employee_id  = @eid AND emp_attendance.date = CURDATE()")
            Dim ntime_in = If(time_in = Nothing, Now, CDate(time_in)).ToString("hh:mm tt")



            time_in_tb.Text = ntime_in
            time_out_tb.Text = If(time_in = Nothing, "", Now.ToString("hh:mm tt"))
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
        employee_code_tb.Clear()

        time_in_tb.Clear()
        time_out_tb.Clear()
        fullname_lb.Text = "--------,----- ------"
        sched_lb.Text = "--:-- -- to --:-- --"
        facerecog.Refresh()
    End Sub


    Sub Fetch_employee_scheds(id As String)
        Dim reader As MySqlDataReader = SelectQuery("*", "employee_schedule", {id}, "employee_id     = @id")
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