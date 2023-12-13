Public Class UnlockingState
    Inherits FinderState

    Public Overrides Sub Enter()
        form.Start_timer(Sub()
                             ChangeState("FindingState")
                         End Sub, "unlocking face", 600)
    End Sub

End Class
