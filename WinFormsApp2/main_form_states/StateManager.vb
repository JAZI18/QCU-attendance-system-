Public Class StateManager

    Public curr_state As State = Nothing
    Public prev_state As State = Nothing

    Public parent As mainform
    Private ReadOnly states As New Dictionary(Of String, State)



    Public Sub New(states As State(), parent As mainform)
        Me.parent = parent
        Me.states = StateFromArr(states)

        SetState(Me.states.First.Key)
    End Sub

    Private Function StateFromArr(stateArr) As Dictionary(Of String, State)
        Dim stateDic As New Dictionary(Of String, State)


        For Each state As State In stateArr
            stateDic.Add(state.key, state)
            state.Manager = Me
        Next
        Return stateDic
    End Function


    Public Sub SetState(key As String)

        'MsgBox(key)

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
