Imports MySql.Data.MySqlClient

Public Class mainform
    Private Sub mainform_back_btn_(sender As Object, e As EventArgs) Handles mainform_back_btn.Click

        staffadminbtns.Show()
        Close()

    End Sub

    Private Sub employee_id_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles employee_id_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Fetch_employee_details(employee_id_tb.Text)
            Fetch_employee_scheds(employee_id_tb.Text)
        End If


    End Sub

    Sub Fetch_employee_details(id As String)

        Dim reader As MySqlDataReader = SelectQuery("*", "employee_info", {id}, "employee_id = @id")
        If reader.Read() Then
            employee_code_tb.Text = $"{reader("employee_code")}"
            fullname_lb.Text = $"{reader("last_name")}, {reader("first_name")} {reader("middle_name").substring(0, 1)}."
            morning_in_tb.Text = DateTime.Now.ToString("hh:mm tt")
        End If





    End Sub

    Sub Fetch_employee_scheds(id As String)

        Dim reader As MySqlDataReader = SelectQuery("*", "emloyee_schedule", {id}, "employee_id = @id")
        If reader.Read() Then


            sched_lb.Text = $"{New DateTime(1, 1, 1).Add(reader("shift_start_time")).ToString("hh:mm tt")} to {New DateTime(1, 1, 1).Add(reader("shift_end_time")).ToString("hh:mm tt")}"
        End If
    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub morning_in_tb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles morning_in_tb.KeyPress

        e.Handled = True
    End Sub


End Class