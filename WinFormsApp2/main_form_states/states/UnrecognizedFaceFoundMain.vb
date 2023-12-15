Public Class UnrecognizedFaceFoundMain
    Inherits UnrecognizedFaceFoundState
    Public Overrides Sub Enter()


        If Manager.prev_state.before.key = "unrecognizedFaceFound" Then Exit Sub

        form.pic_border.BackColor = Color.Red
        Curr_emp_id = face_id
        form.Refresh_fields()
    End Sub
End Class