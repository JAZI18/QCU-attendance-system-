Public Class FindingStateMain
    Inherits FindingState
    Public Overrides Sub enter()
        form.pic_border.BackColor = Color.Blue
        form.Refresh_fields()
        Curr_emp_id = face_id
    End Sub
End Class
