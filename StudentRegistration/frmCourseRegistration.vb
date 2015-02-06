Imports System.Data.SqlClient

Public Class frmCourseRegistration
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub frmCourseRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Visualbasic_finalDataSet1.Courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.Visualbasic_finalDataSet1.Courses)
        'TODO: This line of code loads data into the 'Visualbasic_finalDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.Visualbasic_finalDataSet.Students)

    End Sub

    Private Sub cmbSelectStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectStudent.SelectedIndexChanged
        Dim con As New SqlConnection
        con.ConnectionString = "Server=FATI\SQLEXPRESS;Database=visualbasic_final;Trusted_Connection=True;"

        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Students"

        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(ds)

        cmbSelectStudent.DataSource = ds.Tables(0)
        cmbSelectStudent.ValueMember = "Id"
        cmbSelectStudent.DisplayMember = "Firstname"
    End Sub

    Private Sub cmbSelectCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectCourse.SelectedIndexChanged
        Dim con As New SqlConnection
        con.ConnectionString = "Server=FATI\SQLEXPRESS;Database=visualbasic_final;Trusted_Connection=True;"

        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Courses"

        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(ds)

        cmbSelectCourse.DataSource = ds.Tables(0)
        cmbSelectCourse.ValueMember = "Id"
        cmbSelectCourse.DisplayMember = "CourseName"

    End Sub

    Private Sub btnSaveRegistration_Click(sender As Object, e As EventArgs) Handles btnSaveRegistration.Click
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=FATI\SQLEXPRESS;Initial Catalog=visualbasic_final;Integrated Security=True"

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "Insert INTO Enrollment (StudentID, CourseID, ) Values (@StudentID, @CourseId,)"

        cmd.Parameters.Add(New SqlParameter("@StudendID", cmbSelectStudent.Text))
        cmd.Parameters.Add(New SqlParameter("@CourseID", cmbSelectCourse.Text))

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()

        End Try
    End Sub
End Class