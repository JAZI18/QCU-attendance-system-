Imports MySql.Data.MySqlClient

Module Connection


    Private conString = "server=sql12.freesqldatabase.com;user= sql12665100;password=RxXLRtru1b;database=sql12665100;"
    Public con As New MySqlConnection(conString)


    Sub openCon()
        con.Open()
    End Sub


    'mysqlcommand creation helper
    Function newCommand(query As String) As MySqlCommand
        Return New MySqlCommand(query, con)
    End Function

    'opens connection and creates mysqlcommand 
    Function newQuery(query As String) As MySqlCommand
        openCon()
        Return newCommand(query)
    End Function




End Module
