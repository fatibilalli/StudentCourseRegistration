<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTranscript
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
        Me.lblSelectStudent = New System.Windows.Forms.Label()
        Me.cmbSelectStudent = New System.Windows.Forms.ComboBox()
        Me.grdTranscript = New System.Windows.Forms.DataGridView()
        Me.btnLoadTranscript = New System.Windows.Forms.Button()
        CType(Me.grdTranscript, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectStudent
        '
        Me.lblSelectStudent.AutoSize = True
        Me.lblSelectStudent.Location = New System.Drawing.Point(12, 17)
        Me.lblSelectStudent.Name = "lblSelectStudent"
        Me.lblSelectStudent.Size = New System.Drawing.Size(77, 13)
        Me.lblSelectStudent.TabIndex = 0
        Me.lblSelectStudent.Text = "Select Student"
        '
        'cmbSelectStudent
        '
        Me.cmbSelectStudent.FormattingEnabled = True
        Me.cmbSelectStudent.Location = New System.Drawing.Point(95, 12)
        Me.cmbSelectStudent.Name = "cmbSelectStudent"
        Me.cmbSelectStudent.Size = New System.Drawing.Size(189, 21)
        Me.cmbSelectStudent.TabIndex = 1
        '
        'grdTranscript
        '
        Me.grdTranscript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTranscript.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdTranscript.Location = New System.Drawing.Point(0, 66)
        Me.grdTranscript.Name = "grdTranscript"
        Me.grdTranscript.Size = New System.Drawing.Size(486, 241)
        Me.grdTranscript.TabIndex = 2
        '
        'btnLoadTranscript
        '
        Me.btnLoadTranscript.Location = New System.Drawing.Point(311, 12)
        Me.btnLoadTranscript.Name = "btnLoadTranscript"
        Me.btnLoadTranscript.Size = New System.Drawing.Size(123, 23)
        Me.btnLoadTranscript.TabIndex = 3
        Me.btnLoadTranscript.Text = "Load Transcript"
        Me.btnLoadTranscript.UseVisualStyleBackColor = True
        '
        'frmTranscript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 307)
        Me.Controls.Add(Me.btnLoadTranscript)
        Me.Controls.Add(Me.grdTranscript)
        Me.Controls.Add(Me.cmbSelectStudent)
        Me.Controls.Add(Me.lblSelectStudent)
        Me.Name = "frmTranscript"
        Me.Text = "frmTranscript"
        CType(Me.grdTranscript, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectStudent As System.Windows.Forms.Label
    Friend WithEvents cmbSelectStudent As System.Windows.Forms.ComboBox
    Friend WithEvents grdTranscript As System.Windows.Forms.DataGridView
    Friend WithEvents btnLoadTranscript As System.Windows.Forms.Button
End Class
