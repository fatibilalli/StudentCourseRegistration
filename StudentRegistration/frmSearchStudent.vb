Imports System.Data.SqlClient

Public Class frmSearchStudent

    Private Sub txtSearchStudent_TextChanged(sender As Object, e As EventArgs) Handles txtSearchStudent.TextChanged
        Dim con As New SqlConnection
        con.ConnectionString = "Server=FATI\SQLEXPRESS;Database=visualbasic_final;Trusted_Connection=True;"

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "Select * FROM Students WHERE Firstname LIKE @Firstname"
        cmd.Parameters.Add(New SqlParameter("@FirstName", "%" + txtSearchStudent.Text + "%"))

        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(ds)

        grdStudent.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        If grdStudent.SelectedRows.Count = 0 Then
            Return
        End If

        Dim id As Integer
        id = Convert.ToInt32(grdStudent.SelectedRows.Item(0).Cells(0).Value)

        Dim firstname As String
        firstname = grdStudent.SelectedRows.Item(0).Cells(1).Value

        Dim lastname As String
        lastname = grdStudent.SelectedRows.Item(0).Cells(2).Value

        Dim f As New frmEnroll
        f.txtStudentID.Text = id.ToString()
        f.txtFirstName.Text = firstname
        f.txtLastName.Text = lastname
        f.ShowDialog()

    End Sub

    Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        If grdStudent.SelectedRows.Count = 0 Then
            Return
        End If
       

    End Sub
End Class