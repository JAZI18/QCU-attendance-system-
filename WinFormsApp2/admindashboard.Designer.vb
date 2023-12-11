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
        nav_panel = New Panel()
        Nav1 = New nav()
        printreport_btn = New Button()
        branch_btn = New Button()
        department_btn = New Button()
        employee_btn = New Button()
        dashboard_btn = New Button()
        Label2 = New Label()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Button1 = New Button()
        TabPage3 = New TabPage()
        absent_stat = New stats_button()
        leave_stat = New stats_button()
        present_stat = New stats_button()
        total_stat = New stats_button()
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
        clear_filter_btn = New Button()
        dep_filter_btn = New Label()
        branch_filter_lb = New Label()
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
        act_col = New DataGridViewButtonColumn()
        PictureBox3 = New PictureBox()
        TabPage1 = New TabPage()
        Panel4 = New Panel()
        main_absent_stat = New stats_button()
        Label6 = New Label()
        main_leave_stat = New stats_button()
        main_present_stat = New stats_button()
        main_total_stat = New stats_button()
        PictureBox6 = New PictureBox()
        Column2 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        TabControl1 = New TabControl()
        TabPage4 = New TabPage()
        Panel12 = New Panel()
        id_dept_tb = New TextBox()
        search_btn_dept = New Button()
        add_dept_btn = New Button()
        dept_gridview = New DataGridView()
        Id = New DataGridViewTextBoxColumn()
        dep_col = New DataGridViewTextBoxColumn()
        dep_desc = New DataGridViewTextBoxColumn()
        action_col = New DataGridViewButtonColumn()
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
        nav_panel.SuspendLayout()
        Nav1.SuspendLayout()
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
        ' nav_panel
        ' 
        nav_panel.BackColor = SystemColors.ButtonShadow
        nav_panel.Controls.Add(Nav1)
        nav_panel.Controls.Add(Panel3)
        nav_panel.Dock = DockStyle.Left
        nav_panel.Location = New Point(0, 0)
        nav_panel.Name = "nav_panel"
        nav_panel.Size = New Size(161, 583)
        nav_panel.TabIndex = 0
        ' 
        ' Nav1
        ' 
        Nav1.Controls.Add(printreport_btn)
        Nav1.Controls.Add(branch_btn)
        Nav1.Controls.Add(department_btn)
        Nav1.Controls.Add(employee_btn)
        Nav1.Controls.Add(dashboard_btn)
        Nav1.Controls.Add(Label2)
        Nav1.Dock = DockStyle.Bottom
        Nav1.HighlightBackColor = Color.White
        Nav1.Location = New Point(0, 150)
        Nav1.Margin = New Padding(2)
        Nav1.Name = "Nav1"
        Nav1.NormalBackColor = SystemColors.ControlDark
        Nav1.Size = New Size(161, 433)
        Nav1.TabIndex = 3
        Nav1.Text = "Nav1"
        ' 
        ' printreport_btn
        ' 
        printreport_btn.BackColor = SystemColors.ControlDark
        printreport_btn.Dock = DockStyle.Top
        printreport_btn.FlatAppearance.BorderSize = 0
        printreport_btn.FlatStyle = FlatStyle.Flat
        printreport_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        printreport_btn.Image = My.Resources.Resources.report_card
        printreport_btn.ImageAlign = ContentAlignment.MiddleLeft
        printreport_btn.Location = New Point(0, 271)
        printreport_btn.Margin = New Padding(0)
        printreport_btn.Name = "printreport_btn"
        printreport_btn.Padding = New Padding(10, 0, 0, 0)
        printreport_btn.Size = New Size(161, 55)
        printreport_btn.TabIndex = 6
        printreport_btn.Text = "  Reports"
        printreport_btn.TextAlign = ContentAlignment.MiddleLeft
        printreport_btn.TextImageRelation = TextImageRelation.ImageBeforeText
        printreport_btn.UseCompatibleTextRendering = True
        printreport_btn.UseVisualStyleBackColor = False
        ' 
        ' branch_btn
        ' 
        branch_btn.BackColor = SystemColors.ButtonShadow
        branch_btn.Dock = DockStyle.Top
        branch_btn.FlatAppearance.BorderSize = 0
        branch_btn.FlatStyle = FlatStyle.Flat
        branch_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        branch_btn.Image = My.Resources.Resources.branch
        branch_btn.ImageAlign = ContentAlignment.MiddleLeft
        branch_btn.Location = New Point(0, 216)
        branch_btn.Margin = New Padding(0)
        branch_btn.Name = "branch_btn"
        branch_btn.Padding = New Padding(10, 0, 0, 0)
        branch_btn.Size = New Size(161, 55)
        branch_btn.TabIndex = 7
        branch_btn.Text = "  Branch"
        branch_btn.TextAlign = ContentAlignment.MiddleLeft
        branch_btn.TextImageRelation = TextImageRelation.ImageBeforeText
        branch_btn.UseCompatibleTextRendering = True
        branch_btn.UseVisualStyleBackColor = False
        ' 
        ' department_btn
        ' 
        department_btn.BackColor = SystemColors.ButtonShadow
        department_btn.Dock = DockStyle.Top
        department_btn.FlatAppearance.BorderSize = 0
        department_btn.FlatStyle = FlatStyle.Flat
        department_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        department_btn.Image = My.Resources.Resources.department
        department_btn.ImageAlign = ContentAlignment.MiddleLeft
        department_btn.Location = New Point(0, 161)
        department_btn.Margin = New Padding(0)
        department_btn.Name = "department_btn"
        department_btn.Padding = New Padding(10, 0, 0, 0)
        department_btn.Size = New Size(161, 55)
        department_btn.TabIndex = 4
        department_btn.Text = "  Department"
        department_btn.TextAlign = ContentAlignment.MiddleLeft
        department_btn.TextImageRelation = TextImageRelation.ImageBeforeText
        department_btn.UseCompatibleTextRendering = True
        department_btn.UseVisualStyleBackColor = False
        ' 
        ' employee_btn
        ' 
        employee_btn.BackColor = Color.Transparent
        employee_btn.Dock = DockStyle.Top
        employee_btn.FlatAppearance.BorderSize = 0
        employee_btn.FlatStyle = FlatStyle.Flat
        employee_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        employee_btn.Image = My.Resources.Resources.user__1_1
        employee_btn.ImageAlign = ContentAlignment.MiddleLeft
        employee_btn.Location = New Point(0, 106)
        employee_btn.Margin = New Padding(0)
        employee_btn.Name = "employee_btn"
        employee_btn.Padding = New Padding(10, 0, 0, 0)
        employee_btn.Size = New Size(161, 55)
        employee_btn.TabIndex = 5
        employee_btn.Text = "  Employee"
        employee_btn.TextAlign = ContentAlignment.MiddleLeft
        employee_btn.TextImageRelation = TextImageRelation.ImageBeforeText
        employee_btn.UseCompatibleTextRendering = True
        employee_btn.UseVisualStyleBackColor = False
        ' 
        ' dashboard_btn
        ' 
        dashboard_btn.BackColor = Color.Transparent
        dashboard_btn.Dock = DockStyle.Top
        dashboard_btn.FlatAppearance.BorderColor = Color.CadetBlue
        dashboard_btn.FlatAppearance.BorderSize = 0
        dashboard_btn.FlatStyle = FlatStyle.Flat
        dashboard_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dashboard_btn.Image = My.Resources.Resources.home
        dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft
        dashboard_btn.Location = New Point(0, 51)
        dashboard_btn.Margin = New Padding(0)
        dashboard_btn.Name = "dashboard_btn"
        dashboard_btn.Padding = New Padding(10, 0, 0, 0)
        dashboard_btn.Size = New Size(161, 55)
        dashboard_btn.TabIndex = 0
        dashboard_btn.Text = "  Dash Board"
        dashboard_btn.TextAlign = ContentAlignment.MiddleLeft
        dashboard_btn.TextImageRelation = TextImageRelation.ImageBeforeText
        dashboard_btn.UseCompatibleTextRendering = True
        dashboard_btn.UseMnemonic = False
        dashboard_btn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 51)
        Label2.TabIndex = 0
        Label2.Text = "C.C.F"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(209), CByte(210), CByte(210))
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(10, 10)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(130, 110)
        Panel3.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.qcu
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(130, 110)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
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
        TabPage3.Controls.Add(absent_stat)
        TabPage3.Controls.Add(leave_stat)
        TabPage3.Controls.Add(present_stat)
        TabPage3.Controls.Add(total_stat)
        TabPage3.Controls.Add(sanfrancisco_branch_btn)
        TabPage3.Controls.Add(batasan_branch_btn)
        TabPage3.Controls.Add(sanbartolome_branch_btn)
        TabPage3.Controls.Add(Panel10)
        TabPage3.Controls.Add(Panel9)
        TabPage3.Controls.Add(Panel8)
        TabPage3.Controls.Add(Label9)
        TabPage3.Controls.Add(PictureBox4)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(842, 503)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' absent_stat
        ' 
        absent_stat.BackColor = Color.FromArgb(CByte(242), CByte(200), CByte(200))
        absent_stat.Counter = "200"
        absent_stat.Label = "ABSENT:"
        absent_stat.Location = New Point(458, 327)
        absent_stat.Margin = New Padding(0)
        absent_stat.Name = "absent_stat"
        absent_stat.Size = New Size(310, 151)
        absent_stat.TabIndex = 20
        ' 
        ' leave_stat
        ' 
        leave_stat.BackColor = Color.FromArgb(CByte(233), CByte(193), CByte(240))
        leave_stat.Counter = "200"
        leave_stat.Label = "LEAVE:"
        leave_stat.Location = New Point(79, 327)
        leave_stat.Margin = New Padding(0)
        leave_stat.Name = "leave_stat"
        leave_stat.Size = New Size(310, 151)
        leave_stat.TabIndex = 19
        ' 
        ' present_stat
        ' 
        present_stat.BackColor = Color.FromArgb(CByte(205), CByte(241), CByte(197))
        present_stat.Counter = "200"
        present_stat.Label = "PRESENT:"
        present_stat.Location = New Point(458, 138)
        present_stat.Margin = New Padding(0)
        present_stat.Name = "present_stat"
        present_stat.Size = New Size(310, 151)
        present_stat.TabIndex = 18
        ' 
        ' total_stat
        ' 
        total_stat.BackColor = Color.FromArgb(CByte(240), CByte(239), CByte(193))
        total_stat.Counter = "200"
        total_stat.Label = "TOTAL:"
        total_stat.Location = New Point(79, 138)
        total_stat.Margin = New Padding(0)
        total_stat.Name = "total_stat"
        total_stat.Size = New Size(310, 151)
        total_stat.TabIndex = 17
        ' 
        ' sanfrancisco_branch_btn
        ' 
        sanfrancisco_branch_btn.FlatAppearance.BorderSize = 0
        sanfrancisco_branch_btn.FlatStyle = FlatStyle.Flat
        sanfrancisco_branch_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        sanfrancisco_branch_btn.Location = New Point(448, 50)
        sanfrancisco_branch_btn.Name = "sanfrancisco_branch_btn"
        sanfrancisco_branch_btn.Size = New Size(170, 60)
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
        batasan_branch_btn.Location = New Point(265, 50)
        batasan_branch_btn.Name = "batasan_branch_btn"
        batasan_branch_btn.Size = New Size(170, 60)
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
        sanbartolome_branch_btn.Location = New Point(82, 50)
        sanbartolome_branch_btn.Name = "sanbartolome_branch_btn"
        sanbartolome_branch_btn.Size = New Size(170, 60)
        sanbartolome_branch_btn.TabIndex = 13
        sanbartolome_branch_btn.Text = "QCU" & vbCrLf & "San. Bartolome"
        sanbartolome_branch_btn.TextAlign = ContentAlignment.MiddleLeft
        sanbartolome_branch_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Red
        Panel10.ForeColor = Color.Black
        Panel10.Location = New Point(441, 50)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(5, 60)
        Panel10.TabIndex = 12
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Yellow
        Panel9.ForeColor = Color.Black
        Panel9.Location = New Point(258, 50)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(5, 60)
        Panel9.TabIndex = 12
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Blue
        Panel8.ForeColor = Color.Black
        Panel8.Location = New Point(77, 50)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(5, 60)
        Panel8.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(6, 10)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 25)
        Label9.TabIndex = 10
        Label9.Text = "Branch"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(631, 50)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(180, 500)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Panel7)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(employee_grid_view)
        TabPage2.Controls.Add(PictureBox3)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(842, 503)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(clear_filter_btn)
        Panel7.Controls.Add(dep_filter_btn)
        Panel7.Controls.Add(branch_filter_lb)
        Panel7.Controls.Add(add_employees_btn)
        Panel7.Controls.Add(id_employees_tb)
        Panel7.Location = New Point(20, 61)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(801, 40)
        Panel7.TabIndex = 10
        ' 
        ' clear_filter_btn
        ' 
        clear_filter_btn.Location = New Point(611, 9)
        clear_filter_btn.Name = "clear_filter_btn"
        clear_filter_btn.Size = New Size(75, 23)
        clear_filter_btn.TabIndex = 13
        clear_filter_btn.Text = "clear filters"
        clear_filter_btn.UseVisualStyleBackColor = True
        ' 
        ' dep_filter_btn
        ' 
        dep_filter_btn.AutoSize = True
        dep_filter_btn.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        dep_filter_btn.Location = New Point(326, 10)
        dep_filter_btn.Name = "dep_filter_btn"
        dep_filter_btn.Size = New Size(103, 19)
        dep_filter_btn.TabIndex = 12
        dep_filter_btn.Text = "department ---"
        ' 
        ' branch_filter_lb
        ' 
        branch_filter_lb.AutoSize = True
        branch_filter_lb.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        branch_filter_lb.Location = New Point(228, 10)
        branch_filter_lb.Name = "branch_filter_lb"
        branch_filter_lb.Size = New Size(73, 19)
        branch_filter_lb.TabIndex = 11
        branch_filter_lb.Text = "branch ---"
        ' 
        ' add_employees_btn
        ' 
        add_employees_btn.BackColor = Color.Red
        add_employees_btn.FlatAppearance.BorderColor = Color.Red
        add_employees_btn.FlatStyle = FlatStyle.Flat
        add_employees_btn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        add_employees_btn.ForeColor = Color.White
        add_employees_btn.Location = New Point(715, 10)
        add_employees_btn.Name = "add_employees_btn"
        add_employees_btn.Size = New Size(75, 23)
        add_employees_btn.TabIndex = 3
        add_employees_btn.Text = "Add"
        add_employees_btn.UseVisualStyleBackColor = False
        ' 
        ' id_employees_tb
        ' 
        id_employees_tb.Location = New Point(3, 9)
        id_employees_tb.Name = "id_employees_tb"
        id_employees_tb.PlaceholderText = "search"
        id_employees_tb.Size = New Size(218, 23)
        id_employees_tb.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(6, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 25)
        Label7.TabIndex = 9
        Label7.Text = "Employees"
        ' 
        ' employee_grid_view
        ' 
        employee_grid_view.AllowUserToAddRows = False
        employee_grid_view.AllowUserToDeleteRows = False
        employee_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        employee_grid_view.Columns.AddRange(New DataGridViewColumn() {id_col, name_col, shift_col, gender_col, dob_col, hired_col, act_col})
        employee_grid_view.Location = New Point(20, 100)
        employee_grid_view.Name = "employee_grid_view"
        employee_grid_view.ReadOnly = True
        employee_grid_view.RowHeadersWidth = 62
        employee_grid_view.Size = New Size(801, 400)
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
        act_col.Resizable = DataGridViewTriState.True
        act_col.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox3.Location = New Point(631, 50)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(180, 500)
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Panel4)
        TabPage1.Controls.Add(main_absent_stat)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(main_leave_stat)
        TabPage1.Controls.Add(main_present_stat)
        TabPage1.Controls.Add(main_total_stat)
        TabPage1.Controls.Add(PictureBox6)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(842, 503)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ControlLight
        Panel4.Location = New Point(79, 50)
        Panel4.Margin = New Padding(2)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(7, 0, 0, 0)
        Panel4.Size = New Size(690, 80)
        Panel4.TabIndex = 17
        ' 
        ' main_absent_stat
        ' 
        main_absent_stat.BackColor = Color.FromArgb(CByte(242), CByte(200), CByte(200))
        main_absent_stat.Counter = "200"
        main_absent_stat.Label = "ABSENT:"
        main_absent_stat.Location = New Point(458, 328)
        main_absent_stat.Margin = New Padding(0)
        main_absent_stat.Name = "main_absent_stat"
        main_absent_stat.Size = New Size(310, 151)
        main_absent_stat.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(14, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 25)
        Label6.TabIndex = 8
        Label6.Text = "Dash Board"
        ' 
        ' main_leave_stat
        ' 
        main_leave_stat.BackColor = Color.FromArgb(CByte(233), CByte(193), CByte(240))
        main_leave_stat.Counter = "200"
        main_leave_stat.Label = "LEAVE:"
        main_leave_stat.Location = New Point(79, 328)
        main_leave_stat.Margin = New Padding(0)
        main_leave_stat.Name = "main_leave_stat"
        main_leave_stat.Size = New Size(310, 151)
        main_leave_stat.TabIndex = 15
        ' 
        ' main_present_stat
        ' 
        main_present_stat.BackColor = Color.FromArgb(CByte(205), CByte(241), CByte(197))
        main_present_stat.Counter = "200"
        main_present_stat.Label = "PRESENT:"
        main_present_stat.Location = New Point(458, 139)
        main_present_stat.Margin = New Padding(0)
        main_present_stat.Name = "main_present_stat"
        main_present_stat.Size = New Size(310, 151)
        main_present_stat.TabIndex = 14
        ' 
        ' main_total_stat
        ' 
        main_total_stat.BackColor = Color.FromArgb(CByte(240), CByte(239), CByte(193))
        main_total_stat.Counter = "200"
        main_total_stat.Label = "TOTAL:"
        main_total_stat.Location = New Point(79, 139)
        main_total_stat.Margin = New Padding(0)
        main_total_stat.Name = "main_total_stat"
        main_total_stat.Size = New Size(310, 151)
        main_total_stat.TabIndex = 13
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox6.Location = New Point(631, 50)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(180, 500)
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
        TabControl1.Location = New Point(160, 26)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(850, 531)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Panel12)
        TabPage4.Controls.Add(dept_gridview)
        TabPage4.Controls.Add(Label11)
        TabPage4.Controls.Add(PictureBox5)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(842, 503)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TabPage4"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Panel12
        ' 
        Panel12.Controls.Add(id_dept_tb)
        Panel12.Controls.Add(search_btn_dept)
        Panel12.Controls.Add(add_dept_btn)
        Panel12.Location = New Point(20, 61)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(801, 40)
        Panel12.TabIndex = 13
        ' 
        ' id_dept_tb
        ' 
        id_dept_tb.Location = New Point(3, 9)
        id_dept_tb.Name = "id_dept_tb"
        id_dept_tb.PlaceholderText = "search"
        id_dept_tb.Size = New Size(218, 23)
        id_dept_tb.TabIndex = 5
        ' 
        ' search_btn_dept
        ' 
        search_btn_dept.BackColor = Color.Red
        search_btn_dept.FlatAppearance.BorderColor = Color.Red
        search_btn_dept.FlatStyle = FlatStyle.Flat
        search_btn_dept.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        search_btn_dept.ForeColor = Color.White
        search_btn_dept.Location = New Point(227, 11)
        search_btn_dept.Name = "search_btn_dept"
        search_btn_dept.Size = New Size(75, 23)
        search_btn_dept.TabIndex = 4
        search_btn_dept.Text = "Search"
        search_btn_dept.UseVisualStyleBackColor = False
        ' 
        ' add_dept_btn
        ' 
        add_dept_btn.BackColor = Color.Red
        add_dept_btn.FlatAppearance.BorderColor = Color.Red
        add_dept_btn.FlatStyle = FlatStyle.Flat
        add_dept_btn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        add_dept_btn.ForeColor = Color.White
        add_dept_btn.Location = New Point(715, 10)
        add_dept_btn.Name = "add_dept_btn"
        add_dept_btn.Size = New Size(75, 23)
        add_dept_btn.TabIndex = 3
        add_dept_btn.Text = "Add"
        add_dept_btn.UseVisualStyleBackColor = False
        ' 
        ' dept_gridview
        ' 
        dept_gridview.AllowUserToAddRows = False
        dept_gridview.AllowUserToDeleteRows = False
        dept_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dept_gridview.Columns.AddRange(New DataGridViewColumn() {Id, dep_col, dep_desc, action_col})
        dept_gridview.Location = New Point(20, 101)
        dept_gridview.Name = "dept_gridview"
        dept_gridview.ReadOnly = True
        dept_gridview.RowHeadersWidth = 62
        dept_gridview.Size = New Size(801, 391)
        dept_gridview.TabIndex = 12
        ' 
        ' Id
        ' 
        Id.HeaderText = "ID"
        Id.MinimumWidth = 8
        Id.Name = "Id"
        Id.ReadOnly = True
        Id.Width = 150
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
        action_col.Resizable = DataGridViewTriState.True
        action_col.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(6, 10)
        Label11.Name = "Label11"
        Label11.Size = New Size(120, 25)
        Label11.TabIndex = 11
        Label11.Text = "Department"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(631, 50)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(180, 500)
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
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(842, 503)
        TabPage5.TabIndex = 4
        TabPage5.Text = "TabPage5"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(241, 72)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "employee"
        TextBox1.Size = New Size(134, 23)
        TextBox1.TabIndex = 18
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(123, 71)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(106, 23)
        ComboBox2.TabIndex = 16
        ComboBox2.Text = "San, Bartolome"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(6, 71)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(106, 23)
        ComboBox1.TabIndex = 14
        ComboBox1.Text = "San, Bartolome"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(212, 47)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 13
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(6, 47)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 12
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(9, 13)
        Label12.Name = "Label12"
        Label12.Size = New Size(74, 25)
        Label12.TabIndex = 11
        Label12.Text = "Report"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(631, 50)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(180, 500)
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
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1074, 583)
        Controls.Add(TabControl1)
        Controls.Add(nav_panel)
        FormBorderStyle = FormBorderStyle.None
        Name = "admindashboardform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "form2"
        nav_panel.ResumeLayout(False)
        Nav1.ResumeLayout(False)
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

    Friend WithEvents nav_panel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents dashboard_btn As Button
    Friend WithEvents Label2 As Label
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
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents depa As DataGridView
    Friend WithEvents dept_gridview As DataGridView
    Friend WithEvents search_btn_dept As Button
    Friend WithEvents dep_filter_btn As Label
    Friend WithEvents branch_filter_lb As Label
    Friend WithEvents id_dept_tb As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents main_absent_stat As stats_button
    Friend WithEvents main_leave_stat As stats_button
    Friend WithEvents main_present_stat As stats_button
    Friend WithEvents main_total_stat As stats_button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Nav1 As nav
    Friend WithEvents printreport_btn As Button
    Friend WithEvents branch_btn As Button
    Friend WithEvents department_btn As Button
    Friend WithEvents employee_btn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents absent_stat As stats_button
    Friend WithEvents leave_stat As stats_button
    Friend WithEvents present_stat As stats_button
    Friend WithEvents total_stat As stats_button
    Friend WithEvents clear_filter_btn As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents dep_col As DataGridViewTextBoxColumn
    Friend WithEvents dep_desc As DataGridViewTextBoxColumn
    Friend WithEvents action_col As DataGridViewButtonColumn
    Friend WithEvents id_col As DataGridViewTextBoxColumn
    Friend WithEvents name_col As DataGridViewTextBoxColumn
    Friend WithEvents shift_col As DataGridViewTextBoxColumn
    Friend WithEvents gender_col As DataGridViewTextBoxColumn
    Friend WithEvents dob_col As DataGridViewTextBoxColumn
    Friend WithEvents hired_col As DataGridViewTextBoxColumn
    Friend WithEvents act_col As DataGridViewButtonColumn
End Class
