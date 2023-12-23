Public Class BranchSelect
    Private Sub select_branch_tb_KeyUp(sender As Object, e As KeyEventArgs) Handles select_branch_tb.KeyUp
        If e.KeyValue <> Keys.Enter Then Return

        If Not select_branch_tb.AutoCompleteCustomSource.Contains(select_branch_tb.Text) Then
            MessageBox.Show("invalid branch!!", "SELECT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Mainform.BRANCH = select_branch_tb.Text
        Mainform.Show()
        staffadminbtns.Hide()
        Me.Close()
    End Sub

    Private Sub BranchSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim reader = SelectQuery("branch_name", "qcu_branches")

        While reader.Read
            select_branch_tb.AutoCompleteCustomSource.Add(reader("branch_name"))
        End While
    End Sub

    Private Sub BranchSelect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If staffadminbtns.IsDisposed Then Return
        staffadminbtns.Enabled = True
    End Sub
End Class