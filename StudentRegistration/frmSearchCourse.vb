Imports System.Data.SqlClient

Public Class frmSearchCourse

    Private Sub txtSearchCourse_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCourse.TextChanged
        Dim con As New SqlConnection
        con.ConnectionString = "Server=FATI\SQLEXPRESS;Database=visualbasic_final;Trusted_Connection=True;"

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "Select * FROM Courses WHERE CourseName LIKE @CourseName"
        cmd.Parameters.Add(New SqlParameter("@CourseName", "%" + txtSearchCourse.Text + "%"))

        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(ds)

        grdSearchStudent.DataSource = ds.Tables(0)
    End Sub
End Class