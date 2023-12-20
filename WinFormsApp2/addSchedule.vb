Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities

Public Class addSchedule

    Private _employeeCode As String

    Public Sub New()
        InitializeComponent()
    End Sub
    ' Modify the constructor to accept employeeCode as a parameter
    Public Sub New(employeeCode As String)
        InitializeComponent()
        _employeeCode = employeeCode


    End Sub

    Public Function setTime()
        Hour1.Maximum = 12 ' Change this to your desired maximum quantity
        Hour1.Minimum = 0
        Hour1.Value = 0

        min1.Maximum = 60 ' Change this to your desired maximum quantity
        min1.Minimum = 0
        min1.Value = 0

        sec1.Maximum = 60 ' Change this to your desired maximum quantity
        sec1.Minimum = 0
        sec1.Value = 0
        period.SelectedIndex = 0


        hour2.Maximum = 12 ' Change this to your desired maximum quantity
        hour2.Minimum = 0
        hour2.Value = 0

        min2.Maximum = 60 ' Change this to your desired maximum quantity
        min2.Minimum = 0
        min2.Value = 0

        sec2.Maximum = 60 ' Change this to your desired maximum quantity
        sec2.Minimum = 0
        sec2.Value = 0
        period2.SelectedIndex = 0
    End Function

    Private Sub addSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(getempid())

        ListDepartment()
        workday.SelectedIndex = 0

        setTime()

    End Sub


    ' Default constructor without parameters


    Function getempid() As String


        Dim reader As MySqlDataReader = SelectQuery("*", "employee_info", {_employeeCode}, "employee_code = @code")

        If reader.Read Then

            Return reader("employee_id")

        End If
        Return 0

    End Function



    Private Sub sub_btn_Click(sender As Object, e As EventArgs) Handles sub_btn.Click
        ' Validate the entered times
        Dim isValidTime1 As Boolean = ValidateTime(start_time.Text)
        Dim isValidTime2 As Boolean = ValidateTime(end_time.Text)

        ' Check if both times are valid
        If isValidTime1 AndAlso isValidTime2 Then
            ' Convert the time strings to TimeSpan


            ' Check if end time is greater than or equal to start time
            If TimeSpan.Parse(start_time.Text) >= TimeSpan.Parse(end_time.Text) Then
                ' Show an error message

                MessageBox.Show("End time must be greater than start time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Set the focus back to end_time TextBox
                end_time.Focus()
                Return
            End If

            ' Validate the date range
            Dim startDate As Date = e_date1.Value
            Dim endDate As Date = e_date2.Value

            If endDate < startDate Then
                ' Show an error message
                MessageBox.Show("End date must be greater than or equal to start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Set the focus back to e_date2
                e_date2.Focus()
                Return
            End If

            ' If validation passes, you can proceed with further processing or database insertion
            Try

                InsertQuery("employee_schedule", "employee_id,emp_branc_id,workday,shift_start_time,shift_end_time,schedule_start_date,schedule_end_date", {getempid(), selectDepartment(), workday.SelectedItem, TimeSpan.Parse(start_time.Text), TimeSpan.Parse(end_time.Text), e_date1.Value.ToString("yyyy/MM/dd"), e_date2.Value.ToString("yyyy/MM/dd")})

                MsgBox("Insertion successful")
                admindashboardform.Enabled = True
                Me.Close()
            Catch ex As Exception
                MsgBox("Error during database insertion: " & ex.Message)
            End Try
        Else
            ' Show an error message if time validation fails
            MessageBox.Show("Invalid time entered. Please enter valid start and end times.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateTime(timeString As String) As Boolean
        Dim validFormat As String = "HH:mm:ss"

        ' Try parsing the time using the specified format
        Dim parsedTime As Date
        If Date.TryParseExact(timeString, validFormat, Nothing, DateTimeStyles.None, parsedTime) Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub ListDepartment()
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_branches")
        e_dep.Items.Clear()
        While reader.Read
            e_dep.Items.Add(reader("branch_name"))
        End While
        e_dep.SelectedIndex = 0
        reader.Close()
    End Sub

    Function selectDepartment() As Integer
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_branches", {e_dep.SelectedItem}, "branch_name=@deparment")

        If reader.Read Then
            If Not reader.IsDBNull(reader.GetOrdinal("branch_id")) Then
                Dim departmentId As Integer = reader.GetInt32("branch_id")

                Return departmentId
            End If
        End If
        Return Nothing
    End Function


    Private Sub start_time_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub start_time_Click(sender As Object, e As EventArgs) Handles start_time.Click
        Panel2.Visible = True
    End Sub

    Private Sub okay_Click(sender As Object, e As EventArgs) Handles okay.Click
        ' Get the values from the controls
        Dim hour As Integer = Hour1.Value
        Dim minute As Integer = min1.Value
        Dim second As Integer = sec1.Value
        Dim periods As String = period.SelectedItem.ToString()

        ' Adjust the hour based on the period (AM or PM)
        If periods.ToUpper() = "PM" AndAlso hour < 12 Then
            hour += 12
        ElseIf periods.ToUpper() = "AM" AndAlso hour = 12 Then
            hour = 0
        End If

        ' Create a DateTime object using the adjusted values
        Dim dateTime As New DateTime(1, 1, 1, hour, minute, second)

        ' Set the label text to the formatted time in military format
        start_time.Text = dateTime.ToString("HH:mm:ss")

        ' Hide the panel
        Panel2.Visible = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn.Click
        ' Get the values from the controls
        Dim hour As Integer = hour2.Value
        Dim minute As Integer = min2.Value
        Dim second As Integer = sec2.Value
        Dim periods As String = period2.SelectedItem.ToString()

        ' Adjust the hour based on the period (AM or PM)
        If periods.ToUpper() = "PM" AndAlso hour < 12 Then
            hour += 12
        ElseIf periods.ToUpper() = "AM" AndAlso hour = 12 Then
            hour = 0
        End If

        ' Create a DateTime object using the adjusted values
        Dim dateTime As New DateTime(1, 1, 1, hour, minute, second)

        ' Set the label text to the formatted time in military format
        end_time.Text = dateTime.ToString("HH:mm:ss")

        ' Hide the panel
        Panel3.Visible = False
    End Sub




    Private Sub end_time_Click(sender As Object, e As EventArgs) Handles end_time.Click
        Panel3.Visible = True
    End Sub
End Class
