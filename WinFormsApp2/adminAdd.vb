
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class adminAdd


    Private _employeeCode As String




    ' Modify the constructor to accept employeeCode as a parameter
    Public Sub New(employeeCode As String)
        InitializeComponent()
        _employeeCode = employeeCode

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hashedPasswords As String = HashedPassword(e_password.Text)
        Dim reader As MySqlDataReader = SelectQuery("*", "admin_account", {_employeeCode}, "employee_info = @params")

        If e_password.Text = "" Or e_firstname.Text = "" Then
            MsgBox("Please fill all empty field")

            Exit Sub
        End If


        If reader.Read Then
            MsgBox("It has already an admin account")
            Me.Close()
        Else

            Try
                InsertQuery("admin_account", "username,password,employee_info", {e_firstname.Text, hashedPasswords, _employeeCode})
                MessageBox.Show("Record inserted successfully.")
                admindashboardform.Enabled = True
                Me.Close()

            Catch ex As Exception
                e_firstname.Clear()
                e_password.Clear()
                MessageBox.Show("An error occurred: ")
            End Try
        End If
    End Sub

    Public Function HashedPassword(password As String)
        Using sha256 As New SHA256Managed()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower()

        End Using
    End Function

End Class