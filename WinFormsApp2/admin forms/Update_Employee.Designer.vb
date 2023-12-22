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
        department.Location = New Point(44, 440)
        department.Margin = New Padding(4, 5, 4, 5)
        department.Name = "department"
        department.Size = New Size(273, 40)
        department.TabIndex = 37
        ' 
        ' submit_employees_btn
        ' 
        submit_employees_btn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        submit_employees_btn.FlatStyle = FlatStyle.Flat
        submit_employees_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        submit_employees_btn.ForeColor = SystemColors.Control
        submit_employees_btn.Location = New Point(44, 538)
        submit_employees_btn.Margin = New Padding(4, 5, 4, 5)
        submit_employees_btn.Name = "submit_employees_btn"
        submit_employees_btn.Size = New Size(137, 62)
        submit_employees_btn.TabIndex = 36
        submit_employees_btn.Text = "Submit"
        submit_employees_btn.UseVisualStyleBackColor = False
        ' 
        ' gender
        ' 
        gender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        gender.FormattingEnabled = True
        gender.Items.AddRange(New Object() {"Male", "Female", "Binary", "Non-Binary", "Optimus Prime", "World Ender", "Others"})
        gender.Location = New Point(351, 327)
        gender.Margin = New Padding(4, 5, 4, 5)
        gender.Name = "gender"
        gender.Size = New Size(293, 40)
        gender.TabIndex = 35
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(351, 287)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(92, 32)
        Label17.TabIndex = 34
        Label17.Text = "Gender"
        ' 
        ' dep
        ' 
        dep.AutoSize = True
        dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dep.Location = New Point(49, 400)
        dep.Margin = New Padding(4, 0, 4, 0)
        dep.Name = "dep"
        dep.Size = New Size(142, 32)
        dep.TabIndex = 33
        dep.Text = "Department"
        ' 
        ' d
        ' 
        d.AutoSize = True
        d.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        d.Location = New Point(49, 282)
        d.Margin = New Padding(4, 0, 4, 0)
        d.Name = "d"
        d.Size = New Size(59, 32)
        d.TabIndex = 32
        d.Text = "Dob"
        ' 
        ' e_date
        ' 
        e_date.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date.Location = New Point(44, 322)
        e_date.Margin = New Padding(4, 5, 4, 5)
        e_date.Name = "e_date"
        e_date.Size = New Size(271, 39)
        e_date.TabIndex = 31
        ' 
        ' e
        ' 
        e.AutoSize = True
        e.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e.Location = New Point(351, 172)
        e.Margin = New Padding(4, 0, 4, 0)
        e.Name = "e"
        e.Size = New Size(71, 32)
        e.TabIndex = 30
        e.Text = "Email"
        ' 
        ' e_email
        ' 
        e_email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_email.Location = New Point(351, 212)
        e_email.Margin = New Padding(4, 5, 4, 5)
        e_email.Name = "e_email"
        e_email.Size = New Size(293, 39)
        e_email.TabIndex = 29
        ' 
        ' l
        ' 
        l.AutoSize = True
        l.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        l.Location = New Point(44, 172)
        l.Margin = New Padding(4, 0, 4, 0)
        l.Name = "l"
        l.Size = New Size(122, 32)
        l.TabIndex = 28
        l.Text = "Last name"
        ' 
        ' e_lastname
        ' 
        e_lastname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_lastname.Location = New Point(44, 212)
        e_lastname.Margin = New Padding(4, 5, 4, 5)
        e_lastname.Name = "e_lastname"
        e_lastname.Size = New Size(275, 39)
        e_lastname.TabIndex = 27
        ' 
        ' m
        ' 
        m.AutoSize = True
        m.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        m.Location = New Point(351, 55)
        m.Margin = New Padding(4, 0, 4, 0)
        m.Name = "m"
        m.Size = New Size(156, 32)
        m.TabIndex = 26
        m.Text = "Middle name"
        ' 
        ' e_middlename
        ' 
        e_middlename.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_middlename.Location = New Point(351, 95)
        e_middlename.Margin = New Padding(4, 5, 4, 5)
        e_middlename.Name = "e_middlename"
        e_middlename.Size = New Size(293, 39)
        e_middlename.TabIndex = 25
        ' 
        ' e_firstname
        ' 
        e_firstname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_firstname.Location = New Point(44, 95)
        e_firstname.Margin = New Padding(4, 5, 4, 5)
        e_firstname.Name = "e_firstname"
        e_firstname.Size = New Size(275, 39)
        e_firstname.TabIndex = 24
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        f.Location = New Point(44, 55)
        f.Margin = New Padding(4, 0, 4, 0)
        f.Name = "f"
        f.Size = New Size(125, 32)
        f.TabIndex = 23
        f.Text = "First name"
        ' 
        ' Update_Employee
        ' 
        AcceptButton = submit_employees_btn
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(223), CByte(223), CByte(223))
        ClientSize = New Size(693, 648)
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
        Margin = New Padding(4, 5, 4, 5)
        Name = "Update_Employee"
        StartPosition = FormStartPosition.CenterScreen
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
