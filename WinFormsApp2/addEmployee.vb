Imports MySql.Data.MySqlClient

Public Class addEmployee

    Public Sub ListDepartment()
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department")
        e_dep.Items.Clear()
        While reader.Read
            e_dep.Items.Add(reader("department_name"))
        End While
        e_dep.SelectedIndex = 0
        reader.Close()
    End Sub
    Private Sub submit_employees_btn_(sender As Object, e As EventArgs) Handles submit_employees_btn.Click

        Try
            InsertQuery("employee_info", "employee_code,first_name,middle_name,last_name,dob,gender,department_id,email",
        {GenerateEmployeeCode(), e_firstname.Text, e_middlename.Text, e_lastname.Text, e_date.Value.ToString("yyyy/MM/dd"),
         e_gender.SelectedItem.ToString, 2.ToString, e_email.Text})
            MessageBox.Show("Record inserted successfully.")

            admindashboardform.updateEmpployeeGrid()
            Me.Close()

        Catch ex As Exception
            e_firstname.Clear()
            e_middlename.Clear()
            e_lastname.Clear()
            e_email.Clear()
            e_gender.SelectedItem = Nothing
            e_date.Value = Date.Now
            MessageBox.Show("An error occurred: ")
        End Try


    End Sub
    Public Function GenerateEmployeeCode() As String
        ' Get the year
        Dim yearCode As String = DateTime.Now.ToString("yy")

        ' Generate a random four-digit number
        Dim random As New Random()
        Dim randomNumber As Integer = random.Next(1000, 10000)


        Dim employeeCode As String = $"{yearCode}-{randomNumber:0000}"

        Return employeeCode
    End Function

    Private Sub addEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListDepartment()
    End Sub

End Class