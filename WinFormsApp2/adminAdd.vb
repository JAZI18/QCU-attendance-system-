
Imports System.Security.Cryptography
Imports System.Text

Public Class adminAdd


    Private _employeeCode As String




    ' Modify the constructor to accept employeeCode as a parameter
    Public Sub New(employeeCode As String)
        InitializeComponent()
        _employeeCode = employeeCode

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hashedPasswords As String = HashedPassword(TextBox1.Text)


        Try
            InsertQuery("admin_account", "username,password,employee_info", {e_firstname.Text, hashedPasswords, _employeeCode})
            MessageBox.Show("Record inserted successfully.")
            Me.Close()

        Catch ex As Exception
            e_firstname.Clear()
            TextBox1.Clear()
            MessageBox.Show("An error occurred: ")
        End Try


    End Sub

    Public Function HashedPassword(password As String)
        Using sha256 As New SHA256Managed()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower()

        End Using
    End Function

End Class