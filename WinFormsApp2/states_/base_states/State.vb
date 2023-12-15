Public MustInherit Class State

    Private _manager1 As StateManager
    Protected form As mainform
    Public face_id As Integer = -10
    Public before As State
    Public key As String

    Public Property Curr_emp_id As Object
        Get
            Return form.curr_emp_id
        End Get
        Set(value As Object)
            form.curr_emp_id = value
        End Set
    End Property

    Public Property Manager As StateManager
        Get
            Return _manager1
        End Get
        Set(value As StateManager)
            _manager1 = value
            form = _manager1.parent
        End Set
    End Property

    Public Sub ChangeState(key As String)
        Manager.SetState(key)
    End Sub

    Public Overridable Sub Enter()
    End Sub

    Public Overridable Sub Run()
    End Sub




End Class
