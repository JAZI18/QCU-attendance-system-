Imports MySql.Data.MySqlClient

Public Class loginform
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim A As Integer = 1
        'NewQuery("INSERT INTO qcu_department (department_name) VALUES (@params2)", {"sadsa"}).ExecuteNonQuery()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn.Click

        Dim reader As MySqlDataReader = SelectQuery("password", "admin_account", {un_tb.Text}, "username = @username")

        If Not reader.Read() Then
            invalid_lb.Visible = True
            un_tb.Clear()
            pass_tb.Clear()
            Exit Sub
        End If

        If reader("password") = pass_tb.Text Then
            Me.Hide()
            admindashboardform.Show()
        Else
            invalid_lb.Visible = True
        End If

        un_tb.Clear()
        pass_tb.Clear()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
