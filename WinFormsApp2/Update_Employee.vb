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


    Private Sub Update_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assuming _employeeCode is used in your SelectQuery
        Dim reader As MySqlDataReader = SelectQuery("*", "employee_info", {_employeeCode}, "employee_id=@em")


        If reader.Read Then
            e_firstname.Text = reader("first_name")
            e_middlename.Text = reader("middle_name")
            e_lastname.Text = reader("last_name")
            e_email.Text = reader("email")

            ' Ensure that the value is not DBNull before assigning it to the DateTimePicker
            If Not reader.IsDBNull(reader.GetOrdinal("dob")) Then
                Dim dobValue As Date = reader.GetDateTime(reader.GetOrdinal("dob"))
                e_date.Value = dobValue
            Else
                ' Handle the case where 'dob' is DBNull in the database
                ' You may set a default value or handle it according to your application logic
            End If

            gender.SelectedItem = reader("gender")
            ListDepartment(reader.GetInt32("department_id"))
        End If
    End Sub

    Private Sub submit_employees_btn_Click(sender As Object, e As EventArgs)

        Dim result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            UpdateQuery("employee_info", "first_name,middle_name,last_name,dob,gender,department_id", {e_firstname.Text, e_middlename.Text, e_lastname.Text, e_date.Value.ToString("yyyy/MM/dd"), gender.SelectedItem, selectDepartment()}, "employee_id=" & _employeeCode)
            e_date.Value = Date.Now
            e_firstname.Clear()
            e_middlename.Clear()
            e_lastname.Clear()
            department.Items.Clear()
            gender.Items.Clear()
            MsgBox("Recorded Inserted")
            Close()

            admindashboardform.updateEmpployeeGrid()
        Else
            MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub ListDepartment(number As Integer)
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department")
        department.Items.Clear()
        While reader.Read
            department.Items.Add(reader("department_name"))
        End While
        department.SelectedIndex = number - 1
        reader.Close()
    End Sub





    Function selectDepartment() As Integer
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department", {department.SelectedItem}, "department_name=@deparment")

        If reader.Read Then
            If Not reader.IsDBNull(reader.GetOrdinal("department_id")) Then
                Dim departmentId As Integer = reader.GetInt32("department_id")
                Console.WriteLine("Department ID: " & departmentId)
                Return departmentId
            End If
        End If


        Return Nothing
    End Function

    Private Sub submit_employees_btn_Click_1(sender As Object, e As EventArgs) Handles submit_employees_btn.Click
        If e_firstname.Text = "" Or e_lastname.Text = "" Or e_middlename.Text = "" Or e_email.Text = "" Or e_date.Text = "" Or gender.Text = "" Or department.Text = "" Then Exit Sub

    End Sub
End Class