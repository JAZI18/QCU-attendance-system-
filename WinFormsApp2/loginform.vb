Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Timers

Imports System.Security.Cryptography


Public Class loginform


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn.Click

        ' Hash the entered password
        Dim hashedPassword As String = HashedPasswords(pass_tb.Text)

        ' Fetch the hashed password from the database
        Dim reader As MySqlDataReader = SelectQuery("password", "admin_account", {un_tb.Text}, "username = @username")

        If Not reader.Read() Then
            invalid_lb.Visible = True
            un_tb.Clear()
            pass_tb.Clear()
            Exit Sub

        End If

        ' Compare hashed passwords
        If reader("password") = hashedPassword Then
            Me.Hide()
            admindashboardform.Show()
        Else
            invalid_lb.Visible = True
        End If

        un_tb.Clear()
        pass_tb.Clear()

    End Sub

    Public Function HashedPasswords(password As String)
        Using sha256 As New SHA256Managed()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower()
        End Using
    End Function



    Private Sub mainform_back_btn_Click(sender As Object, e As EventArgs) Handles mainform_back_btn.Click

        staffadminbtns.Show()
        Me.Close()

    End Sub





    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        timerCallAbsent()
    End Sub

    Private midnightTimer As Timer

    Function timerCallAbsent()
        ' Initialize and configure the timer
        midnightTimer = New Timer()
        midnightTimer.Interval = CalculateTimeToMidnight()
        midnightTimer.AutoReset = True ' Set to true if you want the timer to repeat

        ' Add an event handler for the Elapsed event
        AddHandler midnightTimer.Elapsed, AddressOf MidnightTimerElapsed

        ' Start the timer
        midnightTimer.Start()
    End Function

    Private Sub MidnightTimerElapsed(sender As Object, e As ElapsedEventArgs)
        ' Call the function at midnight
        AbsenceFunction.AddAbsenceForAllEmployees()

        ' Calculate the interval for the next midnight
        midnightTimer.Interval = CalculateTimeToMidnight()
    End Sub

    Private Function CalculateTimeToMidnight() As Double
        ' Calculate the time until the next midnight
        Dim now = DateTime.Now
        Dim midnight = now.Date.AddDays(1)
        Dim timeToMidnight = midnight.Subtract(now).TotalMilliseconds

        Return timeToMidnight
    End Function


End Class

