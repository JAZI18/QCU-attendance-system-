Imports System.Data
Imports System.Security.Cryptography.X509Certificates
Imports System.Timers
Imports MySql.Data.MySqlClient

Imports System.Threading


Module AbsenceFunction

    ' Function to add absence for employees
    Public Sub AddAbsenceForAllEmployees()
        ' Create a connection

        con.Open()

        ' Get the list of employees with their schedules
        Dim employeeScheduleQuery As MySqlDataReader = SelectQuery("*", "getschedule")


        While employeeScheduleQuery.Read
            Dim employeeId As Integer = employeeScheduleQuery("employee_id")
            Dim workday As String = employeeScheduleQuery("workday")
            MsgBox("add A ABSENT EMPLOYEE IN " & workday)
            'Dim workday As String = scheduleReader("workday")
            Dim startDate As Date = employeeScheduleQuery("schedule_start_date")
            Dim endDate As Date = employeeScheduleQuery("schedule_end_date")

            ' Check if the current date is within the schedule start and end dates
            If Date.Today >= startDate AndAlso Date.Today <= endDate Then
                ' Check if the employee has a time-in or time-out for the current workday
                If EmployeeHasAttendance(employeeId, workday) Then
                    ' Add absence record for the current workday
                    AddAbsenceRecord(employeeId, workday, Date.Today)
                End If
            End If
        End While




    End Sub



    Private Function EmployeeHasAttendance(employeeId As Integer, workday As String) As Boolean
        Dim connectionString = "server=sql12.freesqldatabase.com;user=sql12669578;password=BuhKRqTpZI;database=sql12669578;charset=utf8;Allow User Variables=True; convert zero datetime=True "

        ' Use a LEFT JOIN to include all employees and filter those who did not attend
        Dim attendanceQuery As String = "SELECT COUNT(*) FROM employee_schedule AS es " &
                                    "LEFT JOIN emp_attendance AS ea ON es.employee_id = ea.employee_id " &
                                    "AND es.workday = ea.workday AND ea.date = @Date " &
                                    "WHERE es.employee_id = @EmployeeId AND es.workday = @Workday AND ea.emp_attendace_id IS NULL"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using attendanceCommand As New MySqlCommand(attendanceQuery, connection)
                attendanceCommand.Parameters.AddWithValue("@EmployeeId", employeeId)
                attendanceCommand.Parameters.AddWithValue("@Workday", workday)
                attendanceCommand.Parameters.AddWithValue("@Date", Date.Today)

                Dim didNotAttendCount As Integer = CInt(attendanceCommand.ExecuteScalar())
                'MsgBox("Employees who did not attend on " & workday & ": " & didNotAttendCount)
                Return didNotAttendCount > 0
            End Using
        End Using
    End Function


    ' Function to add an absence record for an employee
    Private Sub AddAbsenceRecord(employeeId As Integer, workday As String, absenceDate As Date)
        Dim connectionString = "server=sql12.freesqldatabase.com;user=sql12669578;password=BuhKRqTpZI;database=sql12669578;charset=utf8;Allow User Variables=True; convert zero datetime=True "

        Dim insertQuery As String = "INSERT INTO emp_attendance (employee_id, workday, date, time_in, time_out, over_time_in, over_time_out) " &
                                    "VALUES (@EmployeeId, @Workday, @Date, NULL, NULL, NULL, NULL)"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using insertCommand As New MySqlCommand(insertQuery, connection)
                insertCommand.Parameters.AddWithValue("@EmployeeId", employeeId)
                insertCommand.Parameters.AddWithValue("@Workday", workday)
                insertCommand.Parameters.AddWithValue("@Date", absenceDate)

                insertCommand.ExecuteNonQuery()
            End Using
        End Using
    End Sub



End Module
