Imports System.Data.SqlClient
Public Class Form1

    ReadOnly con As New SqlConnection("server=LTIN303717;database=bankingDB_VB;integrated security = true")
    ReadOnly cmd As New SqlDataAdapter("select * from Accounts", con)
    ReadOnly ds As New DataSet()
    ReadOnly builder As New SqlCommandBuilder(cmd) 'this will build all the commands, insert, update, delete
    Dim dv As New DataView

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        dv = ds.Tables(0).DefaultView
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd.Update(ds.Tables(0))
        MessageBox.Show("Data Updated Successfully")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dv.RowFilter = "accName like '" & TextBox1.Text & "%'"
    End Sub

End Class