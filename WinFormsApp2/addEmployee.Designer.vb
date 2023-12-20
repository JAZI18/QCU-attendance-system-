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
        status_lb = New Label()
        cam_pic_box = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1.SuspendLayout()
        CType(cam_pic_box, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' submit_employees_btn
        ' 
        submit_employees_btn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        submit_employees_btn.Dock = DockStyle.Bottom
        submit_employees_btn.FlatStyle = FlatStyle.Flat
        submit_employees_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        submit_employees_btn.ForeColor = SystemColors.ButtonHighlight
        submit_employees_btn.Location = New Point(0, 361)
        submit_employees_btn.Name = "submit_employees_btn"
        submit_employees_btn.Size = New Size(346, 56)
        submit_employees_btn.TabIndex = 30
        submit_employees_btn.Text = "Submit"
        submit_employees_btn.UseVisualStyleBackColor = False
        ' 
        ' e_dep
        ' 
        TableLayoutPanel1.SetColumnSpan(e_dep, 3)
        e_dep.Dock = DockStyle.Fill
        e_dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_dep.FormattingEnabled = True
        e_dep.Location = New Point(119, 369)
        e_dep.Margin = New Padding(84, 3, 84, 3)
        e_dep.Name = "e_dep"
        e_dep.Size = New Size(284, 29)
        e_dep.TabIndex = 29
        ' 
        ' dep
        ' 
        dep.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(dep, 3)
        dep.Dock = DockStyle.Fill
        dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dep.Location = New Point(38, 318)
        dep.Name = "dep"
        dep.Size = New Size(446, 48)
        dep.TabIndex = 28
        dep.Text = "Department"
        dep.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' e
        ' 
        e.AutoSize = True
        e.Dock = DockStyle.Fill
        e.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e.Location = New Point(292, 30)
        e.Name = "e"
        e.Size = New Size(192, 48)
        e.TabIndex = 27
        e.Text = "Email"
        e.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' e_email
        ' 
        e_email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_email.Location = New Point(292, 81)
        e_email.Name = "e_email"
        e_email.Size = New Size(192, 29)
        e_email.TabIndex = 26
        ' 
        ' e_lastname
        ' 
        e_lastname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_lastname.Location = New Point(38, 273)
        e_lastname.Name = "e_lastname"
        e_lastname.Size = New Size(190, 29)
        e_lastname.TabIndex = 18
        ' 
        ' e_middlename
        ' 
        e_middlename.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_middlename.Location = New Point(38, 177)
        e_middlename.Name = "e_middlename"
        e_middlename.Size = New Size(185, 29)
        e_middlename.TabIndex = 17
        ' 
        ' e_firstname
        ' 
        e_firstname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_firstname.Location = New Point(38, 81)
        e_firstname.Name = "e_firstname"
        e_firstname.Size = New Size(190, 29)
        e_firstname.TabIndex = 16
        ' 
        ' d
        ' 
        d.AutoSize = True
        d.Dock = DockStyle.Fill
        d.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        d.Location = New Point(292, 222)
        d.Name = "d"
        d.Size = New Size(192, 48)
        d.TabIndex = 25
        d.Text = "Dob"
        d.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' e_gender
        ' 
        e_gender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_gender.FormattingEnabled = True
        e_gender.Items.AddRange(New Object() {"Male", "Female", "Binary", "Non-Binary", "Optimus Prime", "World Ender", "Others"})
        e_gender.Location = New Point(292, 177)
        e_gender.Name = "e_gender"
        e_gender.Size = New Size(192, 29)
        e_gender.TabIndex = 24
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Dock = DockStyle.Fill
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(292, 126)
        Label17.Name = "Label17"
        Label17.Size = New Size(192, 48)
        Label17.TabIndex = 23
        Label17.Text = "Gender"
        Label17.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' l
        ' 
        l.AutoSize = True
        l.Dock = DockStyle.Fill
        l.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        l.Location = New Point(38, 222)
        l.Name = "l"
        l.Size = New Size(190, 48)
        l.TabIndex = 22
        l.Text = "Last name"
        l.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' m
        ' 
        m.AutoSize = True
        m.Dock = DockStyle.Fill
        m.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        m.Location = New Point(38, 126)
        m.Name = "m"
        m.Size = New Size(190, 48)
        m.TabIndex = 21
        m.Text = "Middle name"
        m.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Dock = DockStyle.Fill
        f.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        f.Location = New Point(38, 30)
        f.Name = "f"
        f.Size = New Size(190, 48)
        f.TabIndex = 19
        f.Text = "First name"
        f.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' e_date
        ' 
        e_date.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date.Location = New Point(292, 273)
        e_date.Name = "e_date"
        e_date.Size = New Size(191, 29)
        e_date.TabIndex = 20
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(134), CByte(134), CByte(134))
        Panel1.Controls.Add(status_lb)
        Panel1.Controls.Add(submit_employees_btn)
        Panel1.Controls.Add(cam_pic_box)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(522, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(346, 417)
        Panel1.TabIndex = 31
        ' 
        ' status_lb
        ' 
        status_lb.Dock = DockStyle.Bottom
        status_lb.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        status_lb.ForeColor = Color.Lime
        status_lb.Location = New Point(0, 311)
        status_lb.Name = "status_lb"
        status_lb.Size = New Size(346, 50)
        status_lb.TabIndex = 33
        status_lb.Text = "READY"
        status_lb.TextAlign = ContentAlignment.TopCenter
        ' 
        ' cam_pic_box
        ' 
        cam_pic_box.BackColor = Color.White
        cam_pic_box.BorderStyle = BorderStyle.FixedSingle
        cam_pic_box.Image = My.Resources.Resources.user
        cam_pic_box.Location = New Point(11, 24)
        cam_pic_box.Name = "cam_pic_box"
        cam_pic_box.Padding = New Padding(7, 6, 7, 6)
        cam_pic_box.Size = New Size(327, 264)
        cam_pic_box.SizeMode = PictureBoxSizeMode.Zoom
        cam_pic_box.TabIndex = 32
        cam_pic_box.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 43.47826F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.043478F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 43.47826F))
        TableLayoutPanel1.Controls.Add(f, 0, 0)
        TableLayoutPanel1.Controls.Add(e_firstname, 0, 1)
        TableLayoutPanel1.Controls.Add(e_date, 2, 5)
        TableLayoutPanel1.Controls.Add(e_lastname, 0, 5)
        TableLayoutPanel1.Controls.Add(e_email, 2, 1)
        TableLayoutPanel1.Controls.Add(e_gender, 2, 3)
        TableLayoutPanel1.Controls.Add(m, 0, 2)
        TableLayoutPanel1.Controls.Add(e_middlename, 0, 3)
        TableLayoutPanel1.Controls.Add(l, 0, 4)
        TableLayoutPanel1.Controls.Add(e, 2, 0)
        TableLayoutPanel1.Controls.Add(Label17, 2, 2)
        TableLayoutPanel1.Controls.Add(d, 2, 4)
        TableLayoutPanel1.Controls.Add(dep, 0, 6)
        TableLayoutPanel1.Controls.Add(e_dep, 0, 7)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(2, 30, 2, 2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(35, 30, 35, 0)
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 12F))
        TableLayoutPanel1.Size = New Size(522, 417)
        TableLayoutPanel1.TabIndex = 32
        ' 
        ' addEmployee
        ' 
        AcceptButton = submit_employees_btn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(223), CByte(223), CByte(223))
        ClientSize = New Size(868, 417)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(2)
        Name = "addEmployee"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        CType(cam_pic_box, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents cam_pic_box As PictureBox
    Friend WithEvents status_lb As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
