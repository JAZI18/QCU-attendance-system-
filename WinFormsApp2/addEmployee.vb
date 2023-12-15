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

    Function selectDepartment() As Integer
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department", {e_dep.SelectedItem}, "department_name=@deparment")

        If reader.Read Then
            If Not reader.IsDBNull(reader.GetOrdinal("department_id")) Then
                Dim departmentId As Integer = reader.GetInt32("department_id")
                Console.WriteLine("Department ID: " & departmentId)
                Return departmentId
            End If
        End If
        Return Nothing
    End Function

    Public Function GenerateEmployeeCode() As String
        ' Get the year
        Dim yearCode As String = DateTime.Now.ToString("yy")

        ' Generate a random four-digit number
        Dim random As New Random()
        Dim randomNumber As Integer = random.Next(1000, 10000)


        Dim employeeCode As String = $"{yearCode}-{randomNumber:0000}"

        Return employeeCode
    End Function

    Private Sub submit_employees_btn_Click(sender As Object, e As EventArgs) Handles submit_employees_btn.Click
        If e_firstname.Text = "" Or e_lastname.Text = "" Or e_middlename.Text = "" Or e_date.Text = "" Or e_email.Text = "" Or e_gender.Text = "" Or e_dep.Text = "" Then

            MsgBox(e_dep.SelectedItem)
            Try
                InsertQuery("employee_info", "employee_code,first_name,middle_name,last_name,dob,gender,department_id,email",
        {GenerateEmployeeCode(), e_firstname.Text, e_middlename.Text, e_lastname.Text, e_date.Value.ToString("yyyy/MM/dd"),
         e_gender.SelectedItem.ToString, selectDepartment(), e_email.Text})
                MessageBox.Show("Record inserted successfully.")

                admindashboardform.updateEmpployeeGrid()
                admindashboardform.Enabled = True
                Close()

            Catch ex As Exception
                e_firstname.Clear()
                e_middlename.Clear()
                e_lastname.Clear()
                e_email.Clear()
                e_gender.SelectedItem = Nothing
                e_date.Value = Date.Now
                MessageBox.Show("An error occurred: ")
            End Try
            Exit Sub
        End If
    End Sub

    Private Sub addEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListDepartment()
        e_gender.SelectedIndex = 0
    End Sub
End Class