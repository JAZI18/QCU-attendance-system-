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
        TabControl3.Location = New Point(0, 4)
        TabControl3.Margin = New Padding(4, 5, 4, 5)
        TabControl3.Name = "TabControl3"
        TabControl3.SelectedIndex = 0
        TabControl3.Size = New Size(615, 592)
        TabControl3.TabIndex = 1
        ' 
        ' TabPage9
        ' 
        TabPage9.BackColor = Color.Transparent
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
        TabPage9.Location = New Point(4, 34)
        TabPage9.Margin = New Padding(4, 5, 4, 5)
        TabPage9.Name = "TabPage9"
        TabPage9.Padding = New Padding(4, 5, 4, 5)
        TabPage9.Size = New Size(607, 554)
        TabPage9.TabIndex = 0
        TabPage9.Text = "TabPage9"
        ' 
        ' submit_employees_btn
        ' 
        submit_employees_btn.Location = New Point(316, 465)
        submit_employees_btn.Margin = New Padding(4, 5, 4, 5)
        submit_employees_btn.Name = "submit_employees_btn"
        submit_employees_btn.Size = New Size(276, 55)
        submit_employees_btn.TabIndex = 15
        submit_employees_btn.Text = "Submit"
        submit_employees_btn.UseVisualStyleBackColor = True
        ' 
        ' e_dep
        ' 
        e_dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_dep.FormattingEnabled = True
        e_dep.Location = New Point(9, 472)
        e_dep.Margin = New Padding(4, 5, 4, 5)
        e_dep.Name = "e_dep"
        e_dep.Size = New Size(275, 40)
        e_dep.TabIndex = 14
        ' 
        ' dep
        ' 
        dep.AutoSize = True
        dep.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dep.Location = New Point(8, 437)
        dep.Margin = New Padding(4, 0, 4, 0)
        dep.Name = "dep"
        dep.Size = New Size(147, 32)
        dep.TabIndex = 13
        dep.Text = "Department"
        ' 
        ' e
        ' 
        e.AutoSize = True
        e.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        e.Location = New Point(301, 188)
        e.Margin = New Padding(4, 0, 4, 0)
        e.Name = "e"
        e.Size = New Size(72, 32)
        e.TabIndex = 11
        e.Text = "Email"
        ' 
        ' e_email
        ' 
        e_email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_email.Location = New Point(297, 223)
        e_email.Margin = New Padding(4, 5, 4, 5)
        e_email.Name = "e_email"
        e_email.Size = New Size(293, 39)
        e_email.TabIndex = 10
        ' 
        ' e_lastname
        ' 
        e_lastname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_lastname.Location = New Point(4, 223)
        e_lastname.Margin = New Padding(4, 5, 4, 5)
        e_lastname.Name = "e_lastname"
        e_lastname.Size = New Size(275, 39)
        e_lastname.TabIndex = 2
        ' 
        ' e_middlename
        ' 
        e_middlename.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_middlename.Location = New Point(297, 108)
        e_middlename.Margin = New Padding(4, 5, 4, 5)
        e_middlename.Name = "e_middlename"
        e_middlename.Size = New Size(293, 39)
        e_middlename.TabIndex = 1
        ' 
        ' e_firstname
        ' 
        e_firstname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_firstname.Location = New Point(4, 108)
        e_firstname.Margin = New Padding(4, 5, 4, 5)
        e_firstname.Name = "e_firstname"
        e_firstname.Size = New Size(275, 39)
        e_firstname.TabIndex = 0
        ' 
        ' d
        ' 
        d.AutoSize = True
        d.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        d.Location = New Point(13, 310)
        d.Margin = New Padding(4, 0, 4, 0)
        d.Name = "d"
        d.Size = New Size(59, 32)
        d.TabIndex = 9
        d.Text = "Dob"
        ' 
        ' e_gender
        ' 
        e_gender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_gender.FormattingEnabled = True
        e_gender.Items.AddRange(New Object() {"Male", "Female", "Binary", "Non-Binary", "Optimus Prime", "World Ender", "Others"})
        e_gender.Location = New Point(297, 345)
        e_gender.Margin = New Padding(4, 5, 4, 5)
        e_gender.Name = "e_gender"
        e_gender.Size = New Size(293, 40)
        e_gender.TabIndex = 8
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(301, 310)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(94, 32)
        Label17.TabIndex = 7
        Label17.Text = "Gender"
        ' 
        ' l
        ' 
        l.AutoSize = True
        l.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        l.Location = New Point(8, 188)
        l.Margin = New Padding(4, 0, 4, 0)
        l.Name = "l"
        l.Size = New Size(119, 32)
        l.TabIndex = 6
        l.Text = "Lastname"
        ' 
        ' m
        ' 
        m.AutoSize = True
        m.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        m.Location = New Point(301, 73)
        m.Margin = New Padding(4, 0, 4, 0)
        m.Name = "m"
        m.Size = New Size(150, 32)
        m.TabIndex = 5
        m.Text = "Middlename"
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        f.Location = New Point(8, 73)
        f.Margin = New Padding(4, 0, 4, 0)
        f.Name = "f"
        f.Size = New Size(121, 32)
        f.TabIndex = 3
        f.Text = "Firstname"
        ' 
        ' e_date
        ' 
        e_date.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date.Location = New Point(9, 345)
        e_date.Margin = New Padding(4, 5, 4, 5)
        e_date.Name = "e_date"
        e_date.Size = New Size(271, 39)
        e_date.TabIndex = 4
        ' 
        ' addEmployee
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(611, 606)
        Controls.Add(TabControl3)
        FormBorderStyle = FormBorderStyle.None
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
End Class
