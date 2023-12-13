Imports Luxand

Public Class FoundState
    Inherits State

    Public Overrides Sub Enter()
        form.Stop_timer("unlocking face")
        'check if face is recognized or not
        If Not IsRecognized() Then
            ChangeState("UnrecognizedFaceFoundState")
        Else
            ChangeState("RecognizedFaceFoundState")
        End If
    End Sub

    Private Function IsRecognized() As Boolean
        Dim image_tag_name As String = ""
        Dim res As Integer = FSDK.GetAllNames(form.tracker, face_id, image_tag_name, 100) ' maximum of 100 characters
        Return image_tag_name.Length > 0
    End Function

End Class
