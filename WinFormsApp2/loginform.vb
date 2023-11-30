Imports MySql.Data.MySqlClient

Public Class loginform


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

    Private Sub mainform_back_btn_Click(sender As Object, e As EventArgs) Handles mainform_back_btn.Click

        staffadminbtns.Show()
        Me.Close()

    End Sub

    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub
End Class
