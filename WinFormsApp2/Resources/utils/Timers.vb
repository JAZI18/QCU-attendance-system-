Imports System.Timers


Namespace Erenjhun.Utils
    Public Module Timers_util

        Private timers As New Dictionary(Of String, Timer)

        Public Sub Start_timer(f As Action, t_name As String, Optional interval As Integer = 1000, Optional repeat As Boolean = False)


            If Timers.ContainsKey(t_name) Then
                With Timers.Item(t_name)
                    .Stop()
                    .Dispose()
                End With

                Timers.Remove(t_name)
            End If

            Dim delay_timer As New Timer With {
                .Interval = interval,
                .AutoReset = repeat
            }

            AddHandler delay_timer.Elapsed, Sub()
                                                f()
                                                With delay_timer
                                                    .Stop()
                                                    .Dispose()
                                                End With
                                                Timers.Remove(t_name)
                                            End Sub
            Timers.Add(t_name, delay_timer)
            delay_timer.Start()
        End Sub


        Public Sub Stop_timer(t_name As String)
            Try
                Timers.Item(t_name).Dispose()
            Catch ex As Exception
            End Try

            Timers.Remove(t_name)
        End Sub

    End Module
End Namespace


