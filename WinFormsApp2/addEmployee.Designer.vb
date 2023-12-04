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
        TabControl3 = New TabControl()
        TabPage9 = New TabPage()
        Button1 = New Button()
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
        TabControl3.SuspendLayout()
        TabPage9.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl3
        ' 
        TabControl3.Controls.Add(TabPage9)
        TabControl3.Location = New Point(0, 2)
        TabControl3.Name = "TabControl3"
        TabControl3.SelectedIndex = 0
        TabControl3.Size = New Size(430, 358)
        TabControl3.TabIndex = 1
        ' 
        ' TabPage9
        ' 
        TabPage9.BackColor = Color.Transparent
        TabPage9.Controls.Add(Button1)
        TabPage9.Controls.Add(submit_employees_btn)
        TabPage9.Controls.Add(e_dep)
        TabPage9.Controls.Add(dep)
        TabPage9.Controls.Add(e)
        TabPage9.Controls.Add(e_email)
        TabPage9.Controls.Add(e_lastname)
        TabPage9.Controls.Add(e_middlename)
        TabPage9.Controls.Add(e_firstname)
        TabPage9.Controls.Add(d)
        TabPage9.Controls.Add(e_gender)
        TabPage9.Controls.Add(Label17)
        TabPage9.Controls.Add(l)
        TabPage9.Controls.Add(m)
        TabPage9.Controls.Add(f)
        TabPage9.Controls.Add(e_date)
        TabPage9.Location = New Point(4, 24)
        TabPage9.Name = "TabPage9"
        TabPage9.Padding = New Padding(3)
        TabPage9.Size = New Size(422, 330)
        TabPage9.TabIndex = 0
        TabPage9.Text = "TabPage9"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(292, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 16
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' submit_employees_btn
        ' 
        submit_employees_btn.Location = New Point(221, 279)
        submit_employees_btn.Name = "submit_employees_btn"
        submit_employees_btn.Size = New Size(193, 33)
        submit_employees_btn.TabIndex = 15
        submit_employees_btn.Text = "Submit"
        submit_employees_btn.UseVisualStyleBackColor = True
        ' 
        ' e_dep
        ' 
        e_dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_dep.FormattingEnabled = True
        e_dep.Location = New Point(6, 283)
        e_dep.Name = "e_dep"
        e_dep.Size = New Size(194, 29)
        e_dep.TabIndex = 14
        ' 
        ' dep
        ' 
        dep.AutoSize = True
        dep.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dep.Location = New Point(6, 262)
        dep.Name = "dep"
        dep.Size = New Size(98, 21)
        dep.TabIndex = 13
        dep.Text = "Department"
        ' 
        ' e
        ' 
        e.AutoSize = True
        e.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        e.Location = New Point(211, 113)
        e.Name = "e"
        e.Size = New Size(48, 21)
        e.TabIndex = 11
        e.Text = "Email"
        ' 
        ' e_email
        ' 
        e_email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_email.Location = New Point(208, 134)
        e_email.Name = "e_email"
        e_email.Size = New Size(206, 29)
        e_email.TabIndex = 10
        ' 
        ' e_lastname
        ' 
        e_lastname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_lastname.Location = New Point(3, 134)
        e_lastname.Name = "e_lastname"
        e_lastname.Size = New Size(194, 29)
        e_lastname.TabIndex = 2
        ' 
        ' e_middlename
        ' 
        e_middlename.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_middlename.Location = New Point(208, 65)
        e_middlename.Name = "e_middlename"
        e_middlename.Size = New Size(206, 29)
        e_middlename.TabIndex = 1
        ' 
        ' e_firstname
        ' 
        e_firstname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_firstname.Location = New Point(3, 65)
        e_firstname.Name = "e_firstname"
        e_firstname.Size = New Size(194, 29)
        e_firstname.TabIndex = 0
        ' 
        ' d
        ' 
        d.AutoSize = True
        d.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        d.Location = New Point(9, 186)
        d.Name = "d"
        d.Size = New Size(41, 21)
        d.TabIndex = 9
        d.Text = "Dob"
        ' 
        ' e_gender
        ' 
        e_gender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_gender.FormattingEnabled = True
        e_gender.Items.AddRange(New Object() {"Male", "Female", "Binary", "Non-Binary", "Optimus Prime", "World Ender", "Others"})
        e_gender.Location = New Point(208, 207)
        e_gender.Name = "e_gender"
        e_gender.Size = New Size(206, 29)
        e_gender.TabIndex = 8
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(211, 186)
        Label17.Name = "Label17"
        Label17.Size = New Size(64, 21)
        Label17.TabIndex = 7
        Label17.Text = "Gender"
        ' 
        ' l
        ' 
        l.AutoSize = True
        l.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        l.Location = New Point(6, 113)
        l.Name = "l"
        l.Size = New Size(79, 21)
        l.TabIndex = 6
        l.Text = "Lastname"
        ' 
        ' m
        ' 
        m.AutoSize = True
        m.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        m.Location = New Point(211, 44)
        m.Name = "m"
        m.Size = New Size(102, 21)
        m.TabIndex = 5
        m.Text = "Middlename"
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        f.Location = New Point(6, 44)
        f.Name = "f"
        f.Size = New Size(81, 21)
        f.TabIndex = 3
        f.Text = "Firstname"
        ' 
        ' e_date
        ' 
        e_date.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date.Location = New Point(6, 207)
        e_date.Name = "e_date"
        e_date.Size = New Size(191, 29)
        e_date.TabIndex = 4
        ' 
        ' addEmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(429, 370)
        Controls.Add(TabControl3)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(2)
        Name = "addEmployee"
        StartPosition = FormStartPosition.CenterParent
        Text = "addEmployee"
        TabControl3.ResumeLayout(False)
        TabPage9.ResumeLayout(False)
        TabPage9.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents submit_employees_btn As Button
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
    Friend WithEvents Button1 As Button
    Friend WithEvents e_dep As ComboBox
End Class
