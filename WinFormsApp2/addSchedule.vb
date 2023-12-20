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
    Private Sub addSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(getempid())
        MaskedTextBox1.Mask = "00:00:00"
        MaskedTextBox2.Mask = "00:00:00"
        ListDepartment()
        workday.SelectedIndex = 0

    End Sub


    ' Default constructor without parameters


    Function getempid() As String


        Dim reader As MySqlDataReader = SelectQuery("*", "employee_info", {_employeeCode}, "employee_code = @code")

        If reader.Read Then

            Return reader("employee_id")

        End If
        Return 0

    End Function


    Private Sub MaskedTextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MaskedTextBox1.Validating
        ' Validate the entered time
        Dim isValid As Boolean = ValidateTime(MaskedTextBox1.Text)

        If Not isValid Then
            ' Show an error message
            MessageBox.Show("Invalid time entered. Please enter a valid time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Set the focus back to the MaskedTextBox
            MaskedTextBox1.Focus()
        End If
    End Sub

    Private Sub MaskedTextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MaskedTextBox2.Validating
        ' Validate the entered time
        Dim isValid As Boolean = ValidateTime(MaskedTextBox2.Text)

        If Not isValid Then
            ' Show an error message
            MessageBox.Show("Invalid time entered. Please enter a valid time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Set the focus back to the MaskedTextBox
            MaskedTextBox1.Focus()
        End If
    End Sub
    Private Function ValidateTime(time As String) As Boolean
        ' Validate hours, minutes, and seconds
        Dim parts As String() = time.Split(":"c)
        Dim hours As Integer
        Dim minutes As Integer
        Dim seconds As Integer

        If parts.Length = 3 AndAlso Integer.TryParse(parts(0), hours) AndAlso Integer.TryParse(parts(1), minutes) AndAlso Integer.TryParse(parts(2), seconds) Then
            ' Check if hours, minutes, and seconds are within valid range
            If hours >= 0 AndAlso hours <= 23 AndAlso minutes >= 0 AndAlso minutes <= 59 AndAlso seconds >= 0 AndAlso seconds <= 59 Then
                Return True
            End If
        End If

        Return False
    End Function
    Private Sub sub_btn_Click(sender As Object, e As EventArgs) Handles sub_btn.Click
        ' Validate the entered times
        Dim isValidTime1 As Boolean = ValidateTime(MaskedTextBox1.Text)
        Dim isValidTime2 As Boolean = ValidateTime(MaskedTextBox2.Text)

        ' Check if both times are valid
        If isValidTime1 AndAlso isValidTime2 Then
            ' Convert the time strings to TimeSpan
            Dim time1 As TimeSpan = TimeSpan.Parse(MaskedTextBox1.Text)
            Dim time2 As TimeSpan = TimeSpan.Parse(MaskedTextBox2.Text)

            ' Check if MaskedTextBox2 is greater than MaskedTextBox1
            If time2 <= time1 Then
                ' Show an error message
                MessageBox.Show("End time must be greater than start time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Set the focus back to MaskedTextBox2
                MaskedTextBox2.Focus()
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
                ' Your database insertion code here
                InsertQuery("employee_schedule", "employee_id,emp_branc_id,workday,shift_start_time,shift_end_time,schedule_start_date,schedule_end_date", {getempid(), selectDepartment(), workday.SelectedItem, TimeSpan.Parse(MaskedTextBox1.Text), TimeSpan.Parse(MaskedTextBox2.Text), e_date1.Value.ToString("yyyy/MM/dd"), e_date2.Value.ToString("yyyy/MM/dd")})

                MsgBox("Insertion successful")
                Me.Close()
            Catch ex As Exception
                MsgBox("Error during database insertion: " & ex.Message)
            End Try
        Else
            ' Show an error message if time validation fails
            MessageBox.Show("Invalid time entered. Please enter valid start and end times.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Public Sub ListDepartment()
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department")
        e_dep.Items.Clear()
        While reader.Read
            e_dep.Items.Add(reader("department_name"))
        End While
        e_dep.SelectedIndex = 0
        reader.Close()
    End Sub

    Function selectDepartment() As Integer
        Dim reader As MySqlDataReader = SelectQuery("*", "qcu_department", {e_dep.SelectedItem}, "department_name=@deparment")

        If reader.Read Then
            If Not reader.IsDBNull(reader.GetOrdinal("department_id")) Then
                Dim departmentId As Integer = reader.GetInt32("department_id")
                Console.WriteLine("Department ID: " & departmentId)
                Return departmentId
            End If
        End If
        Return Nothing
    End Function


End Class