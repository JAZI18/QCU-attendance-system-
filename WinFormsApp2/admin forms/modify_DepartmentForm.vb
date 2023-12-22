Public Class modify_DepartmentForm


    Private _depname As String
    Private _depId As String


    ' Modify the constructor to accept employeeCode as a parameter
    Public Sub New(depname As String, depID As String)
        InitializeComponent()

        _depname = depname
        _depId = depID
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub modify_DepartmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = _depname
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeleteDepartment(_depname)
    End Sub
    Sub deleteDepartment(depname As String)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this Department?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User confirmed, proceed with deletion
            UpdateQuery("employee_info", "department_id", {1}, "department_id=" & _depId)
            DeleteQuery("qcu_department", "department_id=@id", {_depId})


            admindashboardform.UpdateDeptGridView()
            MessageBox.Show("Department Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Me.Close()
        Else
            ' User canceled deletion
            MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dep As Update_department = New Update_department(_depname, _depId)
        dep.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class