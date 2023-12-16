Imports MySql.Data.MySqlClient
Imports WinFormsApp2.Erenjhun.Utils

Public Class admindashboardform


    Friend facerecog As FaceRecognition = New FaceRecognition({
                                        New AddEmpformStates.FindingState(),
                                        New AddEmpformStates.UnrecognizedFaceFoundState(),
                                        New AddEmpformStates.RecognizedFaceFoundState(),
                                        New FoundState(),
                                        New UnlockingState()
                                        }, addEmployee, addEmployee.cam_pic_box)


    Private Sub dashboard_btn_(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        TabControl1.SelectedTab = TabPage1
        UpdateStats()
    End Sub

    Private Sub updbranchstat(id As Integer)
        total_stat.Counter = selectScalarQuery("count(employee_id)", "employee_schedule", {id}, "emp_branc_id = @branch_id")

        'absent_stat.Counter = selectScalarQuery("count(employee_id))
        'leave_stat.Counter = 
    End Sub
    Private Sub UpdateStats()
        main_total_stat.Counter = selectScalarQuery("total", "total_emp")
        main_leave_stat.Counter = selectScalarQuery("count(employee_id)", "late_emp")
        main_present_stat.Counter = selectScalarQuery("Present", "branch_emp_present")

    End Sub


    Private Sub employee_btn_(sender As Object, e As EventArgs) Handles employee_btn.Click
        TabControl1.SelectedTab = TabPage2
        updateEmpployeeGrid()
    End Sub

    Public sub updateEmpployeeGrid()
        employee_grid_view.Rows.Clear()

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

            ' Create a DataGridViewButtonCell for the "Delete" and "Update" actions

            ' Add the concatenated name and other fields to the DataGridView along with the button cell
            employee_grid_view.Rows.Add(reader("employee_id"), fullName, reader("email"), reader("gender"), dob, reader("department_name"), "Modify")
        End While

        reader.Close()

    End sub
    Private Sub employee_grid_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles employee_grid_view.CellContentClick
        ' Check if the clicked cell is in the "Actions" column (assuming it's the last column in your DataGridView)
        If e.ColumnIndex = employee_grid_view.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            ' Get the employee_id regardless of the button type
            Dim employeeCode As String = employee_grid_view.Rows(e.RowIndex).Cells("id_col").Value
            Dim name As String = employee_grid_view.Rows(e.RowIndex).Cells("name_col").Value
            Dim depname As String = employee_grid_view.Rows(e.RowIndex).Cells("hired_col").Value

            Dim chooseChangeEmployeeForm As New ChooseChangeEmployee(employeeCode, name, depname)
            Me.Enabled = False
            chooseChangeEmployeeForm.Show()
        End If
    End Sub

    Private Sub LoadData()
        Try
            DataGridView1.DataSource = Nothing

            Dim startDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
            Dim endDate As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

            Dim cmd As MySqlCommand = NewQuery($"SELECT employee_id AS 'Employee ID', employee_Name AS 'Employee Name', workday AS 'Workday', att_date AS 'Attendance Date', attendance_time AS 'Attendance Time', departure_time AS 'Departure Time', overtime_in AS 'Overtime In', overtime_out AS 'Overtime Out', schedule_start_time AS 'Time IN', schedule_end_time AS 'Time OUT', minutes_late AS 'Minutes Late', minutes_early_departure AS 'Minutes Early Departure' FROM emp_report WHERE att_date BETWEEN '{startDate}' AND '{endDate}'", Nothing)

            Using adapter As New MySqlDataAdapter(cmd)
                Using dataSet As New DataSet()
                    adapter.Fill(dataSet, "emp_report")

                    DataGridView1.DataSource = dataSet.Tables("emp_report")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoadData()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoadData()
    End Sub


    Private Sub branch_btn_(sender As Object, e As EventArgs) Handles branch_btn.Click
        TabControl1.SelectedTab = TabPage3
    End Sub



    Private Sub dept_gridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dept_gridview.CellContentClick
        ' Check if the clicked cell is in the "Actions" column (assuming it's the last column in your DataGridView)
        If e.ColumnIndex = dept_gridview.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            ' Get the employee_id regardless of the button type
            Dim dep_name As String = dept_gridview.Rows(e.RowIndex).Cells("dep_col").Value
            Dim dep_id As String = dept_gridview.Rows(e.RowIndex).Cells("Id").Value

            Dim modifyDepartmentForm As New modify_DepartmentForm(dep_name, dep_id)
            modifyDepartmentForm.Show()
        End If
    End Sub
    Sub UpdateDeptGridView(Optional vals As String() = Nothing, Optional where As String = Nothing)


        dept_gridview.Rows.Clear()
        TabControl1.SelectedTab = TabPage4
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department", vals, where)
        ' Create a while loop to fetch all data from the database'
        While reader.Read
            dept_gridview.Rows.Add(reader("department_id"), reader("department_name"), reader("department_desc"), " Modify ")
        End While

        reader.Close()
    End Sub

    Private Sub id_dept_tb_TextChanged(sender As Object, e As EventArgs)
        UpdateDeptGridView({$"{id_dept_tb.Text}%"}, " department_name LIKE @department_name ")
        If (dept_gridview.RowCount < 1) Then UpdateDeptGridView()
    End Sub


    Sub UpdateDeptGridView2()
        dept_gridview.Rows.Clear()
        TabControl1.SelectedTab = TabPage4
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department", {"2"}, "department_id >= @username")
        ' Create a while loop to fetch all data from the database'
        While reader.Read
            dept_gridview.Rows.Add(reader("department_id"), reader("department_name"), reader("department_desc"), " Modify ")
        End While
        reader.Close()
    End Sub
    Private Sub department_btn_Click(sender As Object, e As EventArgs) Handles department_btn.Click
        UpdateDeptGridView2()
    End Sub


    Private Sub printreport_btn_(sender As Object, e As EventArgs) Handles printreport_btn.Click
        TabControl1.SelectedTab = TabPage5
    End Sub



    Private Sub Admindashboardform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dashboard_btn.PerformClick()


        facerecog.Init()
        facerecog.Create_tracker()

        loginform.timerCallAbsent()
        LoadData()


    End Sub


    Private Sub UpdateCount(table As String, label_num As Label)
        Dim Reader As MySqlDataReader = SelectQuery("count(*) as a", table)
        While Reader.Read
            Reader.Read()
            label_num.Text = Reader("a")
        End While
    End Sub



    Private Sub add_employees_btn_Click(sender As Object, e As EventArgs) Handles add_employees_btn.Click
        addEmployee.Show()
    End Sub




    Private Sub add_dept_btn_Click(sender As Object, e As EventArgs) Handles add_dept_btn.Click
        addDepartment.Show()
    End Sub



    Private Sub search_btn_dept_Click(sender As Object, e As EventArgs) Handles search_btn_dept.Click


        Dim read As MySqlDataReader = SelectQuery("*", "")

    End Sub

    Private Sub sanbartolome_branch_btn_Click(sender As Object, e As EventArgs) Handles sanbartolome_branch_btn.Click
        updbranchstat(3)
        present_stat.Counter = selectScalarQuery("total", "San_bartolome_present")
    End Sub

    Private Sub batasan_branch_btn_Click(sender As Object, e As EventArgs) Handles batasan_branch_btn.Click
        updbranchstat(2)
        present_stat.Counter = selectScalarQuery("total", "Batasan_present")

    End Sub

    Private Sub sanfrancisco_branch_btn_Click(sender As Object, e As EventArgs) Handles sanfrancisco_branch_btn.Click
        updbranchstat(1)
        present_stat.Counter = selectScalarQuery("total", "san_francisco_present")

    End Sub
End Class

'



