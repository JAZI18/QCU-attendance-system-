
Namespace Erenjhun.Utils
    Public Class StateManager
        Public prev_state As State = New startState
        Public curr_state As State = prev_state
        Public parent As FaceRecognition
        Private ReadOnly states As New Dictionary(Of String, State)

        Friend Sub Init()
            SetState(Me.states.First.Key)
        End Sub


        Public Sub New(states As State(), parent As FaceRecognition)
            Me.parent = parent
            Me.states = StateFromArr(states)
        End Sub

        Private Function StateFromArr(stateArr) As Dictionary(Of String, State)
            Dim stateDic As New Dictionary(Of String, State)


            For Each state As State In stateArr
                stateDic.Add(state.key, state)
                state.manager = Me
            Next
            Return stateDic
        End Function


        Public Sub SetState(key As String)
            If (prev_state IsNot Nothing) Then curr_state.before = prev_state
            prev_state = curr_state
            curr_state = states.Item(key)
            If (prev_state IsNot Nothing) Then curr_state.face_id = prev_state.face_id
            curr_state.Enter()
        End Sub



        Public Sub Run(id As Integer)
            curr_state.face_id = id
            curr_state.Run()
        End Sub

    End Class
End Namespace