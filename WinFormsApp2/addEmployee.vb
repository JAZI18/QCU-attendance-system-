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


        MsgBox(e_dep.SelectedItem)
        Try
            InsertQuery("employee_info", "employee_code,first_name,middle_name,last_name,dob,gender,department_id,email",
        {GenerateEmployeeCode(), e_firstname.Text, e_middlename.Text, e_lastname.Text, e_date.Value.ToString("yyyy/MM/dd"),
         e_gender.SelectedItem.ToString, selectDepartment(), e_email.Text})
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
    Function selectDepartment() As Integer
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department", {e_dep.SelectedItem}, "department_name=@deparment")

        If reader.Read Then
            If Not reader.IsDBNull(reader.GetOrdinal("department_id")) Then
                Dim departmentId As Integer = reader.GetInt32("department_id")
                Console.WriteLine("Department ID: " & departmentId)
                Return departmentId
            End If
        End If



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

    Private Sub addEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListDepartment()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    TabPage9.BackColor = Color.Black
    'End Sub

    Private Sub TabPage9_Click(sender As Object, e As EventArgs) Handles TabPage9.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class