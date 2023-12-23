Imports Luxand
Namespace Erenjhun.Utils

    Public MustInherit Class State

        Friend ReadOnly key As String
        Friend manager As StateManager
        Friend face_id As Integer = -10
        Friend before As State



        Public ReadOnly Property Facerecog As FaceRecognition
            Get
                Return manager.parent
            End Get
        End Property

        Public ReadOnly Property Form As Object
            Get
                Return Facerecog.form
            End Get
        End Property

        Friend Property curr_face_id As Integer
            Get
                Return manager.parent.curr_face_id
            End Get

            Set(value As Integer)
                manager.parent.curr_face_id = value
            End Set
        End Property



        Public Sub New()
            key = Me.GetType.Name
        End Sub


        Public Sub ChangeState(key As String)
            manager.SetState(key)
        End Sub

        Public Overridable Sub Enter()
        End Sub

        Public Overridable Sub Run()
        End Sub
    End Class

    Class startState
        Inherits State
    End Class

    Class RecognizedFaceFoundState
        Inherits FaceFound
        Public Overrides Sub Run()
            If (FindFace(face_id)) Then
                ChangeState("FoundState")
                Exit Sub
            End If
            ChangeState("UnlockingState")
        End Sub
    End Class

    Class FoundState
        Inherits State
        Public Overrides Sub Enter()
            Stop_timer("unlocking face")
            'check if face is recognized or not
            If Not IsRecognized() Then
                ChangeState("UnrecognizedFaceFoundState")
            Else
                ChangeState("RecognizedFaceFoundState")
            End If
        End Sub

        Protected Function IsRecognized() As Boolean
            Dim image_tag_name As String = ""
            Dim res As Integer = FSDK.GetAllNames(Facerecog.tracker, face_id, image_tag_name, 100) ' maximum of 100 characters
            Return image_tag_name.Length > 0
        End Function
    End Class

    Class FindingState
        Inherits FinderState
    End Class
    Class UnlockingState
        Inherits FinderState
        Public Overrides Sub Enter()
            Start_timer(Sub()
                            ChangeState("FindingState")
                        End Sub, "unlocking face", 700)
        End Sub
    End Class

    Class UnrecognizedFaceFoundState
        Inherits FinderState
        Public Overrides Sub Run()
            If (FindFace(face_id)) Then
                ChangeState("FoundState")
                Exit Sub
            End If
            ChangeState("FindingState")
        End Sub

    End Class



    MustInherit Class FinderState
        Inherits State
        'states that needs to check if there is face found
        Public Overrides Sub Run()
            If (FindFace(face_id)) Then ChangeState("FoundState")
        End Sub

        Protected Function FindFace(id As Integer) As Boolean
            Return id <> 0
        End Function

    End Class


    MustInherit Class FaceFound
        Inherits FinderState

        Protected Function Face_name(Optional id As Integer = -1000)
            id = If(id = -1000, face_id, id)
            Dim image_tag_name As String = ""
            Dim res As Integer = FSDK.GetAllNames(Facerecog.tracker, id, image_tag_name, 100) ' maximum of 100 characters
            Return image_tag_name
        End Function
    End Class

End Namespace
