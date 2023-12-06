Public Class addDepartment
    Private Sub sub_btn_Click(sender As Object, e As EventArgs) Handles sub_btn.Click
        Try
            InsertQuery("qcu_department", "department_name,department_desc",
        {dep_name.Text, dep_desc.Text})
            MessageBox.Show("Record inserted successfully.")

            admindashboardform.UpdateDeptGridView2()
            Me.Close()


        Catch ex As Exception
            MsgBox("Error occured" & ex.StackTrace)

        Finally
            con.Close()
            dep_name.Clear()
            dep_desc.Clear()

        End Try

    End Sub
End Class