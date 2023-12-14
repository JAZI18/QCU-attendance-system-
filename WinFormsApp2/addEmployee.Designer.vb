<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addEmployee
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
        submit_employees_btn = New Button()
        e_dep = New ComboBox()
        dep = New Label()
        e = New Label()
        e_email = New TextBox()
        e_lastname = New TextBox()
        e_middlename = New TextBox()
        e_firstname = New TextBox()
        d = New Label()
        e_gender = New ComboBox()
        Label17 = New Label()
        l = New Label()
        m = New Label()
        f = New Label()
        e_date = New DateTimePicker()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' submit_employees_btn
        ' 
        submit_employees_btn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        submit_employees_btn.FlatStyle = FlatStyle.Flat
        submit_employees_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        submit_employees_btn.ForeColor = SystemColors.ButtonHighlight
        submit_employees_btn.Location = New Point(545, 448)
        submit_employees_btn.Name = "submit_employees_btn"
        submit_employees_btn.Size = New Size(118, 43)
        submit_employees_btn.TabIndex = 30
        submit_employees_btn.Text = "Submit"
        submit_employees_btn.UseVisualStyleBackColor = False
        ' 
        ' e_dep
        ' 
        e_dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_dep.FormattingEnabled = True
        e_dep.Location = New Point(394, 380)
        e_dep.Name = "e_dep"
        e_dep.Size = New Size(194, 29)
        e_dep.TabIndex = 29
        ' 
        ' dep
        ' 
        dep.AutoSize = True
        dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dep.Location = New Point(394, 359)
        dep.Name = "dep"
        dep.Size = New Size(93, 21)
        dep.TabIndex = 28
        dep.Text = "Department"
        ' 
        ' e
        ' 
        e.AutoSize = True
        e.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e.Location = New Point(615, 166)
        e.Name = "e"
        e.Size = New Size(48, 21)
        e.TabIndex = 27
        e.Text = "Email"
        ' 
        ' e_email
        ' 
        e_email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_email.Location = New Point(612, 187)
        e_email.Name = "e_email"
        e_email.Size = New Size(206, 29)
        e_email.TabIndex = 26
        ' 
        ' e_lastname
        ' 
        e_lastname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_lastname.Location = New Point(391, 187)
        e_lastname.Name = "e_lastname"
        e_lastname.Size = New Size(194, 29)
        e_lastname.TabIndex = 18
        ' 
        ' e_middlename
        ' 
        e_middlename.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_middlename.Location = New Point(612, 93)
        e_middlename.Name = "e_middlename"
        e_middlename.Size = New Size(206, 29)
        e_middlename.TabIndex = 17
        ' 
        ' e_firstname
        ' 
        e_firstname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_firstname.Location = New Point(391, 93)
        e_firstname.Name = "e_firstname"
        e_firstname.Size = New Size(194, 29)
        e_firstname.TabIndex = 16
        ' 
        ' d
        ' 
        d.AutoSize = True
        d.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        d.Location = New Point(397, 264)
        d.Name = "d"
        d.Size = New Size(39, 21)
        d.TabIndex = 25
        d.Text = "Dob"
        ' 
        ' e_gender
        ' 
        e_gender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_gender.FormattingEnabled = True
        e_gender.Items.AddRange(New Object() {"Male", "Female", "Binary", "Non-Binary", "Optimus Prime", "World Ender", "Others"})
        e_gender.Location = New Point(612, 285)
        e_gender.Name = "e_gender"
        e_gender.Size = New Size(206, 29)
        e_gender.TabIndex = 24
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(615, 264)
        Label17.Name = "Label17"
        Label17.Size = New Size(61, 21)
        Label17.TabIndex = 23
        Label17.Text = "Gender"
        ' 
        ' l
        ' 
        l.AutoSize = True
        l.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        l.Location = New Point(394, 166)
        l.Name = "l"
        l.Size = New Size(81, 21)
        l.TabIndex = 22
        l.Text = "Last name"
        ' 
        ' m
        ' 
        m.AutoSize = True
        m.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        m.Location = New Point(615, 72)
        m.Name = "m"
        m.Size = New Size(101, 21)
        m.TabIndex = 21
        m.Text = "Middle name"
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        f.Location = New Point(394, 72)
        f.Name = "f"
        f.Size = New Size(83, 21)
        f.TabIndex = 19
        f.Text = "First name"
        ' 
        ' e_date
        ' 
        e_date.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date.Location = New Point(394, 285)
        e_date.Name = "e_date"
        e_date.Size = New Size(191, 29)
        e_date.TabIndex = 20
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(134), CByte(134), CByte(134))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(351, 519)
        Panel1.TabIndex = 31
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Lime
        Label1.Location = New Point(140, 290)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 25)
        Label1.TabIndex = 33
        Label1.Text = "Label1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        PictureBox1.Location = New Point(11, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(328, 239)
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' addEmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(223), CByte(223), CByte(223))
        ClientSize = New Size(868, 512)
        Controls.Add(Panel1)
        Controls.Add(submit_employees_btn)
        Controls.Add(e_dep)
        Controls.Add(dep)
        Controls.Add(e)
        Controls.Add(e_email)
        Controls.Add(e_lastname)
        Controls.Add(e_middlename)
        Controls.Add(e_firstname)
        Controls.Add(d)
        Controls.Add(e_gender)
        Controls.Add(Label17)
        Controls.Add(l)
        Controls.Add(m)
        Controls.Add(f)
        Controls.Add(e_date)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(2)
        Name = "addEmployee"
        StartPosition = FormStartPosition.CenterParent
        Text = "addEmployee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents submit_employees_btn As Button
    Friend WithEvents e_dep As ComboBox
    Friend WithEvents dep As Label
    Friend WithEvents e As Label
    Friend WithEvents e_email As TextBox
    Friend WithEvents e_lastname As TextBox
    Friend WithEvents e_middlename As TextBox
    Friend WithEvents e_firstname As TextBox
    Friend WithEvents d As Label
    Friend WithEvents e_gender As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents l As Label
    Friend WithEvents m As Label
    Friend WithEvents f As Label
    Friend WithEvents e_date As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
