<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comProfile = New System.Windows.Forms.ComboBox()
        Me.comStudent = New System.Windows.Forms.ComboBox()
        Me.comCourse = New System.Windows.Forms.ComboBox()
        Me.comTable = New System.Windows.Forms.ComboBox()
        Me.txtID1 = New System.Windows.Forms.TextBox()
        Me.txtNewVal = New System.Windows.Forms.TextBox()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogOut.Location = New System.Drawing.Point(165, 390)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(97, 49)
        Me.btnLogOut.TabIndex = 28
        Me.btnLogOut.Text = "Log out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter new value here"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.comProfile)
        Me.GroupBox1.Controls.Add(Me.comStudent)
        Me.GroupBox1.Controls.Add(Me.comCourse)
        Me.GroupBox1.Controls.Add(Me.comTable)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtID1)
        Me.GroupBox1.Controls.Add(Me.txtNewVal)
        Me.GroupBox1.Location = New System.Drawing.Point(165, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 241)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Select Table and column for update"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(203, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Enter"
        '
        'comProfile
        '
        Me.comProfile.FormattingEnabled = True
        Me.comProfile.Items.AddRange(New Object() {"Student_ID", "Course_code", "Fee_paid"})
        Me.comProfile.Location = New System.Drawing.Point(333, 62)
        Me.comProfile.Name = "comProfile"
        Me.comProfile.Size = New System.Drawing.Size(151, 24)
        Me.comProfile.TabIndex = 5
        '
        'comStudent
        '
        Me.comStudent.FormattingEnabled = True
        Me.comStudent.Items.AddRange(New Object() {"Student_ID", "Last_name", "First_name", "Date_of_Birth", "Gender", "Concession"})
        Me.comStudent.Location = New System.Drawing.Point(333, 62)
        Me.comStudent.Name = "comStudent"
        Me.comStudent.Size = New System.Drawing.Size(151, 24)
        Me.comStudent.TabIndex = 5
        '
        'comCourse
        '
        Me.comCourse.FormattingEnabled = True
        Me.comCourse.Items.AddRange(New Object() {"Course_code", "Subject", "Depaartment", "Level", "Fee", "Duration_week"})
        Me.comCourse.Location = New System.Drawing.Point(333, 62)
        Me.comCourse.Name = "comCourse"
        Me.comCourse.Size = New System.Drawing.Size(151, 24)
        Me.comCourse.TabIndex = 5
        '
        'comTable
        '
        Me.comTable.FormattingEnabled = True
        Me.comTable.Items.AddRange(New Object() {"Course", "Profile", "Student"})
        Me.comTable.Location = New System.Drawing.Point(135, 62)
        Me.comTable.Name = "comTable"
        Me.comTable.Size = New System.Drawing.Size(151, 24)
        Me.comTable.TabIndex = 5
        '
        'txtID1
        '
        Me.txtID1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.txtID1.Location = New System.Drawing.Point(220, 145)
        Me.txtID1.Name = "txtID1"
        Me.txtID1.Size = New System.Drawing.Size(151, 21)
        Me.txtID1.TabIndex = 0
        '
        'txtNewVal
        '
        Me.txtNewVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.txtNewVal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNewVal.Location = New System.Drawing.Point(428, 201)
        Me.txtNewVal.Name = "txtNewVal"
        Me.txtNewVal.Size = New System.Drawing.Size(180, 21)
        Me.txtNewVal.TabIndex = 0
        '
        'btnCourse
        '
        Me.btnCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCourse.Location = New System.Drawing.Point(45, 270)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Size = New System.Drawing.Size(114, 59)
        Me.btnCourse.TabIndex = 24
        Me.btnCourse.Text = "Course"
        Me.btnCourse.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudent.Location = New System.Drawing.Point(45, 205)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(114, 59)
        Me.btnStudent.TabIndex = 25
        Me.btnStudent.Text = "Student"
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProfile.Location = New System.Drawing.Point(45, 143)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(114, 59)
        Me.btnProfile.TabIndex = 26
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(531, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "School Management System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 82)
        Me.Panel1.TabIndex = 23
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUp.Location = New System.Drawing.Point(691, 390)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(97, 49)
        Me.btnUp.TabIndex = 21
        Me.btnUp.Text = "Update"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Location = New System.Drawing.Point(570, 390)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 49)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(45, 333)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(114, 51)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "Update data"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCourse)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogOut As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNewVal As TextBox
    Friend WithEvents btnCourse As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUp As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents comCourse As ComboBox
    Friend WithEvents comTable As ComboBox
    Friend WithEvents comProfile As ComboBox
    Friend WithEvents comStudent As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID1 As TextBox
    Friend WithEvents Label3 As Label
End Class
