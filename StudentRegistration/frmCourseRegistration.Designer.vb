<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourseRegistration
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
        Me.components = New System.ComponentModel.Container()
        Me.lblSelectStudent = New System.Windows.Forms.Label()
        Me.cmbSelectStudent = New System.Windows.Forms.ComboBox()
        Me.cmbSelectCourse = New System.Windows.Forms.ComboBox()
        Me.lblSelectCourse = New System.Windows.Forms.Label()
        Me.btnSaveRegistration = New System.Windows.Forms.Button()
        Me.Visualbasic_finalDataSet = New StudentRegistration.visualbasic_finalDataSet()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter = New StudentRegistration.visualbasic_finalDataSetTableAdapters.StudentsTableAdapter()
        Me.Visualbasic_finalDataSet1 = New StudentRegistration.visualbasic_finalDataSet1()
        Me.CoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoursesTableAdapter = New StudentRegistration.visualbasic_finalDataSet1TableAdapters.CoursesTableAdapter()
        CType(Me.Visualbasic_finalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visualbasic_finalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectStudent
        '
        Me.lblSelectStudent.AutoSize = True
        Me.lblSelectStudent.Location = New System.Drawing.Point(8, 22)
        Me.lblSelectStudent.Name = "lblSelectStudent"
        Me.lblSelectStudent.Size = New System.Drawing.Size(77, 13)
        Me.lblSelectStudent.TabIndex = 0
        Me.lblSelectStudent.Text = "Select Student"
        '
        'cmbSelectStudent
        '
        Me.cmbSelectStudent.DataSource = Me.StudentsBindingSource
        Me.cmbSelectStudent.DisplayMember = "Firstname"
        Me.cmbSelectStudent.FormattingEnabled = True
        Me.cmbSelectStudent.Location = New System.Drawing.Point(91, 14)
        Me.cmbSelectStudent.Name = "cmbSelectStudent"
        Me.cmbSelectStudent.Size = New System.Drawing.Size(165, 21)
        Me.cmbSelectStudent.TabIndex = 1
        '
        'cmbSelectCourse
        '
        Me.cmbSelectCourse.DataSource = Me.CoursesBindingSource
        Me.cmbSelectCourse.DisplayMember = "CourseName"
        Me.cmbSelectCourse.FormattingEnabled = True
        Me.cmbSelectCourse.Location = New System.Drawing.Point(95, 63)
        Me.cmbSelectCourse.Name = "cmbSelectCourse"
        Me.cmbSelectCourse.Size = New System.Drawing.Size(165, 21)
        Me.cmbSelectCourse.TabIndex = 3
        '
        'lblSelectCourse
        '
        Me.lblSelectCourse.AutoSize = True
        Me.lblSelectCourse.Location = New System.Drawing.Point(12, 71)
        Me.lblSelectCourse.Name = "lblSelectCourse"
        Me.lblSelectCourse.Size = New System.Drawing.Size(73, 13)
        Me.lblSelectCourse.TabIndex = 2
        Me.lblSelectCourse.Text = "Select Course"
        '
        'btnSaveRegistration
        '
        Me.btnSaveRegistration.Location = New System.Drawing.Point(144, 120)
        Me.btnSaveRegistration.Name = "btnSaveRegistration"
        Me.btnSaveRegistration.Size = New System.Drawing.Size(112, 23)
        Me.btnSaveRegistration.TabIndex = 4
        Me.btnSaveRegistration.Text = "SaveRegistration"
        Me.btnSaveRegistration.UseVisualStyleBackColor = True
        '
        'Visualbasic_finalDataSet
        '
        Me.Visualbasic_finalDataSet.DataSetName = "visualbasic_finalDataSet"
        Me.Visualbasic_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.Visualbasic_finalDataSet
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'Visualbasic_finalDataSet1
        '
        Me.Visualbasic_finalDataSet1.DataSetName = "visualbasic_finalDataSet1"
        Me.Visualbasic_finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CoursesBindingSource
        '
        Me.CoursesBindingSource.DataMember = "Courses"
        Me.CoursesBindingSource.DataSource = Me.Visualbasic_finalDataSet1
        '
        'CoursesTableAdapter
        '
        Me.CoursesTableAdapter.ClearBeforeFill = True
        '
        'frmCourseRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnSaveRegistration)
        Me.Controls.Add(Me.cmbSelectCourse)
        Me.Controls.Add(Me.lblSelectCourse)
        Me.Controls.Add(Me.cmbSelectStudent)
        Me.Controls.Add(Me.lblSelectStudent)
        Me.Name = "frmCourseRegistration"
        Me.Text = "frmCourseRegistration"
        CType(Me.Visualbasic_finalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visualbasic_finalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectStudent As System.Windows.Forms.Label
    Friend WithEvents cmbSelectStudent As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSelectCourse As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectCourse As System.Windows.Forms.Label
    Friend WithEvents btnSaveRegistration As System.Windows.Forms.Button
    Friend WithEvents Visualbasic_finalDataSet As StudentRegistration.visualbasic_finalDataSet
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsTableAdapter As StudentRegistration.visualbasic_finalDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents Visualbasic_finalDataSet1 As StudentRegistration.visualbasic_finalDataSet1
    Friend WithEvents CoursesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CoursesTableAdapter As StudentRegistration.visualbasic_finalDataSet1TableAdapters.CoursesTableAdapter
End Class
