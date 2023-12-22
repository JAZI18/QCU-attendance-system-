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
        start_time_selector_panel = New Panel()
        okay = New Button()
        Label9 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        period = New ComboBox()
        min1 = New NumericUpDown()
        Hour1 = New NumericUpDown()
        end_time_selector_panel = New Panel()
        btn = New Button()
        Label12 = New Label()
        Label13 = New Label()
        Label15 = New Label()
        period2 = New ComboBox()
        min2 = New NumericUpDown()
        hour2 = New NumericUpDown()
        end_time = New TextBox()
        sched_datagrid = New DataGridView()
        employee_name = New Label()
        Panel1.SuspendLayout()
        start_time_selector_panel.SuspendLayout()
        CType(min1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Hour1, ComponentModel.ISupportInitialize).BeginInit()
        end_time_selector_panel.SuspendLayout()
        CType(min2, ComponentModel.ISupportInitialize).BeginInit()
        CType(hour2, ComponentModel.ISupportInitialize).BeginInit()
        CType(sched_datagrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' e_dep
        ' 
        e_dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_dep.FormattingEnabled = True
        e_dep.Location = New Point(574, 53)
        e_dep.Name = "e_dep"
        e_dep.Size = New Size(298, 29)
        e_dep.TabIndex = 30
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        f.Location = New Point(58, 29)
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
        workday.Location = New Point(49, 53)
        workday.Name = "workday"
        workday.Size = New Size(298, 29)
        workday.TabIndex = 33
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(583, 29)
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
        e_date1.Location = New Point(49, 119)
        e_date1.Name = "e_date1"
        e_date1.Size = New Size(298, 29)
        e_date1.TabIndex = 35
        ' 
        ' e_date2
        ' 
        e_date2.CalendarFont = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        e_date2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_date2.Format = DateTimePickerFormat.Short
        e_date2.Location = New Point(574, 119)
        e_date2.Name = "e_date2"
        e_date2.Size = New Size(298, 29)
        e_date2.TabIndex = 36
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(58, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 21)
        Label2.TabIndex = 37
        Label2.Text = "Start Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(581, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 21)
        Label3.TabIndex = 38
        Label3.Text = " End Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(58, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 21)
        Label4.TabIndex = 41
        Label4.Text = "Start Time"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(576, 165)
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
        sub_btn.Location = New Point(592, 280)
        sub_btn.Name = "sub_btn"
        sub_btn.Size = New Size(300, 45)
        sub_btn.TabIndex = 45
        sub_btn.Text = "Submit"
        sub_btn.UseVisualStyleBackColor = False
        ' 
        ' start_time
        ' 
        start_time.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        start_time.Location = New Point(49, 189)
        start_time.Name = "start_time"
        start_time.Size = New Size(298, 29)
        start_time.TabIndex = 51
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(start_time_selector_panel)
        Panel1.Controls.Add(end_time_selector_panel)
        Panel1.Controls.Add(f)
        Panel1.Controls.Add(e_date1)
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
        Panel1.Location = New Point(17, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(922, 220)
        Panel1.TabIndex = 52
        ' 
        ' start_time_selector_panel
        ' 
        start_time_selector_panel.Controls.Add(okay)
        start_time_selector_panel.Controls.Add(Label9)
        start_time_selector_panel.Controls.Add(Label8)
        start_time_selector_panel.Controls.Add(Label6)
        start_time_selector_panel.Controls.Add(period)
        start_time_selector_panel.Controls.Add(min1)
        start_time_selector_panel.Controls.Add(Hour1)
        start_time_selector_panel.Location = New Point(47, 74)
        start_time_selector_panel.Name = "start_time_selector_panel"
        start_time_selector_panel.Size = New Size(301, 144)
        start_time_selector_panel.TabIndex = 53
        start_time_selector_panel.Visible = False
        ' 
        ' okay
        ' 
        okay.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        okay.FlatStyle = FlatStyle.Flat
        okay.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        okay.ForeColor = SystemColors.ButtonHighlight
        okay.Location = New Point(158, 98)
        okay.Name = "okay"
        okay.Size = New Size(85, 32)
        okay.TabIndex = 53
        okay.Text = "Okay"
        okay.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(134, 24)
        Label9.Name = "Label9"
        Label9.Size = New Size(40, 21)
        Label9.TabIndex = 55
        Label9.Text = "Min"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(67, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(28, 21)
        Label8.TabIndex = 53
        Label8.Text = "Hr"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(115, 53)
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
        period.Location = New Point(196, 48)
        period.Name = "period"
        period.Size = New Size(47, 33)
        period.TabIndex = 53
        ' 
        ' min1
        ' 
        min1.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        min1.Location = New Point(134, 48)
        min1.Name = "min1"
        min1.Size = New Size(47, 33)
        min1.TabIndex = 1
        ' 
        ' Hour1
        ' 
        Hour1.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Hour1.Location = New Point(67, 48)
        Hour1.Name = "Hour1"
        Hour1.Size = New Size(47, 33)
        Hour1.TabIndex = 0
        ' 
        ' end_time_selector_panel
        ' 
        end_time_selector_panel.Controls.Add(btn)
        end_time_selector_panel.Controls.Add(Label12)
        end_time_selector_panel.Controls.Add(Label13)
        end_time_selector_panel.Controls.Add(Label15)
        end_time_selector_panel.Controls.Add(period2)
        end_time_selector_panel.Controls.Add(min2)
        end_time_selector_panel.Controls.Add(hour2)
        end_time_selector_panel.Location = New Point(573, 74)
        end_time_selector_panel.Name = "end_time_selector_panel"
        end_time_selector_panel.Size = New Size(301, 144)
        end_time_selector_panel.TabIndex = 57
        end_time_selector_panel.Visible = False
        ' 
        ' btn
        ' 
        btn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btn.FlatStyle = FlatStyle.Flat
        btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn.ForeColor = SystemColors.ButtonHighlight
        btn.Location = New Point(158, 98)
        btn.Name = "btn"
        btn.Size = New Size(85, 32)
        btn.TabIndex = 53
        btn.Text = "Okay"
        btn.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(132, 23)
        Label12.Name = "Label12"
        Label12.Size = New Size(40, 21)
        Label12.TabIndex = 55
        Label12.Text = "Min"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(65, 23)
        Label13.Name = "Label13"
        Label13.Size = New Size(28, 21)
        Label13.TabIndex = 53
        Label13.Text = "Hr"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(113, 52)
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
        period2.Location = New Point(196, 47)
        period2.Name = "period2"
        period2.Size = New Size(47, 33)
        period2.TabIndex = 53
        ' 
        ' min2
        ' 
        min2.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        min2.Location = New Point(132, 47)
        min2.Name = "min2"
        min2.Size = New Size(47, 33)
        min2.TabIndex = 1
        ' 
        ' hour2
        ' 
        hour2.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        hour2.Location = New Point(65, 47)
        hour2.Name = "hour2"
        hour2.Size = New Size(47, 33)
        hour2.TabIndex = 0
        ' 
        ' end_time
        ' 
        end_time.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        end_time.Location = New Point(573, 189)
        end_time.Name = "end_time"
        end_time.Size = New Size(300, 29)
        end_time.TabIndex = 54
        ' 
        ' sched_datagrid
        ' 
        sched_datagrid.AllowUserToAddRows = False
        sched_datagrid.AllowUserToDeleteRows = False
        sched_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        sched_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        sched_datagrid.Location = New Point(17, 335)
        sched_datagrid.Name = "sched_datagrid"
        sched_datagrid.ReadOnly = True
        sched_datagrid.RowTemplate.Height = 25
        sched_datagrid.Size = New Size(922, 312)
        sched_datagrid.TabIndex = 53
        ' 
        ' employee_name
        ' 
        employee_name.AutoSize = True
        employee_name.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        employee_name.Location = New Point(20, 11)
        employee_name.Name = "employee_name"
        employee_name.Size = New Size(112, 28)
        employee_name.TabIndex = 54
        employee_name.Text = "lmao lmao"
        ' 
        ' addSchedule
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(951, 659)
        Controls.Add(employee_name)
        Controls.Add(sched_datagrid)
        Controls.Add(Panel1)
        Controls.Add(sub_btn)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "addSchedule"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "addSchedule"
        TopMost = True
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        start_time_selector_panel.ResumeLayout(False)
        start_time_selector_panel.PerformLayout()
        CType(min1, ComponentModel.ISupportInitialize).EndInit()
        CType(Hour1, ComponentModel.ISupportInitialize).EndInit()
        end_time_selector_panel.ResumeLayout(False)
        end_time_selector_panel.PerformLayout()
        CType(min2, ComponentModel.ISupportInitialize).EndInit()
        CType(hour2, ComponentModel.ISupportInitialize).EndInit()
        CType(sched_datagrid, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents start_time_selector_panel As Panel
    Friend WithEvents okay As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents period As ComboBox
    Friend WithEvents min1 As NumericUpDown
    Friend WithEvents Hour1 As NumericUpDown
    Friend WithEvents end_time As TextBox
    Friend WithEvents sched_datagrid As DataGridView
    Friend WithEvents end_time_selector_panel As Panel
    Friend WithEvents btn As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents period2 As ComboBox
    Friend WithEvents min2 As NumericUpDown
    Friend WithEvents hour2 As NumericUpDown
    Friend WithEvents employee_name As Label
End Class
