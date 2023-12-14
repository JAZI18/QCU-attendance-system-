<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Employee
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
        department = New ComboBox()
        submit_employees_btn = New Button()
        gender = New ComboBox()
        Label17 = New Label()
        dep = New Label()
        d = New Label()
        e_date = New DateTimePicker()
        e = New Label()
        e_email = New TextBox()
        l = New Label()
        e_lastname = New TextBox()
        m = New Label()
        e_middlename = New TextBox()
        e_firstname = New TextBox()
        f = New Label()
        SuspendLayout()
        ' 
        ' department
        ' 
        department.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        department.FormattingEnabled = True
        department.Location = New Point(31, 264)
        department.Name = "department"
        department.Size = New Size(192, 29)
        department.TabIndex = 37
        ' 
        ' submit_employees_btn
        ' 
        submit_employees_btn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        submit_employees_btn.FlatStyle = FlatStyle.Flat
        submit_employees_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        submit_employees_btn.ForeColor = SystemColors.Control
        submit_employees_btn.Location = New Point(31, 323)
        submit_employees_btn.Name = "submit_employees_btn"
        submit_employees_btn.Size = New Size(96, 37)
        submit_employees_btn.TabIndex = 36
        submit_employees_btn.Text = "Submit"
        submit_employees_btn.UseVisualStyleBackColor = False
        ' 
        ' gender
        ' 
        gender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        gender.FormattingEnabled = True
        gender.Items.AddRange(New Object() {"Male", "Female", "Binary", "Non-Binary", "Optimus Prime", "World Ender", "Others"})
        gender.Location = New Point(246, 196)
        gender.Name = "gender"
        gender.Size = New Size(206, 29)
        gender.TabIndex = 35
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(246, 172)
        Label17.Name = "Label17"
        Label17.Size = New Size(61, 21)
        Label17.TabIndex = 34
        Label17.Text = "Gender"
        ' 
        ' dep
        ' 
        dep.AutoSize = True
        dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dep.Location = New Point(34, 240)
        dep.Name = "dep"
        dep.Size = New Size(93, 21)
        dep.TabIndex = 33
        dep.Text = "Department"
        ' 
        ' d
        ' 
        d.AutoSize = True
        d.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        d.Location = New Point(34, 169)
        d.Name = "d"
        d.Size = New Size(39, 21)
        d.TabIndex = 32
        d.Text = "Dob"
        ' 
        ' e_date
        ' 
        e_date.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date.Location = New Point(31, 193)
        e_date.Name = "e_date"
        e_date.Size = New Size(191, 29)
        e_date.TabIndex = 31
        ' 
        ' e
        ' 
        e.AutoSize = True
        e.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e.Location = New Point(246, 103)
        e.Name = "e"
        e.Size = New Size(48, 21)
        e.TabIndex = 30
        e.Text = "Email"
        ' 
        ' e_email
        ' 
        e_email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_email.Location = New Point(246, 127)
        e_email.Name = "e_email"
        e_email.Size = New Size(206, 29)
        e_email.TabIndex = 29
        ' 
        ' l
        ' 
        l.AutoSize = True
        l.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        l.Location = New Point(31, 103)
        l.Name = "l"
        l.Size = New Size(81, 21)
        l.TabIndex = 28
        l.Text = "Last name"
        ' 
        ' e_lastname
        ' 
        e_lastname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_lastname.Location = New Point(31, 127)
        e_lastname.Name = "e_lastname"
        e_lastname.Size = New Size(194, 29)
        e_lastname.TabIndex = 27
        ' 
        ' m
        ' 
        m.AutoSize = True
        m.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        m.Location = New Point(246, 33)
        m.Name = "m"
        m.Size = New Size(101, 21)
        m.TabIndex = 26
        m.Text = "Middle name"
        ' 
        ' e_middlename
        ' 
        e_middlename.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_middlename.Location = New Point(246, 57)
        e_middlename.Name = "e_middlename"
        e_middlename.Size = New Size(206, 29)
        e_middlename.TabIndex = 25
        ' 
        ' e_firstname
        ' 
        e_firstname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_firstname.Location = New Point(31, 57)
        e_firstname.Name = "e_firstname"
        e_firstname.Size = New Size(194, 29)
        e_firstname.TabIndex = 24
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        f.Location = New Point(31, 33)
        f.Name = "f"
        f.Size = New Size(83, 21)
        f.TabIndex = 23
        f.Text = "First name"
        ' 
        ' Update_Employee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(223), CByte(223), CByte(223))
        ClientSize = New Size(485, 389)
        Controls.Add(department)
        Controls.Add(submit_employees_btn)
        Controls.Add(gender)
        Controls.Add(Label17)
        Controls.Add(dep)
        Controls.Add(d)
        Controls.Add(e_date)
        Controls.Add(e)
        Controls.Add(e_email)
        Controls.Add(l)
        Controls.Add(e_lastname)
        Controls.Add(m)
        Controls.Add(e_middlename)
        Controls.Add(e_firstname)
        Controls.Add(f)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Update_Employee"
        Text = "Update_Employee"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents department As ComboBox
    Friend WithEvents submit_employees_btn As Button
    Friend WithEvents gender As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dep As Label
    Friend WithEvents d As Label
    Friend WithEvents e_date As DateTimePicker
    Friend WithEvents e As Label
    Friend WithEvents e_email As TextBox
    Friend WithEvents l As Label
    Friend WithEvents e_lastname As TextBox
    Friend WithEvents m As Label
    Friend WithEvents e_middlename As TextBox
    Friend WithEvents e_firstname As TextBox
    Friend WithEvents f As Label
End Class
