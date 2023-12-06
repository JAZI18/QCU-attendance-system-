Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1
Imports Org.BouncyCastle.Utilities

Public Class Update_department


    Private _depname As String
    Private _depId As String


    ' Modify the constructor to accept employeeCode as a parameter
    Public Sub New(depname As String, depID As String)
        InitializeComponent()

        _depname = depname
        _depId = depID
    End Sub

    Private Sub e_firstname_TextChanged(sender As Object, e As EventArgs) Handles dep_name.TextChanged

    End Sub

    Private Sub sub_btn_Click(sender As Object, e As EventArgs) Handles sub_btn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Update this Department?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            UpdateQuery("qcu_department", "department_name,department_desc", {dep_name.Text, dep_desc.Text}, "department_id=" & _depId)

            MsgBox("Recorded Updated")
            Me.Close()

            admindashboardform.UpdateDeptGridView2()
        Else
            MessageBox.Show("Updating canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub Update_department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department", {_depId}, "department_id = @department_id")

        If reader.Read Then
            dep_name.Text = reader("department_name")

            dep_desc.Text = reader("department_desc")

        End If
    End Sub
End Class