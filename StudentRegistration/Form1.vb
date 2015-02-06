Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Dim F As New frmRegisterStudent()
        F.ShowDialog()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Dim f As New frmSearchStudent
        f.ShowDialog()

    End Sub

    Private Sub TranscriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TranscriptToolStripMenuItem.Click
        Dim f As New frmTranscript
        f.ShowDialog()

    End Sub

    Private Sub SearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem1.Click
        Dim f As New frmSearchCourse
        f.ShowDialog()

    End Sub

    Private Sub RegisterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem1.Click
        Dim f As New frmCourseRegistration
        f.ShowDialog()

    End Sub
End Class
