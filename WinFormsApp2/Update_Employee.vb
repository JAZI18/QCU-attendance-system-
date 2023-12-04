Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1

Public Class Update_Employee

    Private _employeeCode As String

    Private _name As String

    Private _depname As String


    ' Modify the constructor to accept employeeCode as a parameter
    Public Sub New(employeeCode As String, name As String, depname As String)
        InitializeComponent()
        _employeeCode = employeeCode
        _name = name
        _depname = depname
    End Sub

    Private Sub submit_employees_btn_Click(sender As Object, e As EventArgs) Handles submit_employees_btn.Click

    End Sub

    Private Sub Update_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assuming _employeeCode is used in your SelectQuery
        Dim reader As MySqlDataReader = SelectQuery("*", "employee_info", {_employeeCode}, "employee_id=@em")
        ComboBox1.Items.Add(_depname)

        If reader.Read Then
            e_firstname.Text = reader("first_name")
            e_middlename.Text = reader("middle_name")
            TextBox1.Text = reader("last_name")
            e_email.Text = reader("email")
            Dim dobValue As DateTime = reader.GetDateTime(reader.GetOrdinal("dob"))
            e_date.Value = dobValue
            ComboBox2.SelectedItem = reader("gender")
            ListDepartment(reader.GetInt32("department_id"))
            ' Set the selected item in e_dep ComboBox using the _depname value

        End If


    End Sub


    Public Sub ListDepartment(number As Integer)
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department")
        ComboBox1.Items.Clear()
        While reader.Read
            ComboBox1.Items.Add(reader("department_name"))
        End While
        ComboBox1.SelectedIndex = number
        reader.Close()
    End Sub



End Class