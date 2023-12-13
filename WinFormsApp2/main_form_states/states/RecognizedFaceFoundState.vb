Imports Luxand

Public Class RecognizedFaceFoundState
    Inherits FaceFound

    Public Overrides Sub Enter()


        If Face_name(Curr_emp_id) = Face_name() Then Exit Sub 'if face detected is the same as last then skip

        'if new recognized face is detected
        Curr_emp_id = face_id
        form.pic_border.BackColor = Color.LightGreen
        form.Face_detected(Face_name())
    End Sub



    Public Overrides Sub Run()
        If (FindFace(face_id)) Then
            ChangeState("FoundState")
            Exit Sub
        End If
        ChangeState("UnlockingState")
    End Sub

End Class
