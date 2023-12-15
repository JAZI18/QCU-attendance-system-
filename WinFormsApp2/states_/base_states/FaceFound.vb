Imports Luxand

Public Class FaceFound
    Inherits FinderState

    Protected Function Face_name(Optional id As Integer = -1000)
        id = If(id = -1000, face_id, id)
        Dim image_tag_name As String = ""
        Dim res As Integer = FSDK.GetAllNames(form.tracker, id, image_tag_name, 100) ' maximum of 100 characters
        Return image_tag_name
    End Function
End Class
