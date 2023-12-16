Imports MySql.Data.MySqlClient

Public Class viewAbsent
    Private Sub viewAbsent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        absentLoad()
    End Sub

    Function absentLoad()
        Dim reader As MySqlDataReader = SelectQuery("*", "absent_emp")
        While reader.Read

            DataGridView1.Rows.Add(reader("employee_code"), reader("branch_name"), reader("employee_Name"), reader("workday"), CType(reader("date"), DateTime).ToString("yyyy-MM-dd"), reader("status"))

        End While
    End Function
End Class