



Imports MySql.Data.MySqlClient

Namespace Erenjhun.Utils

    Module DataGridFiller





        Public Sub FillDatagrid(datagrid As DataGridView, cmd As MySqlCommand)

            datagrid.DataSource = Nothing


            Dim dataTable As New DataTable()


            Using adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dataTable)
            End Using

            datagrid.DataSource = dataTable
            datagrid.Refresh()
        End Sub

    End Module
End Namespace
