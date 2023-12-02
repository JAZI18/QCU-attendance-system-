Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities

Public Class admindashboardform

    Private Sub dashboard_btn_(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        TabControl1.SelectedTab = TabPage1
    End Sub



    Private Sub employee_btn_(sender As Object, e As EventArgs) Handles employee_btn.Click
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
            Dim dob As String = If(Not IsDBNull(reader("dob")), CType(reader("dob"), Date).ToString("yy-MM-dd"), "")

            ' Concatenate last name, first name, and middle name into one column
            Dim fullName As String = $"{lastName} {firstName} {middleName}"

            ' Add the concatenated name and other fields to the DataGridView
            employee_grid_view.Rows.Add(reader("employee_id"), fullName, reader("email"), reader("gender"), dob, reader("department_name"), "Delete Update")
        End While

        reader.Close()

    End Sub



    Private Sub branch_btn_(sender As Object, e As EventArgs) Handles branch_btn.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub department_btn_(sender As Object, e As EventArgs) Handles department_btn.Click
        UpdateDeptGridView()
    End Sub

    Sub UpdateDeptGridView(Optional vals As String() = Nothing, Optional where As String = Nothing)
        dept_gridview.Rows.Clear()
        TabControl1.SelectedTab = TabPage4

        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department", vals, where)

        ' Create a while loop to fetch all data from the database'
        While reader.Read
            dept_gridview.Rows.Add(reader("department_name"), reader("department_desc"))
        End While

        reader.Close()
    End Sub


    Private Sub printreport_btn_(sender As Object, e As EventArgs) Handles printreport_btn.Click
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub sanbartolome_branch_btn_(sender As Object, e As EventArgs) Handles sanbartolome_branch_btn.Click
    End Sub

    Private Sub batasan_branch_btn_(sender As Object, e As EventArgs) Handles batasan_branch_btn.Click
    End Sub

    Private Sub sanfrancisco_branch_btn_(sender As Object, e As EventArgs) Handles sanfrancisco_branch_btn.Click
    End Sub

    Private Sub Admindashboardform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateHomeGrids()
    End Sub



    Private Sub UpdateCount(table As String, label_num As Label)
        Dim Reader As MySqlDataReader = SelectQuery("count(*) as a", table)
        While Reader.Read
            Reader.Read()
            label_num.Text = Reader("a")
        End While
    End Sub

    Private Sub UpdateHomeGrids()
        'Dim reader As MySqlDataReader = SelectQuery("department_name, department_desc", "qcu_department")
        'While reader.Read
        '    department_grid_view.Rows.Add(reader("department_name"), reader("department_desc"))
        'End While
        'reader = SelectQuery("branch_name, branch_address", "qcu_branches")
        'While reader.Read
        '    branch_grid_view.Rows.Add(reader("branch_name"), reader("branch_address"))
        'End While
    End Sub

    Private Sub add_employees_btn_Click(sender As Object, e As EventArgs) Handles add_employees_btn.Click
        addEmployee.Show()
    End Sub

    Private Sub id_dept_tb_TextChanged(sender As Object, e As EventArgs)

        UpdateDeptGridView({$"{id_dept_tb.Text}%"}, " department_name LIKE @department_name ")
        If (dept_gridview.RowCount < 1) Then UpdateDeptGridView()

    End Sub

    Private Sub Update_btn_dept_Click(sender As Object, e As EventArgs) Handles Update_btn_dept.Click
        Update_department.Show()
    End Sub
End Class

'



