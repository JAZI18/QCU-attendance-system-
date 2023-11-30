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
    Private Sub submit_employees_btn_(sender As Object, e As EventArgs) Handles submit_employees_btn.Click, submit_employees_btn.Click

        MessageBox.Show(GenerateEmployeeCode)
        Try

            InsertQuery("employee_info", "employee_code,first_name,middle_name,last_name,dob,gender,department_id,email",
        {"132", e_firstname.Text, e_middlename.Text, e_lastname.Text, e_date.Value.ToString("yyyy/MM/dd"),
         e_gender.SelectedItem.ToString, 2.ToString, e_email.Text})

            MessageBox.Show("Record inserted successfully.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.StackTrace)
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
End Class