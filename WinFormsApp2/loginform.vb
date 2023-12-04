Imports System.Text
Imports MySql.Data.MySqlClient


Imports System.Security.Cryptography


Public Class loginform


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn.Click

        ' Hash the entered password
        Dim hashedPassword As String = HashedPasswords(pass_tb.Text)

        ' Fetch the hashed password from the database
        Dim reader As MySqlDataReader = SelectQuery("password", "admin_account", {un_tb.Text}, "username = @username")

        If Not reader.Read() Then
            invalid_lb.Visible = True
            un_tb.Clear()
            pass_tb.Clear()
            Exit Sub
        End If

        ' Compare hashed passwords
        If reader("password") = hashedPassword Then
            Me.Hide()
            admindashboardform.Show()
        Else
            invalid_lb.Visible = True
        End If

        un_tb.Clear()
        pass_tb.Clear()

    End Sub

    Public Function HashedPasswords(password As String)
        Using sha256 As New SHA256Managed()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub mainform_back_btn_Click(sender As Object, e As EventArgs) Handles mainform_back_btn.Click

        staffadminbtns.Show()
        Me.Close()

    End Sub
End Class
