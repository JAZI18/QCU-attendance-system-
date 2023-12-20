<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addSchedule
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
        e_dep = New ComboBox()
        f = New Label()
        workday = New ComboBox()
        Label1 = New Label()
        e_date1 = New DateTimePicker()
        e_date2 = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        sub_btn = New Button()
        MaskedTextBox1 = New MaskedTextBox()
        MaskedTextBox2 = New MaskedTextBox()
        SuspendLayout()
        ' 
        ' e_dep
        ' 
        e_dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_dep.FormattingEnabled = True
        e_dep.Location = New Point(277, 52)
        e_dep.Name = "e_dep"
        e_dep.Size = New Size(210, 29)
        e_dep.TabIndex = 30
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        f.Location = New Point(25, 28)
        f.Name = "f"
        f.Size = New Size(72, 21)
        f.TabIndex = 32
        f.Text = "Workday"
        ' 
        ' workday
        ' 
        workday.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        workday.FormattingEnabled = True
        workday.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        workday.Location = New Point(25, 52)
        workday.Name = "workday"
        workday.Size = New Size(217, 29)
        workday.TabIndex = 33
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(277, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 21)
        Label1.TabIndex = 34
        Label1.Text = "Branch"
        ' 
        ' e_date1
        ' 
        e_date1.CalendarFont = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        e_date1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date1.Format = DateTimePickerFormat.Short
        e_date1.Location = New Point(25, 118)
        e_date1.Name = "e_date1"
        e_date1.Size = New Size(217, 29)
        e_date1.TabIndex = 35
        ' 
        ' e_date2
        ' 
        e_date2.CalendarFont = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        e_date2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date2.Format = DateTimePickerFormat.Short
        e_date2.Location = New Point(277, 118)
        e_date2.Name = "e_date2"
        e_date2.Size = New Size(210, 29)
        e_date2.TabIndex = 36
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(25, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 21)
        Label2.TabIndex = 37
        Label2.Text = "Start Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(277, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 21)
        Label3.TabIndex = 38
        Label3.Text = " End Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(25, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 21)
        Label4.TabIndex = 41
        Label4.Text = "Start Time"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(277, 164)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 21)
        Label5.TabIndex = 43
        Label5.Text = "End Time"
        ' 
        ' sub_btn
        ' 
        sub_btn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        sub_btn.FlatStyle = FlatStyle.Flat
        sub_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        sub_btn.ForeColor = SystemColors.ButtonHighlight
        sub_btn.Location = New Point(395, 253)
        sub_btn.Name = "sub_btn"
        sub_btn.Size = New Size(99, 33)
        sub_btn.TabIndex = 45
        sub_btn.Text = "Submit"
        sub_btn.UseVisualStyleBackColor = False
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MaskedTextBox1.Location = New Point(25, 188)
        MaskedTextBox1.Mask = "00:00:00"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(217, 29)
        MaskedTextBox1.TabIndex = 49
        MaskedTextBox1.ValidatingType = GetType(Date)
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MaskedTextBox2.Location = New Point(277, 188)
        MaskedTextBox2.Mask = "00:00:00"
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(217, 29)
        MaskedTextBox2.TabIndex = 50
        MaskedTextBox2.ValidatingType = GetType(Date)
        ' 
        ' addSchedule
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(512, 318)
        Controls.Add(MaskedTextBox2)
        Controls.Add(MaskedTextBox1)
        Controls.Add(sub_btn)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(e_date2)
        Controls.Add(e_date1)
        Controls.Add(Label1)
        Controls.Add(workday)
        Controls.Add(f)
        Controls.Add(e_dep)
        Name = "addSchedule"
        Text = "addSchedule"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents e_dep As ComboBox
    Friend WithEvents f As Label
    Friend WithEvents workday As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents e_date1 As DateTimePicker
    Friend WithEvents e_date2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sub_btn As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
End Class
