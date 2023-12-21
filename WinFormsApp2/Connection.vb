Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Module Connection



    'Private conString = "server=localhost;user=root;password=;database=qcu_attendance_db;charset=utf8;Allow User Variables=True; convert zero datetime=True "
    Private conString = "server=sql12.freesqldatabase.com;user=sql12671822;password=ahMPy8FFfH;database=sql12671822;charset=utf8;Allow User Variables=True; convert zero datetime=True;"
    Public con As New MySqlConnection(conString)

    Sub openCon()
        con.Close()
        con.Open()
    End Sub

    ''' <summary>
    ''' mysqlcommand creation helper
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <returns></returns>
    Function newCommand(sql As String) As MySqlCommand
        Return New MySqlCommand(sql, con)
    End Function

    ''' <summary>
    ''' opens connection , creates mysqlcommand with params added
    ''' </summary>
    ''' <remarks>
    ''' sql -> sql string 
    ''' vals -> values inside array same order from sql string
    ''' </remarks>
    ''' <param name="sql"></param>
    ''' <returns></returns>
    Function NewQuery(sql As String, vals As Object()) As MySqlCommand
        openCon()

        Dim cmd = newCommand(sql)
        Dim matches = FindParams(sql)

        CompareParamsValsCount(matches, vals)
        SetParamsVal(cmd, matches, vals)

        Return cmd
    End Function

    Private Sub SetParamsVal(cmd, params, vals)
        With cmd.Parameters
            For i = 0 To params.Length - 1

                .AddWithValue(params(i), vals(i))
            Next
        End With
    End Sub

    Private Function FindParams(sql As String) As String()
        Dim myStr As String = sql
        Dim pattern As String = "@\w+"
        Dim regex As New Regex(pattern)


        'MsgBox(sql)
        Dim matches As New HashSet(Of String)

        For Each sMatches In regex.Matches(myStr)
            matches.Add(sMatches.value)
        Next

        Return matches.ToArray()
    End Function

    Private Sub CompareParamsValsCount(params As String(), vals As Object())
        If vals Is Nothing Then vals = {}

        If params.Length <> vals.Length Then
            Throw New Exception($"query @params count must be the same with vals value count, params:{params.Length} vals:{vals.Length}")
        End If
    End Sub


    ''' <summary>
    ''' ( select query ) function helper
    ''' opens the connection then builds the sql command for you sheeeshhhh!
    ''' bruh automaticaly closes the connection after
    ''' </summary>
    ''' <param name="fields"></param>
    ''' <param name="table"></param>
    ''' <returns>the MySqlDataReader </returns>
    Function SelectQuery(fields As String, table As String, Optional vals As Object() = Nothing, Optional whereClause As String = Nothing) As MySqlDataReader
        Dim cmd As MySqlCommand = selectQHelper(fields, table, vals, whereClause)
        Return cmd.ExecuteReader()
    End Function

    Private Function selectQHelper(fields As String, Table As String, Optional vals As Object() = Nothing, Optional whereClause As String = Nothing) As MySqlCommand
        Dim sql = $"SELECT {fields} from {Table}"

        If (whereClause IsNot Nothing) Then
            sql += $" Where {whereClause}"
        End If

        Return NewQuery(sql, vals)
    End Function

    Function selectScalarQuery(fields As String, table As String, Optional vals As Object() = Nothing, Optional whereClause As String = Nothing) As Object
        Dim cmd As MySqlCommand = selectQHelper(fields, table, vals, whereClause)
        Return cmd.ExecuteScalar()
    End Function



    ''' <summary>
    ''' update query query builder
    ''' fields is string seperated by comma
    ''' 
    ''' </summary>
    ''' <remarks>
    ''' pre fields lang wala ng @ hahahahah
    ''' 
    ''' </remarks>
    ''' 
    ''' <param name="table"></param>
    ''' <param name="fields"></param>
    ''' <param name="vals"></param>
    ''' <param name="whereClause"></param>
    ''' <returns>mysqlDataReader</returns>
    Function UpdateQuery(table As String, fields As String, vals As Object(), Optional whereClause As String = Nothing) As Integer

        Dim sql = $"UPDATE {table} SET "

        Dim fArr = fields.Split(",")

        For i = 0 To fArr.Length - 1
            sql += $"{fArr(i)} = @{fArr(i)}" + If(i = fArr.Length - 1, "", ",")
        Next

        If whereClause IsNot Nothing Then sql += $" where {whereClause}"

        Dim cmd As MySqlCommand = NewQuery(sql, vals)

        Return cmd.ExecuteNonQuery()
    End Function


    ''' <summary>
    '''  insert query query builder
    ''' fields is string seperated by comma
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="fields"></param>
    ''' <param name="vals"></param>
    ''' <returns>number of rows inserted</returns>
    Function InsertQuery(table As String, fields As String, vals As Object()) As Integer
        Dim sql = $"INSERT INTO {table} ( {fields} ) values ("

        Dim fArr = fields.Split(",")



        For i = 0 To fArr.Length - 1
            sql += $" @{fArr(i)} " + If(i = fArr.Length - 1, ")", ",")
        Next



        Dim cmd As MySqlCommand = NewQuery(sql, vals)

        Return cmd.ExecuteNonQuery()
    End Function

    ''' <summary>
    ''' delete query query builder
    ''' vals is array of string values used in where cluse
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="whereClause"></param>
    ''' <param name="vals"></param>
    ''' <returns>number of rows deleted</returns>
    Function DeleteQuery(table As String, whereClause As String, vals As Object()) As Integer
        Dim sql = $"DELETE from {table} where {whereClause}"
        Dim cmd = NewQuery(sql, vals)
        Return cmd.ExecuteNonQuery()
    End Function

End Module
