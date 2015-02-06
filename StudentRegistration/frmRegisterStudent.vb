Imports System.Data.SqlClient

Public Class frmRegisterStudent

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=FATI\SQLEXPRESS;Initial Catalog=visualbasic_final;Integrated Security=True"

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "Insert INTO STUDENTS (Firstname, Lastname, Gender) Values (@Firstname, @Lastname, @Gender)"

        cmd.Parameters.Add(New SqlParameter("@Firstname", txtFirstName.Text))
        cmd.Parameters.Add(New SqlParameter("@Lastname", txtLastName.Text))

        If rdbMale.Checked Then
            cmd.Parameters.Add(New SqlParameter("@Gender", "M"))
        Else
            cmd.Parameters.Add(New SqlParameter("@Gender", "F"))
        End If

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()

        End Try
    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        Me.Close()

    End Sub
End Class