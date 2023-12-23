Imports System.Globalization
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports WinFormsApp2.Erenjhun.Utils

Public Class addSchedule


    Public Property empid As String
    Private fullname As String

    Public Sub New()
        InitializeComponent()
    End Sub
    ' Modify the constructor to accept employeeCode as a parameter
    Public Sub New(empid As String, fullname As String)
        InitializeComponent()
        Me.empid = empid
        Me.fullname = fullname
    End Sub

    Public Sub setTime()
        Hour1.Maximum = 12 ' Change this to your desired maximum quantity
        Hour1.Minimum = 0
        Hour1.Value = 0

        min1.Maximum = 60 ' Change this to your desired maximum quantity
        min1.Minimum = 0
        min1.Value = 0

        period.SelectedIndex = 0

        hour2.Maximum = 12 ' Change this to your desired maximum quantity
        hour2.Minimum = 0
        hour2.Value = 0

        min2.Maximum = 60 ' Change this to your desired maximum quantity
        min2.Minimum = 0
        min2.Value = 0
        period2.SelectedIndex = 0
    End Sub

    Private Sub addSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employee_name.Text = fullname
        ListDepartment()
        workday.SelectedIndex = 0
        setTime()
        FillDatagrid(sched_datagrid, NewQuery("select * from emp_sched_view where `Employee ID` = @id ", {empid}))
    End Sub




    Private Sub sub_btn_Click(sender As Object, e As EventArgs) Handles sub_btn.Click
        ' Validate the entered times
        Dim isValidTime1 As Boolean = ValidateTime(start_time.Text)
        Dim isValidTime2 As Boolean = ValidateTime(end_time.Text)

        ' Check if both times are valid
        If Not isValidTime1 Or Not isValidTime2 Then Return
        ' Convert the time strings to TimeSpan

        Dim ts_end = DateTime.Parse("2023-12-20 " + end_time.Text).TimeOfDay
        Dim ts_start = DateTime.Parse("2023-12-20 " + start_time.Text).TimeOfDay

        ' Check if end time is greater than or equal to start time

        If ts_start >= ts_end Then
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

            InsertQuery("employee_schedule", "employee_id,emp_branc_id,workday,shift_start_time,shift_end_time,schedule_start_date,schedule_end_date", {_empid, selectDepartment(), workday.SelectedItem, ts_start, ts_end, e_date1.Value.ToString("yyyy/MM/dd"), e_date2.Value.ToString("yyyy/MM/dd")})
            MsgBox("Insertion successful")
        Catch ex As Exception
            MsgBox("Error during database insertion: " & ex.Message)
        End Try

        FillDatagrid(sched_datagrid, NewQuery("select * from emp_sched_view where `Employee ID` = @id ", {empid}))
    End Sub

    Private Function ValidateTime(timeString As String) As Boolean
        Dim validFormat As String = "HH:mm tt"

        ' Try parsing the time using the specified format
        Dim parsedTime As Date
        If Date.TryParseExact(timeString, validFormat, Nothing, DateTimeStyles.None, parsedTime) Then
            Return True
        Else
            ' Show an error message if time validation fails
            MessageBox.Show("Invalid time entered. Please enter valid start and end times.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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



    Private Sub start_time_Click(sender As Object, e As EventArgs) Handles start_time.Click
        open_timer_selector(start_time_selector_panel)
    End Sub



    Private Sub end_time_Click(sender As Object, e As EventArgs) Handles end_time.Click
        open_timer_selector(end_time_selector_panel)
    End Sub


    Private Sub open_timer_selector(timer_panel As Panel)
        timer_panel.Visible = True
    End Sub


    Private Sub okay_Click(sender As Object, e As EventArgs) Handles okay.Click
        ' Get the values from the controls
        Dim hour As Integer = Hour1.Value
        Dim minute As Integer = min1.Value
        Dim second As Integer = 0
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
        start_time.Text = dateTime.ToString("HH:mm tt")

        ' Hide the panel
        start_time_selector_panel.Visible = False

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn.Click
        ' Get the values from the controls
        Dim hour As Integer = hour2.Value
        Dim minute As Integer = min2.Value
        Dim second As Integer = 0
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
        end_time.Text = dateTime.ToString("HH:mm tt")

        ' Hide the panel
        end_time_selector_panel.Visible = False

    End Sub




End Class
