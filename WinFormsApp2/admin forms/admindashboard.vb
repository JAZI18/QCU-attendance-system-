Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports WinFormsApp2.Erenjhun.Utils

Public Class admindashboardform

    Private brach_last_s_btn As Button



    Private WithEvents printDocument As New Printing.PrintDocument
    Private rowIndex As Integer = 0

    Private Sub updbranchstat(id As Integer)
        total_stat.Counter = selectScalarQuery("count(distinct employee_id)", "employee_schedule", {id}, "emp_branc_id = @branch_id and workday = dayname(curdate()) ")
        absent_stat.Counter = selectScalarQuery("count(employee_id)", "absent_emp", {id}, "emp_branc_id = @branch_id and workday = dayname(curdate())")
        leave_stat.Counter = selectScalarQuery("count(employee_id)", "emp_leave", {id}, "branch_id = @branch_id and dayname(leave_date) = dayname(curdate())")
        present_stat.Counter = selectScalarQuery("count(employee_id)", "present_emp", {id}, "emp_branc_id = @branch_id and att_date = curdate()")
    End Sub
    Private Sub UpdateStats()
        main_total_stat.Counter = selectScalarQuery("count(distinct employee_id)", "employee_schedule", {}, "workday = dayname(curdate())")
        main_leave_stat.Counter = selectScalarQuery("count(distinct employee_id)", "emp_leave", {}, "dayname(leave_date) = dayname(curdate())")
        main_present_stat.Counter = selectScalarQuery("count(distinct employee_id)", "present_emp", {}, "att_date = curdate()")
        main_absent_stat.Counter = selectScalarQuery("count(distinct employee_id)", "absent_emp", {}, "workday = dayname(curdate())")
    End Sub


