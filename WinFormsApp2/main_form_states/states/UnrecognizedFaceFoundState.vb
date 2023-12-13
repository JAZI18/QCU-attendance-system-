Public Class UnrecognizedFaceFoundState
    Inherits FinderState
    Public Overrides Sub Enter()


        If Manager.prev_state.before.key = "UnrecognizedFaceFoundState" Then Exit Sub

        form.pic_border.BackColor = Color.Red
        Curr_emp_id = face_id
        form.Refresh_fields()
    End Sub

    Public Overrides Sub Run()
        If (FindFace(face_id)) Then
            ChangeState("FoundState")
            Exit Sub
        End If
        ChangeState("FindingState")
    End Sub

End Class