Public Class nav
    Inherits Panel

    Private _selected As Button

    Private _highlightBackColor As Color
    Private _normalBackColor As Color
    Public buttons As New Collection

    Public Property HighlightBackColor As Color
        Get
            Return _highlightBackColor
        End Get
        Set(value As Color)
            _highlightBackColor = value
        End Set
    End Property

    Public Property NormalBackColor As Color
        Get
            Return _normalBackColor
        End Get
        Set(value As Color)
            _normalBackColor = value
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        AddHandler FindForm().Load, Sub()
                                        For Each btn As Button In buttons
                                            AddBtnHandler(btn)
                                        Next
                                    End Sub
    End Sub

    Private Sub AddBtnHandler(btn As Button)
        AddHandler btn.Click, Sub()
                                  If _selected Is btn Then Exit Sub
                                  HandleSelect(btn)
                              End Sub
    End Sub

    Private Sub HandleSelect(btn)
        If _selected IsNot Nothing Then _selected.BackColor = NormalBackColor
        _selected = btn
        _selected.BackColor = HighlightBackColor
    End Sub

    Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
        If (TypeOf e.Control Is Button) Then
            Dim btn = e.Control
            buttons.Add(btn)
            MyBase.OnControlAdded(e)
            Return
        End If
    End Sub
End Class
