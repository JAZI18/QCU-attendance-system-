Imports WinFormsApp2.Erenjhun.Utils

Public Class addLeave



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles add_leave_btn.Click

        Dim branch_id = selectScalarQuery("branch_id", "qcu_branches")

        MsgBox(date_picker.Value)

        InsertQuery("emp_leave", "employee_id,branch_id,leave_date", {code_tb.Text, branch_id, date_picker.Value})
    End Sub

    Private Sub Emp_code_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles code_tb.TextChanged
        If (code_tb.Text.Length < 7) Then
            emp_name_tb.Clear()
            Return
        End If
        emp_name_tb.Text = selectScalarQuery($"concat(first_name,' ',last_name)", "employee_info", {code_tb.Text}, "employee_id = @id")
    End Sub



    Private Sub addLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim reader = SelectQuery("employee_id as id", "employee_info")

        While reader.Read
            code_tb.AutoCompleteCustomSource.Add(reader("id"))
        End While


        reader = SelectQuery("branch_name as branch", "qcu_branches")

        While reader.Read
            branch_tb.AutoCompleteCustomSource.Add(reader("branch"))
        End While
    End Sub
End Class