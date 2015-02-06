<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchCourse
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
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtSearchCourse = New System.Windows.Forms.TextBox()
        Me.grdSearchStudent = New System.Windows.Forms.DataGridView()
        CType(Me.grdSearchStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(27, 35)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(77, 13)
        Me.lblCourse.TabIndex = 0
        Me.lblCourse.Text = "Search Course"
        '
        'txtSearchCourse
        '
        Me.txtSearchCourse.Location = New System.Drawing.Point(110, 28)
        Me.txtSearchCourse.Name = "txtSearchCourse"
        Me.txtSearchCourse.Size = New System.Drawing.Size(271, 20)
        Me.txtSearchCourse.TabIndex = 1
        '
        'grdSearchStudent
        '
        Me.grdSearchStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSearchStudent.Location = New System.Drawing.Point(1, 71)
        Me.grdSearchStudent.Name = "grdSearchStudent"
        Me.grdSearchStudent.Size = New System.Drawing.Size(446, 262)
        Me.grdSearchStudent.TabIndex = 2
        '
        'frmSearchCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 334)
        Me.Controls.Add(Me.grdSearchStudent)
        Me.Controls.Add(Me.txtSearchCourse)
        Me.Controls.Add(Me.lblCourse)
        Me.Name = "frmSearchCourse"
        Me.Text = "frmSearchCourse"
        CType(Me.grdSearchStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents txtSearchCourse As System.Windows.Forms.TextBox
    Friend WithEvents grdSearchStudent As System.Windows.Forms.DataGridView
End Class
