Public Class staffadminbtns
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub staff_btn_Click(sender As Object, e As EventArgs) Handles staff_btn.Click

        Me.Hide()
        mainform.Show()

    End Sub

    Private Sub admin_btn_Click(sender As Object, e As EventArgs) Handles admin_btn.Click

        Me.Hide()
        loginform.Show()

    End Sub

End Class