#Region "tab clicks"

    Private Sub dashboard_btn_(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        Change_tab(dashboard_tab)
        UpdateStats()
    End Sub

    Private Sub employee_btn_click(sender As Object, e As EventArgs) Handles employee_btn.Click
        Change_tab(employees_tab)
        updateEmpployeeGrid()
    End Sub

    Private Sub branch_btn_(sender As Object, e As EventArgs) Handles branch_btn.Click
        Change_tab(brach_tab)

        Select_branch(brach_last_s_btn)
        brach_last_s_btn.PerformClick()
    End Sub

    Private Sub department_btn_Click(sender As Object, e As EventArgs) Handles department_btn.Click
        Change_tab(dept_tab)
        UpdateDeptGridView()
    End Sub
    Private Sub printreport_btn_(sender As Object, e As EventArgs) Handles printreport_btn.Click
        Change_tab(report_tab)
        LoadReportData()
    End Sub


    Private Sub leave_btn_Click(sender As Object, e As EventArgs) Handles leave_btn.Click
        Change_tab(leave_tab)
        LoadLeaveData()
    End Sub




#End Region
    Dim leave_locked = False

    Private Sub LoadLeaveData()

        If leave_locked Then Return

        Try
            Dim startDate As String = leave_start_date.Value.ToString("yyyy-MM-dd")
            Dim endDate As String = leave_end_date.Value.ToString("yyyy-MM-dd")

            Dim selectedBranch As String = leave_branch_cb.SelectedItem

            Dim cmd As MySqlCommand


            If selectedBranch IsNot Nothing Then
                cmd = NewQuery("SELECT * FROM emp_leave_view having  branch = @branchName and Date BETWEEN @sd AND @ed", {selectedBranch, startDate, endDate})
            Else
                cmd = NewQuery("SELECT * FROM emp_leave_view having Date BETWEEN @sd AND @ed", {startDate, endDate})
            End If

            'MsgBox($"branch {selectedBranch} ")
            'MsgBox(cmd.CommandText)

            Enabled = False
            FillDatagrid(leave_datagrid, cmd)
            Enabled = True


        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Dim report_locked = False
    Private Sub LoadReportData()

        If report_locked Then Return

        Try


            Dim startDate As String = report_start_date.Value.ToString("yyyy-MM-dd")
            Dim endDate As String = report_end_date.Value.ToString("yyyy-MM-dd")

            Dim selectedBranch As String = report_brach_cb.SelectedItem
            Dim cmd As MySqlCommand




            If selectedBranch IsNot Nothing Then
                cmd = NewQuery("SELECT * FROM emp_report having Date BETWEEN @sd AND @ed AND branch = @br", {startDate, endDate, selectedBranch})
            Else
                cmd = NewQuery("SELECT * FROM emp_report having Date BETWEEN @sd AND @ed ", {startDate, endDate})
            End If

            'MsgBox($"branch {selectedBranch} {startDate}  {endDate}")
            'MsgBox(cmd.CommandText)


            Enabled = False
            FillDatagrid(report_grid_view, cmd)
            Enabled = True

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub id_employees_tb_TextChanged(sender As Object, e As EventArgs) Handles id_employees_tb.TextChanged
        updateEmpployeeGrid()
    End Sub

    Public Sub updateEmpployeeGrid()
        employee_grid_view.Rows.Clear()

        Dim command As MySqlCommand =
            NewQuery("SELECT e.employee_id, e.first_name, e.last_name, e.middle_name, e.department_id, e.gender, e.email, e.dob, d.department_name FROM employee_info e JOIN qcu_department d ON e.department_id = d.department_id Where employee_code LIKE  '%" & id_employees_tb.Text & "%' OR first_name LIKE  '%" & id_employees_tb.Text & "%' OR middle_name LIKE  '%" & id_employees_tb.Text & "%' OR last_name LIKE  '%" & id_employees_tb.Text & "%' OR email LIKE  '%" & id_employees_tb.Text & "%' OR gender LIKE  '%" & id_employees_tb.Text & "%' OR dob LIKE  '%" & id_employees_tb.Text & "%' OR department_name LIKE  '%" & id_employees_tb.Text & "%'", Nothing)

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

    End Sub

    Private Sub employee_grid_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles employee_grid_view.CellContentClick
        ' Check if the clicked cell is in the "Actions" column (assuming it's the last column in your DataGridView)
        If e.ColumnIndex = employee_grid_view.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            ' Get the employee_id regardless of the button type
            Dim empid As String = employee_grid_view.Rows(e.RowIndex).Cells("id_col").Value
            Dim name As String = employee_grid_view.Rows(e.RowIndex).Cells("name_col").Value
            Dim depname As String = employee_grid_view.Rows(e.RowIndex).Cells("hired_col").Value

            Dim chooseChangeEmployeeForm As New ChooseChangeEmployee(empid, name, depname)
            Me.Enabled = False
            chooseChangeEmployeeForm.Show()
        End If
    End Sub


    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles report_start_date.ValueChanged, report_end_date.ValueChanged, report_brach_cb.SelectedIndexChanged
        LoadReportData()
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

    Private Sub Admindashboardform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        brach_last_s_btn = sanbartolome_branch_btn
        dashboard_btn.PerformClick()



        loginform.timerCallAbsent()


        Dim reader = SelectQuery("branch_name", "qcu_branches")

        While reader.Read
            report_brach_cb.Items.Add(reader("branch_name"))
            leave_branch_cb.Items.Add(reader("branch_name"))
        End While
    End Sub



    Private Sub add_employees_btn_Click(sender As Object, e As EventArgs) Handles add_employees_btn.Click
        addEmployee.Show()
        Enabled = False
    End Sub




    Private Sub add_dept_btn_Click(sender As Object, e As EventArgs) Handles add_dept_btn.Click
        addDepartment.Show()
    End Sub



    Private Sub id_dept_tb_TextChanged(sender As Object, e As EventArgs) Handles id_dept_tb.TextChanged
        ' Call the method to update the DataGridView based on the search term
        UpdateDeptGridView()
    End Sub


    Sub UpdateDeptGridView()
        dept_gridview.Rows.Clear()
        Dim command As MySqlCommand = NewQuery("SELECT *  FROM qcu_department WHERE department_id >= 2 AND (department_name LIKE '%" & id_dept_tb.Text & "%' OR department_desc LIKE '%" & id_dept_tb.Text & "%')", Nothing)
        Dim reader As MySqlDataReader = command.ExecuteReader()

        ' Create a while loop to fetch all data from the database'
        While reader.Read
            dept_gridview.Rows.Add(reader("department_id"), reader("department_name"), reader("department_desc"), " Modify ")
        End While
        con.Close()
        reader.Close()
    End Sub


