Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Module Connection


    Private conString = "server=sql12.freesqldatabase.com;user=sql12665374;password=rWT73f2vYC;database=sql12665374;charset=utf8"
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
    ''' <param name="sql"></param>
    ''' <returns></returns>
    Function newQuery(sql As String, ParamArray vals As String()) As MySqlCommand
        openCon()

        Dim cmd = newCommand(sql)
        Dim matches = findParams(sql)

        MsgBox(matches.Count)

        compareParamsValsCount(matches, vals)
        setParamsVal(cmd, matches, vals)

        Return cmd
    End Function



    Private Sub setParamsVal(cmd, params, vals)



        With cmd.Parameters

            For i = 0 To params.Length - 1
                .AddWithValue(params(i), vals(i))
            Next
        End With
    End Sub

    Private Function findParams(sql As String) As String()
        Dim myStr As String = sql
        Dim pattern As String = "@[A-Za-z]+"
        Dim regex As New Regex(pattern)

        Dim matches As New HashSet(Of String)


        For Each sMatches In regex.Matches(myStr)
            matches.Add(sMatches.value)
        Next

        Return matches.ToArray()
    End Function

    Private Sub compareParamsValsCount(params As String(), vals As String())
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
    Function selectQuery(fields As String, table As String, Optional vals As String() = Nothing, Optional whereClause As String = Nothing) As MySqlDataReader

        Dim sql = $"SELECT * from {table}"


        If (whereClause IsNot Nothing) Then
            sql += $" Where {whereClause}"
        End If

        MsgBox(sql)

        Dim cmd As MySqlCommand = newQuery(sql, vals)

        Return cmd.ExecuteReader()
    End Function

    ''' <summary>
    ''' update helper
    ''' </summary>
    ''' <param name="fields"></param>
    ''' <param name="table"></param>
    ''' <param name="vals"></param>
    ''' <param name="whereClause"></param>
    ''' <returns></returns>
    Function updateQuery(table As String, fields As String, vals As String(), Optional whereClause As String = Nothing) As Integer

        Dim sql = $"UPDATE {table} SET "

        Dim fArr = fields.Split(",")

        For i = 0 To fArr.Length - 1
            sql += $"{fArr(i)} = @{fArr(i)}" + If(i = fArr.Length - 1, "", ",")
        Next

        MsgBox(sql)

        If whereClause IsNot Nothing Then sql += $" where {whereClause}"

        Dim cmd As MySqlCommand = newQuery(sql, vals)

        Return cmd.ExecuteNonQuery()
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="fields"></param>
    ''' <param name="vals"></param>
    ''' <returns></returns>
    Function insertQuery(table As String, fields As String, vals As String()) As Integer

        Dim sql = $"INSERT INTO {table} ( {fields} ) values ("

        Dim fArr = fields.Split(",")

        For i = 0 To fArr.Length - 1
            sql += $"@{fArr(i)}" + If(i = fArr.Length - 1, ")", ",")
        Next

        MsgBox(sql)

        Dim cmd As MySqlCommand = newQuery(sql, vals)

        Return cmd.ExecuteNonQuery()
    End Function


    Function deleteQuery(table As String, whereClause As String, vals As String()) As Integer

        Dim sql = $"DELETE from {table} where {whereClause}"

        MsgBox(sql)

        Dim cmd = newQuery(sql, vals)


        Return cmd.ExecuteNonQuery()
    End Function


End Module
