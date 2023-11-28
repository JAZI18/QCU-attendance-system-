Imports MySql.Data.MySqlClient

Public Class mainform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles mainform_back_btn.Click

        staffadminbtns.Show()
        Close()

    End Sub

    Private Sub employee_code_tb_TextChanged(sender As Object, e As EventArgs) Handles employee_code_tb.TextChanged

    End Sub

    Private Sub employee_id_tb_TextChanged(sender As Object, e As EventArgs) Handles employee_id_tb.TextChanged

        Fetch_employee_details(employee_id_tb.Text)

    End Sub

    Sub Fetch_employee_details(id As String)

        Dim reader As MySqlDataReader = SelectQuery("*", "employee_info", {id}, "employee_id = @id")
        If reader.Read() Then
            fullname_lb.Text = $"{reader("last_name")}, {reader("first_name")} {reader("middle_name").substring(0, 1)}."

        End If


    End Sub
End Class