#Region "branch btn onclick"

    Private Sub Sanbartolome_branch_btn_Click(sender As Object, e As EventArgs) Handles sanbartolome_branch_btn.Click
        updbranchstat(3)
        Select_branch(sanbartolome_branch_btn)
    End Sub

    Private Sub Batasan_branch_btn_Click(sender As Object, e As EventArgs) Handles batasan_branch_btn.Click
        updbranchstat(2)
        Select_branch(batasan_branch_btn)

    End Sub

    Private Sub Sanfrancisco_branch_btn_Click(sender As Object, e As EventArgs) Handles sanfrancisco_branch_btn.Click
        updbranchstat(1)
        Select_branch(sanfrancisco_branch_btn)
    End Sub

    Private Sub Select_branch(branch_btn As Button)
        brach_last_s_btn.BackColor = Color.White
        brach_last_s_btn = branch_btn
        brach_last_s_btn.BackColor = Color.Silver
    End Sub

#End Region

    Private Sub report_print_btn_click(sender As Object, e As EventArgs) Handles report_print_btn.Click
        rowIndex = 0 ' Reset rowIndex before printing
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ExportToPDF(report_grid_view, "Report.pdf")
    End Sub

    Private Sub ExportToPDF(dataGridView As DataGridView, filename As String)
        Dim document As New Document()
        Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(filename, FileMode.Create))
        document.Open()

        ' Create a table with the same number of columns as the DataGridView
        Dim pdfTable As New PdfPTable(dataGridView.Columns.Count)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT

        ' Add column headers from the DataGridView to the PDF table
        For Each column As DataGridViewColumn In dataGridView.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            pdfTable.AddCell(cell)
        Next

        ' Add data rows from the DataGridView to the PDF table
        For Each row As DataGridViewRow In dataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                pdfTable.AddCell(cell.Value.ToString())
            Next
        Next

        ' Add the PDF table to the document
        document.Add(pdfTable)
        document.Close()

        MessageBox.Show("PDF exported successfully!")
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles Button4.Click

        report_locked = True
        report_brach_cb.SelectedItem = Nothing
        report_start_date.Value = New Date(Now.Year, 1, 1)
        report_end_date.Value = Now
        report_locked = False

        LoadReportData()
    End Sub

    Private Sub leave_reset_Click(sender As Object, e As EventArgs) Handles leave_reset_btn.Click
        leave_locked = True
        leave_start_date.Value = New Date(Now.Year, 1, 1)
        leave_end_date.Value = Now
        leave_branch_cb.SelectedItem = Nothing
        leave_locked = False
        LoadLeaveData()
    End Sub



    Private Sub v_absent_Click_1(sender As Object, e As EventArgs) Handles v_absent.Click
        viewAbsent.Show()
    End Sub


    Private Sub Change_tab(page As TabPage)
        TabControl1.SelectedTab = page
    End Sub

    Private Sub Add_leave_btn_Click(sender As Object, e As EventArgs) Handles add_leave_btn.Click
        addLeave.Show()
    End Sub

    Private Sub Leave_start_date_ValueChanged(sender As Object, e As EventArgs) Handles leave_start_date.ValueChanged,
            leave_end_date.ValueChanged, leave_branch_cb.SelectedValueChanged
        LoadLeaveData()
    End Sub

    Private Sub admindashboardform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        staffadminbtns.Show()
    End Sub
End Class

'



