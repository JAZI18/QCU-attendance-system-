Public Class nav
    Inherits Panel

    Private _selected As Button
    Public highlightBackColor As Color
    Public normalBackColor As Color
    Public buttons As Button()


    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()

        For Each btn As Button In buttons



            AddHandler btn.Click, Sub()
                                      If _selected Is _selected Then Exit Sub
                                      HandleSelect(btn)
                                  End Sub
        Next
    End Sub

    Private Sub HandleSelect(btn)
        _selected.BackColor = normalBackColor
        _selected = btn
        _selected.BackColor = highlightBackColor
    End Sub

    Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
        If (TypeOf e.Control Is Button) Then
            MyBase.OnControlAdded(e)
            buttons.Append(e.Control)
            Return
        End If
    End Sub
End Class
