<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admindashboardform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        printreport_btn = New Button()
        branch_btn = New Button()
        department_btn = New Button()
        employee_btn = New Button()
        dashboard_btn = New Button()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Button1 = New Button()
        TabPage3 = New TabPage()
        sanfrancisco_branch_btn = New Button()
        batasan_branch_btn = New Button()
        sanbartolome_branch_btn = New Button()
        Panel10 = New Panel()
        Panel9 = New Panel()
        Panel8 = New Panel()
        Label9 = New Label()
        PictureBox4 = New PictureBox()
        TabPage2 = New TabPage()
        Panel7 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        add_employees_btn = New Button()
        id_employees_tb = New TextBox()
        Label7 = New Label()
        employee_grid_view = New DataGridView()
        id_col = New DataGridViewTextBoxColumn()
        name_col = New DataGridViewTextBoxColumn()
        shift_col = New DataGridViewTextBoxColumn()
        gender_col = New DataGridViewTextBoxColumn()
        dob_col = New DataGridViewTextBoxColumn()
        hired_col = New DataGridViewTextBoxColumn()
        act_col = New DataGridViewTextBoxColumn()
        PictureBox3 = New PictureBox()
        TabPage1 = New TabPage()
        Stats_button3 = New stats_button()
        Stats_button4 = New stats_button()
        Stats_button2 = New stats_button()
        Stats_button1 = New stats_button()
        Label6 = New Label()
        PictureBox6 = New PictureBox()
        Column2 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        TabControl1 = New TabControl()
        TabPage4 = New TabPage()
        Panel12 = New Panel()
        id_dept_tb = New TextBox()
        Update_btn_dept = New Button()
        add_dept_btn = New Button()
        dept_gridview = New DataGridView()
        dep_col = New DataGridViewTextBoxColumn()
        dep_desc = New DataGridViewTextBoxColumn()
        action_col = New DataGridViewTextBoxColumn()
        Label11 = New Label()
        PictureBox5 = New PictureBox()
        TabPage5 = New TabPage()
        TextBox1 = New TextBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label12 = New Label()
        PictureBox2 = New PictureBox()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        Panel7.SuspendLayout()
        CType(employee_grid_view, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TabPage1.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage4.SuspendLayout()
        Panel12.SuspendLayout()
        CType(dept_gridview, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        TabPage5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(134), CByte(134), CByte(134))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(printreport_btn)
        Panel1.Controls.Add(branch_btn)
        Panel1.Controls.Add(department_btn)
        Panel1.Controls.Add(employee_btn)
        Panel1.Controls.Add(dashboard_btn)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(214, 1000)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(36, 217)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 32)
        Label2.TabIndex = 0
        Label2.Text = "C.C.F"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(-24, 338)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 25)
        Label1.TabIndex = 0
        Label1.Text = "________________________________"
        ' 
        ' printreport_btn
        ' 
        printreport_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        printreport_btn.Image = My.Resources.Resources.report_card
        printreport_btn.ImageAlign = ContentAlignment.MiddleLeft
        printreport_btn.Location = New Point(14, 668)
        printreport_btn.Margin = New Padding(4, 5, 4, 5)
        printreport_btn.Name = "printreport_btn"
        printreport_btn.Size = New Size(186, 67)
        printreport_btn.TabIndex = 2
        printreport_btn.Text = "Reports"
        printreport_btn.UseVisualStyleBackColor = True
        ' 
        ' branch_btn
        ' 
        branch_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        branch_btn.Image = My.Resources.Resources.branch
        branch_btn.ImageAlign = ContentAlignment.MiddleLeft
        branch_btn.Location = New Point(14, 483)
        branch_btn.Margin = New Padding(4, 5, 4, 5)
        branch_btn.Name = "branch_btn"
        branch_btn.Size = New Size(186, 67)
        branch_btn.TabIndex = 2
        branch_btn.Text = "Branch"
        branch_btn.UseVisualStyleBackColor = True
        ' 
        ' department_btn
        ' 
        department_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        department_btn.Image = My.Resources.Resources.department
        department_btn.ImageAlign = ContentAlignment.MiddleLeft
        department_btn.Location = New Point(14, 575)
        department_btn.Margin = New Padding(4, 5, 4, 5)
        department_btn.Name = "department_btn"
        department_btn.Size = New Size(186, 67)
        department_btn.TabIndex = 1
        department_btn.Text = "  Department"
        department_btn.UseVisualStyleBackColor = True
        ' 
        ' employee_btn
        ' 
        employee_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        employee_btn.Image = My.Resources.Resources.user__1_1
        employee_btn.ImageAlign = ContentAlignment.MiddleLeft
        employee_btn.Location = New Point(14, 392)
        employee_btn.Margin = New Padding(4, 5, 4, 5)
        employee_btn.Name = "employee_btn"
        employee_btn.Size = New Size(186, 67)
        employee_btn.TabIndex = 1
        employee_btn.Text = "  Employee"
        employee_btn.UseVisualStyleBackColor = True
        ' 
        ' dashboard_btn
        ' 
        dashboard_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dashboard_btn.Image = My.Resources.Resources.home
        dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft
        dashboard_btn.Location = New Point(14, 267)
        dashboard_btn.Margin = New Padding(4, 5, 4, 5)
        dashboard_btn.Name = "dashboard_btn"
        dashboard_btn.Size = New Size(186, 67)
        dashboard_btn.TabIndex = 0
        dashboard_btn.Text = "  Dash Board"
        dashboard_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(209), CByte(210), CByte(210))
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(14, 17)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(186, 183)
        Panel3.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.user
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(21, 17)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(143, 150)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(209), CByte(210), CByte(210))
        Panel2.Controls.Add(Button1)
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(153, -17)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(850, 50)
        Panel2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = My.Resources.Resources.setting
        Button1.Location = New Point(810, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(35, 35)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(sanfrancisco_branch_btn)
        TabPage3.Controls.Add(batasan_branch_btn)
        TabPage3.Controls.Add(sanbartolome_branch_btn)
        TabPage3.Controls.Add(Panel10)
        TabPage3.Controls.Add(Panel9)
        TabPage3.Controls.Add(Panel8)
        TabPage3.Controls.Add(Label9)
        TabPage3.Controls.Add(PictureBox4)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Margin = New Padding(4, 5, 4, 5)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(4, 5, 4, 5)
        TabPage3.Size = New Size(1206, 919)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' sanfrancisco_branch_btn
        ' 
        sanfrancisco_branch_btn.FlatAppearance.BorderSize = 0
        sanfrancisco_branch_btn.FlatStyle = FlatStyle.Flat
        sanfrancisco_branch_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        sanfrancisco_branch_btn.Location = New Point(580, 83)
        sanfrancisco_branch_btn.Margin = New Padding(4, 5, 4, 5)
        sanfrancisco_branch_btn.Name = "sanfrancisco_branch_btn"
        sanfrancisco_branch_btn.Size = New Size(243, 100)
        sanfrancisco_branch_btn.TabIndex = 15
        sanfrancisco_branch_btn.Text = "QCU" & vbCrLf & "San. Francisco"
        sanfrancisco_branch_btn.TextAlign = ContentAlignment.MiddleLeft
        sanfrancisco_branch_btn.UseVisualStyleBackColor = True
        ' 
        ' batasan_branch_btn
        ' 
        batasan_branch_btn.FlatAppearance.BorderSize = 0
        batasan_branch_btn.FlatStyle = FlatStyle.Flat
        batasan_branch_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        batasan_branch_btn.Location = New Point(319, 83)
        batasan_branch_btn.Margin = New Padding(4, 5, 4, 5)
        batasan_branch_btn.Name = "batasan_branch_btn"
        batasan_branch_btn.Size = New Size(243, 100)
        batasan_branch_btn.TabIndex = 14
        batasan_branch_btn.Text = "QCU" & vbCrLf & "Batasan"
        batasan_branch_btn.TextAlign = ContentAlignment.MiddleLeft
        batasan_branch_btn.UseVisualStyleBackColor = True
        ' 
        ' sanbartolome_branch_btn
        ' 
        sanbartolome_branch_btn.FlatAppearance.BorderSize = 0
        sanbartolome_branch_btn.FlatStyle = FlatStyle.Flat
        sanbartolome_branch_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        sanbartolome_branch_btn.Location = New Point(57, 83)
        sanbartolome_branch_btn.Margin = New Padding(4, 5, 4, 5)
        sanbartolome_branch_btn.Name = "sanbartolome_branch_btn"
        sanbartolome_branch_btn.Size = New Size(243, 100)
        sanbartolome_branch_btn.TabIndex = 13
        sanbartolome_branch_btn.Text = "QCU" & vbCrLf & "San. Bartolome"
        sanbartolome_branch_btn.TextAlign = ContentAlignment.MiddleLeft
        sanbartolome_branch_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Red
        Panel10.ForeColor = Color.Black
        Panel10.Location = New Point(570, 83)
        Panel10.Margin = New Padding(4, 5, 4, 5)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(7, 100)
        Panel10.TabIndex = 12
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Yellow
        Panel9.ForeColor = Color.Black
        Panel9.Location = New Point(309, 83)
        Panel9.Margin = New Padding(4, 5, 4, 5)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(7, 100)
        Panel9.TabIndex = 12
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Blue
        Panel8.ForeColor = Color.Black
        Panel8.Location = New Point(50, 83)
        Panel8.Margin = New Padding(4, 5, 4, 5)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(7, 100)
        Panel8.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(9, 17)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 40)
        Label9.TabIndex = 10
        Label9.Text = "Branch"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(901, 83)
        PictureBox4.Margin = New Padding(4, 5, 4, 5)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(257, 833)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Panel7)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(employee_grid_view)
        TabPage2.Controls.Add(PictureBox3)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Margin = New Padding(4, 5, 4, 5)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4, 5, 4, 5)
        TabPage2.Size = New Size(1206, 919)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Label4)
        Panel7.Controls.Add(Label3)
        Panel7.Controls.Add(add_employees_btn)
        Panel7.Controls.Add(id_employees_tb)
        Panel7.Location = New Point(29, 102)
        Panel7.Margin = New Padding(4, 5, 4, 5)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1144, 67)
        Panel7.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(439, 23)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 25)
        Label4.TabIndex = 12
        Label4.Text = "department ---"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(326, 23)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 25)
        Label3.TabIndex = 11
        Label3.Text = "branch ---"
        ' 
        ' add_employees_btn
        ' 
        add_employees_btn.BackColor = Color.Red
        add_employees_btn.FlatAppearance.BorderColor = Color.Red
        add_employees_btn.FlatStyle = FlatStyle.Flat
        add_employees_btn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        add_employees_btn.ForeColor = Color.White
        add_employees_btn.Location = New Point(1021, 17)
        add_employees_btn.Margin = New Padding(4, 5, 4, 5)
        add_employees_btn.Name = "add_employees_btn"
        add_employees_btn.Size = New Size(107, 38)
        add_employees_btn.TabIndex = 3
        add_employees_btn.Text = "Add"
        add_employees_btn.UseVisualStyleBackColor = False
        ' 
        ' id_employees_tb
        ' 
        id_employees_tb.Location = New Point(4, 15)
        id_employees_tb.Margin = New Padding(4, 5, 4, 5)
        id_employees_tb.Name = "id_employees_tb"
        id_employees_tb.PlaceholderText = "search"
        id_employees_tb.Size = New Size(310, 31)
        id_employees_tb.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(9, 17)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(164, 40)
        Label7.TabIndex = 9
        Label7.Text = "Employees"
        ' 
        ' employee_grid_view
        ' 
        employee_grid_view.AllowUserToAddRows = False
        employee_grid_view.AllowUserToDeleteRows = False
        employee_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        employee_grid_view.Columns.AddRange(New DataGridViewColumn() {id_col, name_col, shift_col, gender_col, dob_col, hired_col, act_col})
        employee_grid_view.Location = New Point(29, 167)
        employee_grid_view.Margin = New Padding(4, 5, 4, 5)
        employee_grid_view.Name = "employee_grid_view"
        employee_grid_view.ReadOnly = True
        employee_grid_view.RowHeadersWidth = 62
        employee_grid_view.Size = New Size(1144, 666)
        employee_grid_view.TabIndex = 2
        ' 
        ' id_col
        ' 
        id_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        id_col.FillWeight = 147.608124F
        id_col.HeaderText = "Employoee Code"
        id_col.MinimumWidth = 8
        id_col.Name = "id_col"
        id_col.ReadOnly = True
        ' 
        ' name_col
        ' 
        name_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        name_col.FillWeight = 170.55838F
        name_col.HeaderText = "Name"
        name_col.MinimumWidth = 8
        name_col.Name = "name_col"
        name_col.ReadOnly = True
        ' 
        ' shift_col
        ' 
        shift_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        shift_col.FillWeight = 76.3667F
        shift_col.HeaderText = "Email"
        shift_col.MinimumWidth = 8
        shift_col.Name = "shift_col"
        shift_col.ReadOnly = True
        ' 
        ' gender_col
        ' 
        gender_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        gender_col.FillWeight = 76.3667F
        gender_col.HeaderText = "Gender"
        gender_col.MinimumWidth = 8
        gender_col.Name = "gender_col"
        gender_col.ReadOnly = True
        ' 
        ' dob_col
        ' 
        dob_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dob_col.FillWeight = 76.3667F
        dob_col.HeaderText = "DOB"
        dob_col.MinimumWidth = 8
        dob_col.Name = "dob_col"
        dob_col.ReadOnly = True
        ' 
        ' hired_col
        ' 
        hired_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        hired_col.FillWeight = 76.3667F
        hired_col.HeaderText = "Department"
        hired_col.MinimumWidth = 8
        hired_col.Name = "hired_col"
        hired_col.ReadOnly = True
        ' 
        ' act_col
        ' 
        act_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        act_col.FillWeight = 76.3667F
        act_col.HeaderText = "Action"
        act_col.MinimumWidth = 8
        act_col.Name = "act_col"
        act_col.ReadOnly = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox3.Location = New Point(901, 83)
        PictureBox3.Margin = New Padding(4, 5, 4, 5)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(257, 833)
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Stats_button3)
        TabPage1.Controls.Add(Stats_button4)
        TabPage1.Controls.Add(Stats_button2)
        TabPage1.Controls.Add(Stats_button1)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(PictureBox6)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Margin = New Padding(4, 5, 4, 5)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4, 5, 4, 5)
        TabPage1.Size = New Size(1206, 919)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Stats_button3
        ' 
        Stats_button3.BackColor = SystemColors.Control
        Stats_button3.Counter = "200"
        Stats_button3.Label = "-----"
        Stats_button3.Location = New Point(652, 340)
        Stats_button3.Margin = New Padding(0)
        Stats_button3.Name = "Stats_button3"
        Stats_button3.Size = New Size(443, 156)
        Stats_button3.TabIndex = 12
        ' 
        ' Stats_button4
        ' 
        Stats_button4.BackColor = SystemColors.Control
        Stats_button4.Counter = "200"
        Stats_button4.Label = "-----"
        Stats_button4.Location = New Point(110, 340)
        Stats_button4.Margin = New Padding(0)
        Stats_button4.Name = "Stats_button4"
        Stats_button4.Size = New Size(443, 156)
        Stats_button4.TabIndex = 11
        ' 
        ' Stats_button2
        ' 
        Stats_button2.BackColor = SystemColors.Control
        Stats_button2.Counter = "200"
        Stats_button2.Label = "-----"
        Stats_button2.Location = New Point(652, 134)
        Stats_button2.Margin = New Padding(0)
        Stats_button2.Name = "Stats_button2"
        Stats_button2.Size = New Size(443, 156)
        Stats_button2.TabIndex = 10
        ' 
        ' Stats_button1
        ' 
        Stats_button1.BackColor = SystemColors.Control
        Stats_button1.Counter = "200"
        Stats_button1.Label = "-----"
        Stats_button1.Location = New Point(110, 134)
        Stats_button1.Margin = New Padding(0)
        Stats_button1.Name = "Stats_button1"
        Stats_button1.Size = New Size(443, 156)
        Stats_button1.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(20, 17)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(175, 40)
        Label6.TabIndex = 8
        Label6.Text = "Dash Board"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox6.Location = New Point(901, 83)
        PictureBox6.Margin = New Padding(4, 5, 4, 5)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(257, 833)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 1
        PictureBox6.TabStop = False
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Address"
        Column2.MinimumWidth = 9
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 175
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Description"
        Column1.MinimumWidth = 9
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 175
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Location = New Point(214, 43)
        TabControl1.Margin = New Padding(4, 5, 4, 5)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1214, 957)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Panel12)
        TabPage4.Controls.Add(dept_gridview)
        TabPage4.Controls.Add(Label11)
        TabPage4.Controls.Add(PictureBox5)
        TabPage4.Location = New Point(4, 34)
        TabPage4.Margin = New Padding(4, 5, 4, 5)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(4, 5, 4, 5)
        TabPage4.Size = New Size(1206, 919)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TabPage4"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Panel12
        ' 
        Panel12.Controls.Add(id_dept_tb)
        Panel12.Controls.Add(Update_btn_dept)
        Panel12.Controls.Add(add_dept_btn)
        Panel12.Location = New Point(29, 102)
        Panel12.Margin = New Padding(4, 5, 4, 5)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(1144, 67)
        Panel12.TabIndex = 13
        ' 
        ' id_dept_tb
        ' 
        id_dept_tb.Location = New Point(4, 15)
        id_dept_tb.Margin = New Padding(4, 5, 4, 5)
        id_dept_tb.Name = "id_dept_tb"
        id_dept_tb.PlaceholderText = "search"
        id_dept_tb.Size = New Size(310, 31)
        id_dept_tb.TabIndex = 5
        ' 
        ' Update_btn_dept
        ' 
        Update_btn_dept.BackColor = Color.Red
        Update_btn_dept.FlatAppearance.BorderColor = Color.Red
        Update_btn_dept.FlatStyle = FlatStyle.Flat
        Update_btn_dept.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Update_btn_dept.ForeColor = Color.White
        Update_btn_dept.Location = New Point(873, 17)
        Update_btn_dept.Margin = New Padding(4, 5, 4, 5)
        Update_btn_dept.Name = "Update_btn_dept"
        Update_btn_dept.Size = New Size(107, 38)
        Update_btn_dept.TabIndex = 4
        Update_btn_dept.Text = "Update"
        Update_btn_dept.UseVisualStyleBackColor = False
        ' 
        ' add_dept_btn
        ' 
        add_dept_btn.BackColor = Color.Red
        add_dept_btn.FlatAppearance.BorderColor = Color.Red
        add_dept_btn.FlatStyle = FlatStyle.Flat
        add_dept_btn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        add_dept_btn.ForeColor = Color.White
        add_dept_btn.Location = New Point(1021, 17)
        add_dept_btn.Margin = New Padding(4, 5, 4, 5)
        add_dept_btn.Name = "add_dept_btn"
        add_dept_btn.Size = New Size(107, 38)
        add_dept_btn.TabIndex = 3
        add_dept_btn.Text = "Add"
        add_dept_btn.UseVisualStyleBackColor = False
        ' 
        ' dept_gridview
        ' 
        dept_gridview.AllowUserToAddRows = False
        dept_gridview.AllowUserToDeleteRows = False
        dept_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dept_gridview.Columns.AddRange(New DataGridViewColumn() {dep_col, dep_desc, action_col})
        dept_gridview.Location = New Point(29, 168)
        dept_gridview.Margin = New Padding(4, 5, 4, 5)
        dept_gridview.Name = "dept_gridview"
        dept_gridview.ReadOnly = True
        dept_gridview.RowHeadersWidth = 62
        dept_gridview.Size = New Size(1144, 652)
        dept_gridview.TabIndex = 12
        ' 
        ' dep_col
        ' 
        dep_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dep_col.HeaderText = "Department Name"
        dep_col.MinimumWidth = 8
        dep_col.Name = "dep_col"
        dep_col.ReadOnly = True
        ' 
        ' dep_desc
        ' 
        dep_desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dep_desc.FillWeight = 100.1044F
        dep_desc.HeaderText = "Department Description"
        dep_desc.MinimumWidth = 50
        dep_desc.Name = "dep_desc"
        dep_desc.ReadOnly = True
        ' 
        ' action_col
        ' 
        action_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        action_col.FillWeight = 50F
        action_col.HeaderText = "Action"
        action_col.MinimumWidth = 50
        action_col.Name = "action_col"
        action_col.ReadOnly = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(9, 17)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(184, 40)
        Label11.TabIndex = 11
        Label11.Text = "Department"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(901, 83)
        PictureBox5.Margin = New Padding(4, 5, 4, 5)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(257, 833)
        PictureBox5.TabIndex = 2
        PictureBox5.TabStop = False
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(TextBox1)
        TabPage5.Controls.Add(ComboBox2)
        TabPage5.Controls.Add(ComboBox1)
        TabPage5.Controls.Add(DateTimePicker2)
        TabPage5.Controls.Add(DateTimePicker1)
        TabPage5.Controls.Add(Label12)
        TabPage5.Controls.Add(PictureBox2)
        TabPage5.Location = New Point(4, 34)
        TabPage5.Margin = New Padding(4, 5, 4, 5)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(4, 5, 4, 5)
        TabPage5.Size = New Size(1206, 919)
        TabPage5.TabIndex = 4
        TabPage5.Text = "TabPage5"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(344, 120)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "employee"
        TextBox1.Size = New Size(190, 31)
        TextBox1.TabIndex = 18
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(176, 119)
        ComboBox2.Margin = New Padding(4, 5, 4, 5)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(150, 33)
        ComboBox2.TabIndex = 16
        ComboBox2.Text = "San, Bartolome"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(9, 119)
        ComboBox1.Margin = New Padding(4, 5, 4, 5)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(150, 33)
        ComboBox1.TabIndex = 14
        ComboBox1.Text = "San, Bartolome"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(303, 78)
        DateTimePicker2.Margin = New Padding(4, 5, 4, 5)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(284, 31)
        DateTimePicker2.TabIndex = 13
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(9, 78)
        DateTimePicker1.Margin = New Padding(4, 5, 4, 5)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(284, 31)
        DateTimePicker1.TabIndex = 12
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(13, 22)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(111, 40)
        Label12.TabIndex = 11
        Label12.Text = "Report"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(901, 83)
        PictureBox2.Margin = New Padding(4, 5, 4, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(257, 833)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' admindashboardform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1467, 929)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "admindashboardform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(employee_grid_view, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        CType(dept_gridview, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents dashboard_btn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents printreport_btn As Button
    Friend WithEvents branch_btn As Button
    Friend WithEvents department_btn As Button
    Friend WithEvents employee_btn As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents sanfrancisco_branch_btn As Button
    Friend WithEvents batasan_branch_btn As Button
    Friend WithEvents sanbartolome_branch_btn As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel7 As Panel
    Friend WithEvents add_employees_btn As Button
    Friend WithEvents id_employees_tb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents employee_grid_view As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents add_dept_btn As Button
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents id_col As DataGridViewTextBoxColumn
    Friend WithEvents name_col As DataGridViewTextBoxColumn
    Friend WithEvents shift_col As DataGridViewTextBoxColumn
    Friend WithEvents gender_col As DataGridViewTextBoxColumn
    Friend WithEvents dob_col As DataGridViewTextBoxColumn
    Friend WithEvents hired_col As DataGridViewTextBoxColumn
    Friend WithEvents act_col As DataGridViewTextBoxColumn
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents depa As DataGridView
    Friend WithEvents dept_gridview As DataGridView
    Friend WithEvents dep_col As DataGridViewTextBoxColumn
    Friend WithEvents dep_desc As DataGridViewTextBoxColumn
    Friend WithEvents action_col As DataGridViewTextBoxColumn
    Friend WithEvents Update_btn_dept As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents id_dept_tb As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Stats_button1 As stats_button
    Friend WithEvents Stats_button2 As stats_button
    Friend WithEvents Stats_button3 As stats_button
    Friend WithEvents Stats_button4 As stats_button
End Class
