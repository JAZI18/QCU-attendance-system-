
Imports System.ComponentModel

Public Class stats_button


    <Browsable(True)>
    Public Shadows Event Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent Click(sender, e)
    End Sub


    Public Property Counter As String
        Get
            Return Int(count_lb.Text)
        End Get
        Set(value As String)
            Try
                count_lb.Text = Int(value)
            Catch ex As Exception
                MsgBox("value of counter must be a integer")
                count_lb.Text = 0
            End Try
        End Set
    End Property

    Public Property Label As String
        Get
            Return label_lb.Text
        End Get
        Set(value As String)
            label_lb.Text = value
        End Set
    End Property
End Class
