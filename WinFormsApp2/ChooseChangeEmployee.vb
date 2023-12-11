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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


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
            Me.Close()

        Else
            ' User canceled deletion
            MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ChooseChangeEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = _name

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim employee As Update_Employee = New Update_Employee(_employeeCode, _name, _depname)

        employee.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        admindashboardform.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim addAdmin As adminAdd = New adminAdd(_employeeCode)
        addAdmin.Show()
    End Sub
    Private Sub ChooseChangeEmployee_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the close button was clicked
        If e.CloseReason = CloseReason.UserClosing Then
            admindashboardform.Enabled = True
        End If
    End Sub
End Class