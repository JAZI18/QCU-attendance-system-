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
        submit_employees_btn.Location = New Point(0, 601)
        submit_employees_btn.Margin = New Padding(4, 5, 4, 5)
        submit_employees_btn.Name = "submit_employees_btn"
        submit_employees_btn.Size = New Size(495, 94)
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
        e_dep.Location = New Point(170, 615)
        e_dep.Margin = New Padding(120, 5, 120, 5)
        e_dep.Name = "e_dep"
        e_dep.Size = New Size(405, 40)
        e_dep.TabIndex = 29
        ' 
        ' dep
        ' 
        dep.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(dep, 3)
        dep.Dock = DockStyle.Fill
        dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dep.Location = New Point(54, 530)
        dep.Margin = New Padding(4, 0, 4, 0)
        dep.Name = "dep"
        dep.Size = New Size(637, 80)
        dep.TabIndex = 28
        dep.Text = "Department"
        dep.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' e
        ' 
        e.AutoSize = True
        e.Dock = DockStyle.Fill
        e.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e.Location = New Point(418, 50)
        e.Margin = New Padding(4, 0, 4, 0)
        e.Name = "e"
        e.Size = New Size(273, 80)
        e.TabIndex = 27
        e.Text = "Email"
        e.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' e_email
        ' 
        e_email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_email.Location = New Point(418, 135)
        e_email.Margin = New Padding(4, 5, 4, 5)
        e_email.Name = "e_email"
        e_email.Size = New Size(273, 39)
        e_email.TabIndex = 26
        ' 
        ' e_lastname
        ' 
        e_lastname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_lastname.Location = New Point(54, 455)
        e_lastname.Margin = New Padding(4, 5, 4, 5)
        e_lastname.Name = "e_lastname"
        e_lastname.Size = New Size(272, 39)
        e_lastname.TabIndex = 18
        ' 
        ' e_middlename
        ' 
        e_middlename.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_middlename.Location = New Point(54, 295)
        e_middlename.Margin = New Padding(4, 5, 4, 5)
        e_middlename.Name = "e_middlename"
        e_middlename.Size = New Size(262, 39)
        e_middlename.TabIndex = 17
        ' 
        ' e_firstname
        ' 
        e_firstname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_firstname.Location = New Point(54, 135)
        e_firstname.Margin = New Padding(4, 5, 4, 5)
        e_firstname.Name = "e_firstname"
        e_firstname.Size = New Size(272, 39)
        e_firstname.TabIndex = 16
        ' 
        ' d
        ' 
        d.AutoSize = True
        d.Dock = DockStyle.Fill
        d.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        d.Location = New Point(418, 370)
        d.Margin = New Padding(4, 0, 4, 0)
        d.Name = "d"
        d.Size = New Size(273, 80)
        d.TabIndex = 25
        d.Text = "Dob"
        d.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' e_gender
        ' 
        e_gender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_gender.FormattingEnabled = True
        e_gender.Items.AddRange(New Object() {"Male", "Female", "Binary", "Non-Binary", "Optimus Prime", "World Ender", "Others"})
        e_gender.Location = New Point(418, 295)
        e_gender.Margin = New Padding(4, 5, 4, 5)
        e_gender.Name = "e_gender"
        e_gender.Size = New Size(273, 40)
        e_gender.TabIndex = 24
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Dock = DockStyle.Fill
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(418, 210)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(273, 80)
        Label17.TabIndex = 23
        Label17.Text = "Gender"
        Label17.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' l
        ' 
        l.AutoSize = True
        l.Dock = DockStyle.Fill
        l.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        l.Location = New Point(54, 370)
        l.Margin = New Padding(4, 0, 4, 0)
        l.Name = "l"
        l.Size = New Size(272, 80)
        l.TabIndex = 22
        l.Text = "Last name"
        l.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' m
        ' 
        m.AutoSize = True
        m.Dock = DockStyle.Fill
        m.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        m.Location = New Point(54, 210)
        m.Margin = New Padding(4, 0, 4, 0)
        m.Name = "m"
        m.Size = New Size(272, 80)
        m.TabIndex = 21
        m.Text = "Middle name"
        m.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Dock = DockStyle.Fill
        f.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        f.Location = New Point(54, 50)
        f.Margin = New Padding(4, 0, 4, 0)
        f.Name = "f"
        f.Size = New Size(272, 80)
        f.TabIndex = 19
        f.Text = "First name"
        f.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' e_date
        ' 
        e_date.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date.Location = New Point(418, 455)
        e_date.Margin = New Padding(4, 5, 4, 5)
        e_date.Name = "e_date"
        e_date.Size = New Size(271, 39)
        e_date.TabIndex = 20
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(134), CByte(134), CByte(134))
        Panel1.Controls.Add(status_lb)
        Panel1.Controls.Add(submit_employees_btn)
        Panel1.Controls.Add(cam_pic_box)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(745, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(495, 695)
        Panel1.TabIndex = 31
        ' 
        ' status_lb
        ' 
        status_lb.Dock = DockStyle.Bottom
        status_lb.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        status_lb.ForeColor = Color.Lime
        status_lb.Location = New Point(0, 517)
        status_lb.Margin = New Padding(4, 0, 4, 0)
        status_lb.Name = "status_lb"
        status_lb.Size = New Size(495, 84)
        status_lb.TabIndex = 33
        status_lb.Text = "READY"
        status_lb.TextAlign = ContentAlignment.TopCenter
        ' 
        ' cam_pic_box
        ' 
        cam_pic_box.BackColor = Color.White
        cam_pic_box.BorderStyle = BorderStyle.FixedSingle
        cam_pic_box.Image = My.Resources.Resources.user
        cam_pic_box.Location = New Point(16, 40)
        cam_pic_box.Margin = New Padding(4, 5, 4, 5)
        cam_pic_box.Name = "cam_pic_box"
        cam_pic_box.Padding = New Padding(10)
        cam_pic_box.Size = New Size(466, 438)
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
        TableLayoutPanel1.Margin = New Padding(3, 50, 3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(50, 50, 50, 0)
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(745, 695)
        TableLayoutPanel1.TabIndex = 32
        ' 
        ' addEmployee
        ' 
        AcceptButton = submit_employees_btn
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(223), CByte(223), CByte(223))
        ClientSize = New Size(1240, 695)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
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
