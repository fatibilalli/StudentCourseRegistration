<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchStudent))
        Me.grdStudent = New System.Windows.Forms.DataGridView()
        Me.lblSearchStudent = New System.Windows.Forms.Label()
        Me.txtSearchStudent = New System.Windows.Forms.TextBox()
        Me.btnEditStudent = New System.Windows.Forms.Button()
        Me.btnEnroll = New System.Windows.Forms.Button()
        CType(Me.grdStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdStudent
        '
        Me.grdStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.grdStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStudent.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdStudent.Location = New System.Drawing.Point(0, 68)
        Me.grdStudent.Name = "grdStudent"
        Me.grdStudent.Size = New System.Drawing.Size(561, 224)
        Me.grdStudent.TabIndex = 0
        '
        'lblSearchStudent
        '
        Me.lblSearchStudent.AutoSize = True
        Me.lblSearchStudent.Location = New System.Drawing.Point(12, 27)
        Me.lblSearchStudent.Name = "lblSearchStudent"
        Me.lblSearchStudent.Size = New System.Drawing.Size(81, 13)
        Me.lblSearchStudent.TabIndex = 1
        Me.lblSearchStudent.Text = "Search Student"
        '
        'txtSearchStudent
        '
        Me.txtSearchStudent.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearchStudent.Location = New System.Drawing.Point(99, 20)
        Me.txtSearchStudent.Name = "txtSearchStudent"
        Me.txtSearchStudent.Size = New System.Drawing.Size(195, 20)
        Me.txtSearchStudent.TabIndex = 2
        '
        'btnEditStudent
        '
        Me.btnEditStudent.Image = CType(resources.GetObject("btnEditStudent.Image"), System.Drawing.Image)
        Me.btnEditStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditStudent.Location = New System.Drawing.Point(300, 18)
        Me.btnEditStudent.Name = "btnEditStudent"
        Me.btnEditStudent.Size = New System.Drawing.Size(115, 23)
        Me.btnEditStudent.TabIndex = 3
        Me.btnEditStudent.Text = "  Edit Student"
        Me.btnEditStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditStudent.UseVisualStyleBackColor = True
        '
        'btnEnroll
        '
        Me.btnEnroll.Image = CType(resources.GetObject("btnEnroll.Image"), System.Drawing.Image)
        Me.btnEnroll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnroll.Location = New System.Drawing.Point(421, 20)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(116, 23)
        Me.btnEnroll.TabIndex = 4
        Me.btnEnroll.Text = "  Enroll Student"
        Me.btnEnroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnroll.UseVisualStyleBackColor = True
        '
        'frmSearchStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 292)
        Me.Controls.Add(Me.btnEnroll)
        Me.Controls.Add(Me.btnEditStudent)
        Me.Controls.Add(Me.txtSearchStudent)
        Me.Controls.Add(Me.lblSearchStudent)
        Me.Controls.Add(Me.grdStudent)
        Me.Name = "frmSearchStudent"
        Me.Text = "frmSearchStudent"
        CType(Me.grdStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdStudent As System.Windows.Forms.DataGridView
    Friend WithEvents lblSearchStudent As System.Windows.Forms.Label
    Friend WithEvents txtSearchStudent As System.Windows.Forms.TextBox
    Friend WithEvents btnEditStudent As System.Windows.Forms.Button
    Friend WithEvents btnEnroll As System.Windows.Forms.Button
End Class
