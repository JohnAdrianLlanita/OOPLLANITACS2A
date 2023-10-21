<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.txtcourse = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtuserID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCourseSearch = New System.Windows.Forms.TextBox()
        Me.txtLNameSearch = New System.Windows.Forms.TextBox()
        Me.txtFNameSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btninsert)
        Me.GroupBox1.Controls.Add(Me.txtcourse)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(75, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 286)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insert Record"
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(91, 200)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(93, 45)
        Me.btninsert.TabIndex = 1
        Me.btninsert.Text = "Insert Record"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'txtcourse
        '
        Me.txtcourse.Location = New System.Drawing.Point(107, 139)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.Size = New System.Drawing.Size(111, 20)
        Me.txtcourse.TabIndex = 5
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(107, 92)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(111, 20)
        Me.txtlname.TabIndex = 4
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(107, 48)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(111, 20)
        Me.txtfname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LastName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FirstName"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtuserID)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtCourseSearch)
        Me.GroupBox2.Controls.Add(Me.txtLNameSearch)
        Me.GroupBox2.Controls.Add(Me.txtFNameSearch)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(559, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 286)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Record"
        '
        'txtuserID
        '
        Me.txtuserID.Location = New System.Drawing.Point(107, 19)
        Me.txtuserID.Name = "txtuserID"
        Me.txtuserID.Size = New System.Drawing.Size(111, 20)
        Me.txtuserID.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Student ID"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(91, 200)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 45)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search Record"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtCourseSearch
        '
        Me.txtCourseSearch.Location = New System.Drawing.Point(107, 139)
        Me.txtCourseSearch.Name = "txtCourseSearch"
        Me.txtCourseSearch.Size = New System.Drawing.Size(111, 20)
        Me.txtCourseSearch.TabIndex = 5
        '
        'txtLNameSearch
        '
        Me.txtLNameSearch.Location = New System.Drawing.Point(107, 92)
        Me.txtLNameSearch.Name = "txtLNameSearch"
        Me.txtLNameSearch.Size = New System.Drawing.Size(111, 20)
        Me.txtLNameSearch.TabIndex = 4
        '
        'txtFNameSearch
        '
        Me.txtFNameSearch.Location = New System.Drawing.Point(107, 48)
        Me.txtFNameSearch.Name = "txtFNameSearch"
        Me.txtFNameSearch.Size = New System.Drawing.Size(111, 20)
        Me.txtFNameSearch.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Course"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "LastName"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "FirstName"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(263, 370)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(114, 40)
        Me.btndisplay.TabIndex = 2
        Me.btndisplay.Text = "Display by Course"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1038, 461)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btninsert As Button
    Friend WithEvents txtcourse As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCourseSearch As TextBox
    Friend WithEvents txtLNameSearch As TextBox
    Friend WithEvents txtFNameSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtuserID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btndisplay As Button
End Class
