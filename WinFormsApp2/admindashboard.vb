Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities

Public Class admindashboardform
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        TabControl1.SelectedTab = TabPage1
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


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        MessageBox.Show(GenerateEmployeeCode())
        Try

            InsertQuery("employee_info", "employee_code,first_name,middle_name,last_name,dob,gender,department_id,email",
        {"132", e_firstname.Text, e_middlename.Text, e_lastname.Text, e_date.Value.ToString("yyyy/MM/dd"),
         e_gender.SelectedItem.ToString(), 2.ToString(), e_email.Text})

            MessageBox.Show("Record inserted successfully.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.StackTrace)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles employee_btn.Click
        employee_grid_view.Rows.Clear()
        TabControl1.SelectedTab = TabPage2

        Dim command As MySqlCommand = NewQuery("SELECT e.employee_id, e.first_name, e.last_name, e.middle_name, e.department_id, e.gender, e.email, e.dob, d.department_name FROM employee_info e JOIN qcu_department d ON e.department_id = d.department_id", Nothing)

        ' Execute the command to get the reader
        Dim reader As MySqlDataReader = command.ExecuteReader()

        ' Create a while loop to fetch all data from the database'
        While reader.Read
            ' Check if the values are not DBNull before concatenating
            Dim lastName As String = If(Not IsDBNull(reader("last_name")), reader("last_name").ToString(), "")
            Dim firstName As String = If(Not IsDBNull(reader("first_name")), reader("first_name").ToString(), "")
            Dim middleName As String = If(Not IsDBNull(reader("middle_name")), reader("middle_name").ToString(), "")

            ' Check for null before attempting to convert to Date
            Dim dob As String = If(Not IsDBNull(reader("dob")), CType(reader("dob"), Date).ToString("yyyy-MM-dd"), "")

            ' Concatenate last name, first name, and middle name into one column
            Dim fullName As String = $"{lastName} {firstName} {middleName}"

            ' Add the concatenated name and other fields to the DataGridView
            employee_grid_view.Rows.Add(reader("employee_id"), fullName, reader("email"), reader("gender"), dob, reader("department_name"), "Delete Update")
        End While

        reader.Close()
        Listgender()
        ListDepartment()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles branch_btn.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles department_btn.Click
        DataGridView7.Rows.Clear()
        TabControl1.SelectedTab = TabPage4

        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department")

        ' Create a while loop to fetch all data from the database'
        While reader.Read
            DataGridView7.Rows.Add(reader("department_id"), reader("department_name"), reader("department_desc"))
        End While

        reader.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles printreport_btn.Click
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles sanbartolome_branch_btn.Click
        Label10.Text = "San. Bartolome"
        TabControl2.SelectedTab = TabPage6
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles batasan_branch_btn.Click
        Label10.Text = "Batasan"
        TabControl2.SelectedTab = TabPage7
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles sanfrancisco_branch_btn.Click
        Label10.Text = "San. Francisco"
        TabControl2.SelectedTab = TabPage8
    End Sub

    Public Sub ListDepartment()
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department")
        e_dep.Items.Clear()
        While reader.Read
            e_dep.Items.Add(reader("department_name"))
        End While
        e_dep.SelectedIndex = 0
        reader.Close()
    End Sub

    Public Sub Listgender()
        e_gender.Items.Clear()
        e_gender.Items.Add("Please Choose Gender")
        e_gender.Items.Add("Male")
        e_gender.Items.Add("Female")
        e_gender.Items.Add("Other")
        e_gender.SelectedIndex = 0
    End Sub

    Private Sub Admindashboardform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateHomeGrids()
        UpdateCounters()
    End Sub

    Private Sub UpdateCounters()
        UpdateCount("qcu_department", dept_num)
        UpdateCount("qcu_branches", branch_num)
        UpdateCount("employee_info", employee_num)
    End Sub

    Private Sub UpdateCount(table As String, label_num As Label)
        Dim Reader As MySqlDataReader = SelectQuery("count(*) as a", table)
        While Reader.Read
            Reader.Read()
            label_num.Text = Reader("a")
        End While
    End Sub

    Private Sub UpdateHomeGrids()
        Dim reader As MySqlDataReader = SelectQuery("department_name, department_desc", "qcu_department")
        While reader.Read
            department_grid_view.Rows.Add(reader("department_name"), reader("department_desc"))
        End While
        reader = SelectQuery("branch_name, branch_address", "qcu_branches")
        While reader.Read
            branch_grid_view.Rows.Add(reader("branch_name"), reader("branch_address"))
        End While
    End Sub
End Class

'



