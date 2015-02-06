Imports System.Data.SqlClient

Public Class frmTranscript
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub frmEnroll_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=FATI\SQLEXPRESS;Initial Catalog=visualbasic_final;Integrated Security=True"

        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Students"

        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(ds)

        cmbSelectStudent.DataSource = ds.Tables(0)
        cmbSelectStudent.ValueMember = "Id"
        cmbSelectStudent.DisplayMember = "FirstName"
    End Sub
   
    Private Sub btnLoadTranscript_Click(sender As Object, e As EventArgs) Handles btnLoadTranscript.Click
        cmd.Parameters.Clear()
        cmd.CommandText = "Select CourseName, Credits, Grade FROM Enrollment E, Courses C WHERE e.courseId = c.Id AND E.StudentId = @StudentID"
        cmd.Parameters.Add(New SqlParameter("@StudentId", cmbSelectStudent.SelectedValue))

        Dim adapter As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        adapter.Fill(ds)
        grdTranscript.DataSource = ds.Tables(0)

    End Sub

    Private Sub cmbSelectStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectStudent.SelectedIndexChanged

    End Sub
End Class