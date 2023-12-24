
Imports MySql.Data.MySqlClient
Imports WinFormsApp2.Erenjhun.Utils


Public Class Mainform


    Dim facerecog As FaceRecognition
    Friend Shared BRANCH As String
    Const SCHED_LB_TXT As String = "--:-- -- to --:-- --"



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

            NewQuery("insert into emp_attendance (employee_id,workday,date,time_in,time_out,branch_id)
                        values (@ei,@wd,@d,@ti,@to, (select branch_id from qcu_branches where branch_name = @bn limit 1)   )
                ", {id, Now.ToString("dddd"), Now, tin, tout, branch_lb.Text}).ExecuteNonQuery()


            '    InsertQuery("emp_attendance", "employee_id,workday,date,time_in,time_out,branch_id", {
            '      id, Now.ToString("dddd"), Now, tin, tout
            '})

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

    Private Sub Cam_pic_box_Click(sender As Object, e As EventArgs) Handles cam_pic_box.Click
        Dim username = InputBox("Your name:", "Enter your name") 'get the user name
        facerecog.Enroll_face(facerecog.face_id, username)
    End Sub


    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        update_date_time_labels()
        branch_lb.Text = BRANCH



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
        Fetch_all()
    End Sub

    Private Sub Employee_code_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles employee_code_tb.KeyDown

        Dim emp_code As String = ""

        Try
            emp_code = selectScalarQuery("employee_code", "employee_info", {employee_id_tb.Text}, "employee_id = @id")
        Catch ex As Exception
            MessageBox.Show("something went wrong :" & ex.Message, "oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If e.KeyCode <> Keys.Enter Or employee_code_tb.Text = "" Then Exit Sub

        If employee_code_tb.Text <> emp_code Then
            MessageBox.Show("incorrect employee code", "ATTENDANCE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            employee_code_tb.Clear()
            Exit Sub
        End If

        Insert_attendance()

    End Sub


    Private Sub Mainform_back_btn_(sender As Object, e As EventArgs) Handles mainform_back_btn.Click
        staffadminbtns.Show()
        Close()
    End Sub


    Private Sub Employee_id_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles employee_id_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Fetch_all()
        End If
    End Sub

    Private Sub Fetch_all()
        Try
            'check first if the employee has a schedule today in this branch
            Fetch_employee_details(employee_id_tb.Text)
            Fetch_employee_scheds(employee_id_tb.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "FETCH DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    facerecog.Refresh()
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
        Refresh_fields()
        facerecog.Unenroll_face()
        Throw New Exception("NOT FOUND!")
    End Sub

    Public Sub Refresh_fields()
        employee_id_tb.Clear()
        employee_code_tb.Clear()

        time_in_tb.Clear()
        time_out_tb.Clear()
        fullname_lb.Text = "--------,----- ------"
        sched_lb.Text = SCHED_LB_TXT
    End Sub


    Sub Fetch_employee_scheds(id As String)
        Dim reader As MySqlDataReader = SelectQuery("*", "emp_sched_view", {id}, "'Employee ID' = @id and workday = dayname(curdate())")

        Dim branch_t As String = ""

        If reader.Read() Then
            branch_t = reader("branch")

           

            sched_lb.Text = $"{reader("shift start time")} to {reader("shift end time")}"
        End If

          If (String.Compare(BRANCH, branch_t, True) <> 0) Then
                Throw New Exception("You have no schedule in this branch today branch do not match")
                Return
            End If                                   
        If (sched_lb.Text = SCHED_LB_TXT) Then
            Throw New Exception("You have no schedule in this branch today nonono")
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
