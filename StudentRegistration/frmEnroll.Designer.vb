<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblCourses = New System.Windows.Forms.Label()
        Me.cmbCourses = New System.Windows.Forms.ComboBox()
        Me.lblGrades = New System.Windows.Forms.Label()
        Me.cmbGrades = New System.Windows.Forms.ComboBox()
        Me.btnSaveGrade = New System.Windows.Forms.Button()
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(12, 22)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(58, 13)
        Me.lblStudentID.TabIndex = 0
        Me.lblStudentID.Text = "Student ID"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(76, 22)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(59, 20)
        Me.txtStudentID.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(218, 22)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(132, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(155, 29)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(420, 22)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(163, 20)
        Me.txtLastName.TabIndex = 5
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(356, 29)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name"
        '
        'lblCourses
        '
        Me.lblCourses.AutoSize = True
        Me.lblCourses.Location = New System.Drawing.Point(17, 59)
        Me.lblCourses.Name = "lblCourses"
        Me.lblCourses.Size = New System.Drawing.Size(45, 13)
        Me.lblCourses.TabIndex = 6
        Me.lblCourses.Text = "Courses"
        '
        'cmbCourses
        '
        Me.cmbCourses.FormattingEnabled = True
        Me.cmbCourses.Location = New System.Drawing.Point(81, 59)
        Me.cmbCourses.Name = "cmbCourses"
        Me.cmbCourses.Size = New System.Drawing.Size(333, 21)
        Me.cmbCourses.TabIndex = 7
        '
        'lblGrades
        '
        Me.lblGrades.AutoSize = True
        Me.lblGrades.Location = New System.Drawing.Point(429, 67)
        Me.lblGrades.Name = "lblGrades"
        Me.lblGrades.Size = New System.Drawing.Size(41, 13)
        Me.lblGrades.TabIndex = 8
        Me.lblGrades.Text = "Grades"
        '
        'cmbGrades
        '
        Me.cmbGrades.FormattingEnabled = True
        Me.cmbGrades.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "NR"})
        Me.cmbGrades.Location = New System.Drawing.Point(476, 64)
        Me.cmbGrades.Name = "cmbGrades"
        Me.cmbGrades.Size = New System.Drawing.Size(59, 21)
        Me.cmbGrades.TabIndex = 9
        '
        'btnSaveGrade
        '
        Me.btnSaveGrade.Location = New System.Drawing.Point(297, 104)
        Me.btnSaveGrade.Name = "btnSaveGrade"
        Me.btnSaveGrade.Size = New System.Drawing.Size(173, 23)
        Me.btnSaveGrade.TabIndex = 10
        Me.btnSaveGrade.Text = "Save Grade"
        Me.btnSaveGrade.UseVisualStyleBackColor = True
        '
        'btnCancle
        '
        Me.btnCancle.Location = New System.Drawing.Point(476, 104)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(107, 23)
        Me.btnCancle.TabIndex = 11
        Me.btnCancle.Text = "Cancle"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'frmEnroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 244)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnSaveGrade)
        Me.Controls.Add(Me.cmbGrades)
        Me.Controls.Add(Me.lblGrades)
        Me.Controls.Add(Me.cmbCourses)
        Me.Controls.Add(Me.lblCourses)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.lblStudentID)
        Me.Name = "frmEnroll"
        Me.Text = "frmEnroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblCourses As System.Windows.Forms.Label
    Friend WithEvents cmbCourses As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrades As System.Windows.Forms.Label
    Friend WithEvents cmbGrades As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveGrade As System.Windows.Forms.Button
    Friend WithEvents btnCancle As System.Windows.Forms.Button
End Class
