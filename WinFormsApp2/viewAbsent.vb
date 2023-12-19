Imports MySql.Data.MySqlClient

Public Class viewAbsent
    Private Sub viewAbsent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        absentLoad(search_absent.Text)
    End Sub

    Function absentLoad(searchCriteria As String)
        ' Modify the NewQuery method to include a WHERE clause based on the searchCriteria

        Dim command As MySqlCommand = NewQuery("SELECT * FROM absent_emp WHERE LOWER(employee_code) LIKE '%" & searchCriteria.ToLower() & "%' OR LOWER(employee_Name) LIKE '%" & searchCriteria.ToLower() & "%' OR LOWER(workday) LIKE '%" & searchCriteria.ToLower() & "%' OR LOWER(branch_name) LIKE '%" & searchCriteria.ToLower() & "%' OR date = '" & searchCriteria & "'", Nothing)

        Dim reader As MySqlDataReader = command.ExecuteReader()

        ' Clear existing rows before adding new ones
        DataGridView1.Rows.Clear()

        While reader.Read
            DataGridView1.Rows.Add(reader("employee_code"), reader("branch_name"), reader("employee_Name"), reader("workday"), CType(reader("date"), DateTime).ToString("yyyy-MM-dd"), reader("status"))
        End While
    End Function

    Private Sub search_btn_dept_Click(sender As Object, e As EventArgs) Handles search_btn_dept.Click
        Dim search As String = search_absent.Text

        ' Call the absentLoad function with the search criteria
        absentLoad(search)
    End Sub



End Class