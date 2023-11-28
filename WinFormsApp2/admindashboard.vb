Imports MySql.Data.MySqlClient

Public Class admindashboardform

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles employee_btn.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles branch_btn.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles department_btn.Click
        TabControl1.SelectedTab = TabPage4
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

    Private Sub admindashboardform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD
        Dim reader As MySqlDataReader = selectQuery("department_name, department_desc", "qcu_department")
        While reader.Read
            department_grid_view.Rows.Add(reader("department_name"), reader("department_desc"))

        End While

        reader = selectQuery("branch_name, branch_address", "qcu_branches")
        While reader.Read
            branch_grid_view.Rows.Add(reader("branch_name"), reader("branch_address"))

        End While

        Dim cmd As MySqlCommand = newQuery("select count(department_name) as branch from qcu_department")

        reader = cmd.ExecuteReader

        dept_num.Text = reader("branch")


    End Sub


=======

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        loginform.Show()
        Me.Close()
    End Sub
>>>>>>> b4a30c14e513619d0dc2a3ddbbeac68ac43ba75d
End Class