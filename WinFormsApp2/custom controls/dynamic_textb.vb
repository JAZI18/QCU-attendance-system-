

Public Class dynamic_textb
    Inherits TextBox

    Protected Overrides Sub OnCreateControl()



        Try
            resize_()
        Catch ex As Exception

        End Try




        'AddHandler Parent.Resize, Sub()


        '                              MsgBox(Me.Height - Parent.Height)

        '                              Dim f As Single = Me.Height

        '                              Do While Math.Abs(Me.Height - Parent.Height) > 5
        '                                  f += (Parent.Height - Me.Height)
        '                                  Me.Font = New Font(Me.Font.Name, f, Me.Font.Style, GraphicsUnit.Pixel)
        '                              Loop
        '                          End Sub

        MyBase.OnCreateControl()
    End Sub

    Private Sub resize_()

        Dim f As Single = Me.Height

        Do While Math.Abs(Me.Height - Parent.Height) > 1
            f += (Parent.Height - Me.Height)
            Me.Font = New Font(Me.Font.Name, f, Me.Font.Style, GraphicsUnit.Pixel)
        Loop

    End Sub


End Class
