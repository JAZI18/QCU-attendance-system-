Imports Luxand

Public Class RecognizedFaceFoundState
    Inherits FaceFound


    Public Sub New()
        key = "recognizedFaceFound"
    End Sub

    Public Overrides Sub Run()
        If (FindFace(face_id)) Then
            ChangeState("found")
            Exit Sub
        End If
        ChangeState("unlocking")
    End Sub
End Class
