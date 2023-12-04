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
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        f = New Label()
        e_firstname = New TextBox()
        e_middlename = New TextBox()
        m = New Label()
        TextBox1 = New TextBox()
        l = New Label()
        e_email = New TextBox()
        e = New Label()
        e_date = New DateTimePicker()
        d = New Label()
        e_dep = New ComboBox()
        dep = New Label()
        ComboBox2 = New ComboBox()
        Label17 = New Label()
        submit_employees_btn = New Button()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 25)
        Label1.TabIndex = 1
        Label1.Text = "Update Employee"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 37)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(465, 401)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(submit_employees_btn)
        TabPage1.Controls.Add(ComboBox2)
        TabPage1.Controls.Add(Label17)
        TabPage1.Controls.Add(dep)
        TabPage1.Controls.Add(e_dep)
        TabPage1.Controls.Add(d)
        TabPage1.Controls.Add(e_date)
        TabPage1.Controls.Add(e)
        TabPage1.Controls.Add(e_email)
        TabPage1.Controls.Add(l)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(m)
        TabPage1.Controls.Add(e_middlename)
        TabPage1.Controls.Add(e_firstname)
        TabPage1.Controls.Add(f)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(457, 373)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(192, 72)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        f.Location = New Point(19, 43)
        f.Name = "f"
        f.Size = New Size(81, 21)
        f.TabIndex = 4
        f.Text = "Firstname"
        ' 
        ' e_firstname
        ' 
        e_firstname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_firstname.Location = New Point(19, 67)
        e_firstname.Name = "e_firstname"
        e_firstname.Size = New Size(194, 29)
        e_firstname.TabIndex = 5
        ' 
        ' e_middlename
        ' 
        e_middlename.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_middlename.Location = New Point(234, 67)
        e_middlename.Name = "e_middlename"
        e_middlename.Size = New Size(206, 29)
        e_middlename.TabIndex = 6
        ' 
        ' m
        ' 
        m.AutoSize = True
        m.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        m.Location = New Point(234, 43)
        m.Name = "m"
        m.Size = New Size(102, 21)
        m.TabIndex = 7
        m.Text = "Middlename"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(19, 137)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(194, 29)
        TextBox1.TabIndex = 8
        ' 
        ' l
        ' 
        l.AutoSize = True
        l.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        l.Location = New Point(19, 113)
        l.Name = "l"
        l.Size = New Size(79, 21)
        l.TabIndex = 9
        l.Text = "Lastname"
        ' 
        ' e_email
        ' 
        e_email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_email.Location = New Point(234, 137)
        e_email.Name = "e_email"
        e_email.Size = New Size(206, 29)
        e_email.TabIndex = 11
        ' 
        ' e
        ' 
        e.AutoSize = True
        e.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        e.Location = New Point(234, 113)
        e.Name = "e"
        e.Size = New Size(48, 21)
        e.TabIndex = 12
        e.Text = "Email"
        ' 
        ' e_date
        ' 
        e_date.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date.Location = New Point(22, 203)
        e_date.Name = "e_date"
        e_date.Size = New Size(191, 29)
        e_date.TabIndex = 13
        ' 
        ' d
        ' 
        d.AutoSize = True
        d.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        d.Location = New Point(22, 179)
        d.Name = "d"
        d.Size = New Size(41, 21)
        d.TabIndex = 14
        d.Text = "Dob"
        ' 
        ' e_dep
        ' 
        e_dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_dep.FormattingEnabled = True
        e_dep.Location = New Point(22, 274)
        e_dep.Name = "e_dep"
        e_dep.Size = New Size(194, 29)
        e_dep.TabIndex = 16
        ' 
        ' dep
        ' 
        dep.AutoSize = True
        dep.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dep.Location = New Point(22, 250)
        dep.Name = "dep"
        dep.Size = New Size(98, 21)
        dep.TabIndex = 17
        dep.Text = "Department"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Male", "Female", "Binary", "Non-Binary", "Optimus Prime", "World Ender", "Others"})
        ComboBox2.Location = New Point(234, 206)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(206, 29)
        ComboBox2.TabIndex = 20
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(234, 182)
        Label17.Name = "Label17"
        Label17.Size = New Size(64, 21)
        Label17.TabIndex = 19
        Label17.Text = "Gender"
        ' 
        ' submit_employees_btn
        ' 
        submit_employees_btn.Location = New Point(234, 270)
        submit_employees_btn.Name = "submit_employees_btn"
        submit_employees_btn.Size = New Size(206, 33)
        submit_employees_btn.TabIndex = 21
        submit_employees_btn.Text = "Submit"
        submit_employees_btn.UseVisualStyleBackColor = True
        ' 
        ' Update_Employee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(485, 450)
        Controls.Add(TabControl1)
        Controls.Add(Label1)
        Name = "Update_Employee"
        Text = "Update_Employee"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents f As Label
    Friend WithEvents e_firstname As TextBox
    Friend WithEvents e_middlename As TextBox
    Friend WithEvents m As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents l As Label
    Friend WithEvents e_email As TextBox
    Friend WithEvents e As Label
    Friend WithEvents e_date As DateTimePicker
    Friend WithEvents d As Label
    Friend WithEvents e_dep As ComboBox
    Friend WithEvents dep As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents submit_employees_btn As Button
End Class
