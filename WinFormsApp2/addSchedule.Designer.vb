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
        start_time = New TextBox()
        Panel1 = New Panel()
        Panel3 = New Panel()
        btn = New Button()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        period2 = New ComboBox()
        sec2 = New NumericUpDown()
        min2 = New NumericUpDown()
        hour2 = New NumericUpDown()
        end_time = New TextBox()
        Panel2 = New Panel()
        okay = New Button()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        period = New ComboBox()
        sec1 = New NumericUpDown()
        min1 = New NumericUpDown()
        Hour1 = New NumericUpDown()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(sec2, ComponentModel.ISupportInitialize).BeginInit()
        CType(min2, ComponentModel.ISupportInitialize).BeginInit()
        CType(hour2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(sec1, ComponentModel.ISupportInitialize).BeginInit()
        CType(min1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Hour1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' e_dep
        ' 
        e_dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_dep.FormattingEnabled = True
        e_dep.Location = New Point(260, 39)
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
        workday.Location = New Point(8, 39)
        workday.Name = "workday"
        workday.Size = New Size(217, 29)
        workday.TabIndex = 33
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(260, 15)
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
        e_date1.Location = New Point(8, 105)
        e_date1.Name = "e_date1"
        e_date1.Size = New Size(217, 29)
        e_date1.TabIndex = 35
        ' 
        ' e_date2
        ' 
        e_date2.CalendarFont = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        e_date2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date2.Format = DateTimePickerFormat.Short
        e_date2.Location = New Point(260, 105)
        e_date2.Name = "e_date2"
        e_date2.Size = New Size(210, 29)
        e_date2.TabIndex = 36
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(8, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 21)
        Label2.TabIndex = 37
        Label2.Text = "Start Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(258, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 21)
        Label3.TabIndex = 38
        Label3.Text = " End Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(8, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 21)
        Label4.TabIndex = 41
        Label4.Text = "Start Time"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(253, 151)
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
        sub_btn.Location = New Point(371, 236)
        sub_btn.Name = "sub_btn"
        sub_btn.Size = New Size(99, 33)
        sub_btn.TabIndex = 45
        sub_btn.Text = "Submit"
        sub_btn.UseVisualStyleBackColor = False
        ' 
        ' start_time
        ' 
        start_time.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        start_time.Location = New Point(8, 175)
        start_time.Name = "start_time"
        start_time.Size = New Size(217, 29)
        start_time.TabIndex = 51
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(e_date1)
        Panel1.Controls.Add(sub_btn)
        Panel1.Controls.Add(start_time)
        Panel1.Controls.Add(workday)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(e_dep)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(e_date2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(end_time)
        Panel1.Location = New Point(17, 13)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(483, 293)
        Panel1.TabIndex = 52
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btn)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(period2)
        Panel3.Controls.Add(sec2)
        Panel3.Controls.Add(min2)
        Panel3.Controls.Add(hour2)
        Panel3.Location = New Point(76, 70)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(340, 150)
        Panel3.TabIndex = 57
        Panel3.Visible = False
        ' 
        ' btn
        ' 
        btn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btn.FlatStyle = FlatStyle.Flat
        btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn.ForeColor = SystemColors.ButtonHighlight
        btn.Location = New Point(248, 91)
        btn.Name = "btn"
        btn.Size = New Size(85, 32)
        btn.TabIndex = 53
        btn.Text = "Okay"
        btn.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(195, 17)
        Label11.Name = "Label11"
        Label11.Size = New Size(36, 21)
        Label11.TabIndex = 56
        Label11.Text = "Sec"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(127, 17)
        Label12.Name = "Label12"
        Label12.Size = New Size(40, 21)
        Label12.TabIndex = 55
        Label12.Text = "Min"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(60, 17)
        Label13.Name = "Label13"
        Label13.Size = New Size(28, 21)
        Label13.TabIndex = 53
        Label13.Text = "Hr"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(175, 45)
        Label14.Name = "Label14"
        Label14.Size = New Size(17, 25)
        Label14.TabIndex = 54
        Label14.Text = ":"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(108, 46)
        Label15.Name = "Label15"
        Label15.Size = New Size(17, 25)
        Label15.TabIndex = 53
        Label15.Text = ":"
        ' 
        ' period2
        ' 
        period2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        period2.FormattingEnabled = True
        period2.Items.AddRange(New Object() {"AM", "PM"})
        period2.Location = New Point(257, 41)
        period2.Name = "period2"
        period2.Size = New Size(47, 33)
        period2.TabIndex = 53
        ' 
        ' sec2
        ' 
        sec2.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        sec2.Location = New Point(195, 41)
        sec2.Name = "sec2"
        sec2.Size = New Size(47, 33)
        sec2.TabIndex = 2
        ' 
        ' min2
        ' 
        min2.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        min2.Location = New Point(127, 41)
        min2.Name = "min2"
        min2.Size = New Size(47, 33)
        min2.TabIndex = 1
        ' 
        ' hour2
        ' 
        hour2.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        hour2.Location = New Point(60, 41)
        hour2.Name = "hour2"
        hour2.Size = New Size(47, 33)
        hour2.TabIndex = 0
        ' 
        ' end_time
        ' 
        end_time.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        end_time.Location = New Point(258, 175)
        end_time.Name = "end_time"
        end_time.Size = New Size(212, 29)
        end_time.TabIndex = 54
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(okay)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(period)
        Panel2.Controls.Add(sec1)
        Panel2.Controls.Add(min1)
        Panel2.Controls.Add(Hour1)
        Panel2.Location = New Point(76, 70)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(340, 134)
        Panel2.TabIndex = 53
        Panel2.Visible = False
        ' 
        ' okay
        ' 
        okay.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        okay.FlatStyle = FlatStyle.Flat
        okay.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        okay.ForeColor = SystemColors.ButtonHighlight
        okay.Location = New Point(248, 91)
        okay.Name = "okay"
        okay.Size = New Size(85, 32)
        okay.TabIndex = 53
        okay.Text = "Okay"
        okay.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(195, 17)
        Label10.Name = "Label10"
        Label10.Size = New Size(36, 21)
        Label10.TabIndex = 56
        Label10.Text = "Sec"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(127, 17)
        Label9.Name = "Label9"
        Label9.Size = New Size(40, 21)
        Label9.TabIndex = 55
        Label9.Text = "Min"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(60, 17)
        Label8.Name = "Label8"
        Label8.Size = New Size(28, 21)
        Label8.TabIndex = 53
        Label8.Text = "Hr"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(175, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(17, 25)
        Label7.TabIndex = 54
        Label7.Text = ":"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(108, 46)
        Label6.Name = "Label6"
        Label6.Size = New Size(17, 25)
        Label6.TabIndex = 53
        Label6.Text = ":"
        ' 
        ' period
        ' 
        period.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        period.FormattingEnabled = True
        period.Items.AddRange(New Object() {"AM", "PM"})
        period.Location = New Point(257, 41)
        period.Name = "period"
        period.Size = New Size(47, 33)
        period.TabIndex = 53
        ' 
        ' sec1
        ' 
        sec1.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        sec1.Location = New Point(195, 41)
        sec1.Name = "sec1"
        sec1.Size = New Size(47, 33)
        sec1.TabIndex = 2
        ' 
        ' min1
        ' 
        min1.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        min1.Location = New Point(127, 41)
        min1.Name = "min1"
        min1.Size = New Size(47, 33)
        min1.TabIndex = 1
        ' 
        ' Hour1
        ' 
        Hour1.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Hour1.Location = New Point(60, 41)
        Hour1.Name = "Hour1"
        Hour1.Size = New Size(47, 33)
        Hour1.TabIndex = 0
        ' 
        ' addSchedule
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(522, 329)
        Controls.Add(f)
        Controls.Add(Panel1)
        Name = "addSchedule"
        Text = "addSchedule"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(sec2, ComponentModel.ISupportInitialize).EndInit()
        CType(min2, ComponentModel.ISupportInitialize).EndInit()
        CType(hour2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(sec1, ComponentModel.ISupportInitialize).EndInit()
        CType(min1, ComponentModel.ISupportInitialize).EndInit()
        CType(Hour1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents start_time As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents okay As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents period As ComboBox
    Friend WithEvents sec1 As NumericUpDown
    Friend WithEvents min1 As NumericUpDown
    Friend WithEvents Hour1 As NumericUpDown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents period2 As ComboBox
    Friend WithEvents sec2 As NumericUpDown
    Friend WithEvents min2 As NumericUpDown
    Friend WithEvents hour2 As NumericUpDown
    Friend WithEvents end_time As TextBox
End Class
