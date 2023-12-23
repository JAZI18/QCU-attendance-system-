
Imports WinFormsApp2.Erenjhun.Utils

Namespace MainformStates

    Class RecognizedFaceFoundState
        Inherits Erenjhun.Utils.RecognizedFaceFoundState
        Public Overrides Sub Enter()

            If Face_name(curr_face_id) = Face_name() Then Exit Sub 'if face detected is the same as last then skip
            'if new recognized face is detected
            Dim mainform As Mainform = Form
            curr_face_id = face_id
            mainform.pic_border.BackColor = Color.LightGreen
            mainform.Face_detected(Face_name())
        End Sub



    End Class

    Class FindingState
        Inherits Erenjhun.Utils.FindingState
        Public Overrides Sub enter()

            If manager.prev_state.before.key = key Then Exit Sub

            Dim mainform As Mainform = Form
            mainform.pic_border.BackColor = Color.Blue
            mainform.Refresh_fields()
            curr_face_id = face_id
        End Sub
    End Class


    Class UnrecognizedFaceFoundState
        Inherits Erenjhun.Utils.UnrecognizedFaceFoundState
        Public Overrides Sub Enter()

            If manager.prev_state.before.key = key Then Exit Sub
            Dim mainform As Mainform = Form
            mainform.pic_border.BackColor = Color.Red
            curr_face_id = face_id
            mainform.Refresh_fields()
        End Sub
    End Class
End Namespace
