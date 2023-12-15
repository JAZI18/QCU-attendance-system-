
Public Class RecognizedFaceFoundMain
    Inherits RecognizedFaceFoundState

    Public Overrides Sub Enter()


        If Face_name(Curr_emp_id) = Face_name() Then Exit Sub 'if face detected is the same as last then skip

        'if new recognized face is detected
        Curr_emp_id = face_id
        form.pic_border.BackColor = Color.LightGreen
        form.Face_detected(Face_name())
    End Sub
End Class
