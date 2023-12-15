Public Class UnlockingState
    Inherits FinderState



    Public Sub New()
        key = "unlocking"
    End Sub

    Public Overrides Sub Enter()
        form.Start_timer(Sub()
                             ChangeState("finding")
                         End Sub, "unlocking face", 600)
    End Sub

End Class
