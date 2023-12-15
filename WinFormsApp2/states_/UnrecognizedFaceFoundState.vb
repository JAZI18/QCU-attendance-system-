Public Class UnrecognizedFaceFoundState
    Inherits FinderState

    Public Sub New()
        key = "unrecognizedFaceFound"
    End Sub

    Public Overrides Sub Run()
        If (FindFace(face_id)) Then
            ChangeState("found")
            Exit Sub
        End If
        ChangeState("finding")
    End Sub

End Class