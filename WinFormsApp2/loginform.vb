Imports MySql.Data.MySqlClient

Public Class loginform
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn.Click

        Dim reader As MySqlDataReader = selectQuery("password", "admin_account", {un_tb.Text}, "username = @username")

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
End Class
