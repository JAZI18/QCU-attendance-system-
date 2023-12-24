Public Class ChooseChangeEmployee

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles del_btn.Click
        DeleteEmployee(_employeeCode)
    End Sub



    Private Sub DeleteEmployee(employeeCode As String)
        ' Ask for confirmation before deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User confirmed, proceed with deletion
            DeleteQuery("admin_account", "employee_info=@id", {employeeCode})
            DeleteQuery("employee_schedule", "employee_id=@id", {employeeCode})
            DeleteQuery("emp_attendance", "employee_id=@id", {employeeCode})
            DeleteQuery("employee_info", "employee_id=@id", {employeeCode})
            admindashboardform.updateEmpployeeGrid()
            MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            admindashboardform.Enabled = True
            admindashboardform.Focus()
            Me.Close()
        Else
            ' User canceled deletion
            MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ChooseChangeEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = _name
    End Sub

    Private Sub Update_tbn_Click(sender As Object, e As EventArgs) Handles update_tbn.Click
        Dim employee As New Update_Employee(_employeeCode, _name, _depname)
        employee.Show()
        Close()
    End Sub

    Private Sub Cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        admindashboardform.Enabled = True
        Me.Close()
    End Sub

    Private Sub Set_as_admin_btn_Click(sender As Object, e As EventArgs) Handles set_as_admin_btn.Click
        Dim addAdmin As New adminAdd(_employeeCode)
        addAdmin.Show()
        admindashboardform.Enabled = True
    End Sub
    Private Sub ChooseChangeEmployee_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the close button was clicked
        If e.CloseReason = CloseReason.UserClosing Then
            admindashboardform.Enabled = True
        End If
    End Sub

    Private Sub Addsched_btn_Click(sender As Object, e As EventArgs) Handles addsched_btn.Click
        Dim addSchedule As New addSchedule(_employeeCode, _name)
        addSchedule.Show()
        Me.Close()
    End Sub
End Class