Public Class FinderState
    Inherits State
    'states that needs to check if there is face found

    Public Overrides Sub Run()
        If (FindFace(face_id)) Then ChangeState("FoundState")
    End Sub

    Protected Function FindFace(id As Integer) As Boolean
        Return id <> 0
    End Function

End Class
