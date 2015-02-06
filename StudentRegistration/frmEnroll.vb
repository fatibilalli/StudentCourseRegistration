Imports System.Data.SqlClient

Public Class frmEnroll
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub frmEnroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=FATI\SQLEXPRESS;Initial Catalog=visualbasic_final;Integrated Security=True"

        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Courses"

        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(ds)

        cmbCourses.DataSource = ds.Tables(0)
        cmbCourses.ValueMember = "Id"
        cmbCourses.DisplayMember = "CourseName"
    End Sub

    Private Sub btnSaveGrade_Click(sender As Object, e As EventArgs) Handles btnSaveGrade.Click
        cmd.Parameters.Clear()
        cmd.CommandText = "Insert INTO Enrollment (StudentID, CourseID, Grade) Values (@StudentID, @CourseID, @Grade)"
        cmd.Parameters.Add(New SqlParameter("@StudentID", txtStudentID.Text))
        cmd.Parameters.Add(New SqlParameter("@CourseID", cmbCourses.SelectedValue))
        cmd.Parameters.Add(New SqlParameter("@Grade", cmbGrades.Text))
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Grade Registered Succssefully!")
        Catch ex As Exception
            con.Close()

        End Try
    End Sub


    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        Me.Close()

    End Sub
End Class