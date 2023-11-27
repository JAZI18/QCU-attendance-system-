Imports MySql.Data.MySqlClient

Public Class Form1
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        insertQuery("administrator", "password", {"123"})
        updateQuery("administrator", "password", {"0"})
        deleteQuery("administrator", "1", {})
        Dim reader As MySqlDataReader = selectQuery("Password", "administrator")

        If reader.Read() Then
            MsgBox(reader("Password"))
        End If

        deleteQuery("administrator", "1", {})
        Dim reader2 As MySqlDataReader = selectQuery("Password", "administrator")

        If reader2.Read() Then
            MsgBox(reader2("Password"))
        End If


        'If TextBox1.Text() = "admin" And TextBox2.Text() = "admin" Then
        '    Me.Hide()
        '    form2.Show()

        'End If
    End Sub
End Class
