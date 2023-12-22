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
        leave_btn = New Button()
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
        brach_tab = New TabPage()
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
        employees_tab = New TabPage()
        Panel7 = New Panel()
        v_absent = New Button()
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
        dashboard_tab = New TabPage()
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
        leave_tab = New TabPage()
        add_leave_btn = New Button()
        leave_reset_btn = New Button()
        leave_export_btn = New Button()
        leave_print_btn = New Button()
        leave_datagrid = New DataGridView()
        leave_branch_cb = New ComboBox()
        leave_end_date = New DateTimePicker()
        leave_start_date = New DateTimePicker()
        Label1 = New Label()
        PictureBox7 = New PictureBox()
        dept_tab = New TabPage()
        Panel12 = New Panel()
        id_dept_tb = New TextBox()
        add_dept_btn = New Button()
        dept_gridview = New DataGridView()
        Id = New DataGridViewTextBoxColumn()
        dep_col = New DataGridViewTextBoxColumn()
        dep_desc = New DataGridViewTextBoxColumn()
        action_col = New DataGridViewButtonColumn()
        Label11 = New Label()
        PictureBox5 = New PictureBox()
        report_tab = New TabPage()
        Button4 = New Button()
        Button3 = New Button()
        report_print_btn = New Button()
        report_grid_view = New DataGridView()
        report_brach_cb = New ComboBox()
        report_end_date = New DateTimePicker()
        report_start_date = New DateTimePicker()
        Label12 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        nav_panel.SuspendLayout()
        Nav1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        brach_tab.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        employees_tab.SuspendLayout()
        Panel7.SuspendLayout()
        CType(employee_grid_view, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        dashboard_tab.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        leave_tab.SuspendLayout()
        CType(leave_datagrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        dept_tab.SuspendLayout()
        Panel12.SuspendLayout()
        CType(dept_gridview, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        report_tab.SuspendLayout()
        CType(report_grid_view, ComponentModel.ISupportInitialize).BeginInit()
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
        nav_panel.Margin = New Padding(0)
        nav_panel.Name = "nav_panel"
        nav_panel.Size = New Size(160, 473)
        nav_panel.TabIndex = 0
        ' 
        ' Nav1
        ' 
        Nav1.Controls.Add(leave_btn)
        Nav1.Controls.Add(printreport_btn)
        Nav1.Controls.Add(branch_btn)
        Nav1.Controls.Add(department_btn)
        Nav1.Controls.Add(employee_btn)
        Nav1.Controls.Add(dashboard_btn)
        Nav1.Controls.Add(Label2)
        Nav1.Dock = DockStyle.Bottom
        Nav1.HighlightBackColor = Color.White
        Nav1.Location = New Point(0, 40)
        Nav1.Margin = New Padding(0)
        Nav1.Name = "Nav1"
        Nav1.NormalBackColor = SystemColors.ControlDark
        Nav1.Size = New Size(160, 433)
        Nav1.TabIndex = 3
        Nav1.Text = "Nav1"
        ' 
        ' leave_btn
        ' 
        leave_btn.BackColor = SystemColors.ControlDark
        leave_btn.Dock = DockStyle.Top
        leave_btn.FlatAppearance.BorderSize = 0
        leave_btn.FlatStyle = FlatStyle.Flat
        leave_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        leave_btn.Image = My.Resources.Resources.report_card
        leave_btn.ImageAlign = ContentAlignment.MiddleLeft
        leave_btn.Location = New Point(0, 326)
        leave_btn.Margin = New Padding(0)
        leave_btn.Name = "leave_btn"
        leave_btn.Padding = New Padding(10, 0, 0, 0)
        leave_btn.Size = New Size(160, 55)
        leave_btn.TabIndex = 8
        leave_btn.Text = "  Leave"
        leave_btn.TextAlign = ContentAlignment.MiddleLeft
        leave_btn.TextImageRelation = TextImageRelation.ImageBeforeText
        leave_btn.UseCompatibleTextRendering = True
        leave_btn.UseVisualStyleBackColor = False
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
        printreport_btn.Size = New Size(160, 55)
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
        branch_btn.Size = New Size(160, 55)
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
        department_btn.Size = New Size(160, 55)
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
        employee_btn.Size = New Size(160, 55)
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
        dashboard_btn.Size = New Size(160, 55)
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
        Label2.Size = New Size(160, 51)
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
        ' brach_tab
        ' 
        brach_tab.Controls.Add(absent_stat)
        brach_tab.Controls.Add(leave_stat)
        brach_tab.Controls.Add(present_stat)
        brach_tab.Controls.Add(total_stat)
        brach_tab.Controls.Add(sanfrancisco_branch_btn)
        brach_tab.Controls.Add(batasan_branch_btn)
        brach_tab.Controls.Add(sanbartolome_branch_btn)
        brach_tab.Controls.Add(Panel10)
        brach_tab.Controls.Add(Panel9)
        brach_tab.Controls.Add(Panel8)
        brach_tab.Controls.Add(Label9)
        brach_tab.Controls.Add(PictureBox4)
        brach_tab.Location = New Point(4, 24)
        brach_tab.Name = "brach_tab"
        brach_tab.Padding = New Padding(3)
        brach_tab.Size = New Size(842, 503)
        brach_tab.TabIndex = 2
        brach_tab.Text = "TabPage3"
        brach_tab.UseVisualStyleBackColor = True
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
        ' employees_tab
        ' 
        employees_tab.Controls.Add(Panel7)
        employees_tab.Controls.Add(Label7)
        employees_tab.Controls.Add(employee_grid_view)
        employees_tab.Controls.Add(PictureBox3)
        employees_tab.Location = New Point(4, 24)
        employees_tab.Name = "employees_tab"
        employees_tab.Padding = New Padding(3)
        employees_tab.Size = New Size(842, 503)
        employees_tab.TabIndex = 1
        employees_tab.Text = "TabPage2"
        employees_tab.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(v_absent)
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
        ' v_absent
        ' 
        v_absent.BackColor = Color.Blue
        v_absent.FlatAppearance.BorderColor = Color.Red
        v_absent.FlatStyle = FlatStyle.Flat
        v_absent.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        v_absent.ForeColor = Color.White
        v_absent.Location = New Point(611, 8)
        v_absent.Name = "v_absent"
        v_absent.Size = New Size(98, 24)
        v_absent.TabIndex = 14
        v_absent.Text = "View Absent"
        v_absent.UseVisualStyleBackColor = False
        ' 
        ' clear_filter_btn
        ' 
        clear_filter_btn.Location = New Point(530, 8)
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
        ' dashboard_tab
        ' 
        dashboard_tab.Controls.Add(Panel4)
        dashboard_tab.Controls.Add(main_absent_stat)
        dashboard_tab.Controls.Add(Label6)
        dashboard_tab.Controls.Add(main_leave_stat)
        dashboard_tab.Controls.Add(main_present_stat)
        dashboard_tab.Controls.Add(main_total_stat)
        dashboard_tab.Controls.Add(PictureBox6)
        dashboard_tab.Location = New Point(4, 24)
        dashboard_tab.Name = "dashboard_tab"
        dashboard_tab.Padding = New Padding(3)
        dashboard_tab.Size = New Size(842, 503)
        dashboard_tab.TabIndex = 0
        dashboard_tab.Text = "TabPage1"
        dashboard_tab.UseVisualStyleBackColor = True
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
        TabControl1.Controls.Add(leave_tab)
        TabControl1.Controls.Add(dashboard_tab)
        TabControl1.Controls.Add(employees_tab)
        TabControl1.Controls.Add(brach_tab)
        TabControl1.Controls.Add(dept_tab)
        TabControl1.Controls.Add(report_tab)
        TabControl1.Location = New Point(160, 26)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(850, 531)
        TabControl1.TabIndex = 2
        ' 
        ' leave_tab
        ' 
        leave_tab.Controls.Add(add_leave_btn)
        leave_tab.Controls.Add(leave_reset_btn)
        leave_tab.Controls.Add(leave_export_btn)
        leave_tab.Controls.Add(leave_print_btn)
        leave_tab.Controls.Add(leave_datagrid)
        leave_tab.Controls.Add(leave_branch_cb)
        leave_tab.Controls.Add(leave_end_date)
        leave_tab.Controls.Add(leave_start_date)
        leave_tab.Controls.Add(Label1)
        leave_tab.Controls.Add(PictureBox7)
        leave_tab.Location = New Point(4, 24)
        leave_tab.Name = "leave_tab"
        leave_tab.Padding = New Padding(3)
        leave_tab.Size = New Size(842, 503)
        leave_tab.TabIndex = 5
        leave_tab.Text = "TabPage5"
        leave_tab.UseVisualStyleBackColor = True
        ' 
        ' add_leave_btn
        ' 
        add_leave_btn.Location = New Point(708, 82)
        add_leave_btn.Margin = New Padding(2)
        add_leave_btn.Name = "add_leave_btn"
        add_leave_btn.Size = New Size(90, 31)
        add_leave_btn.TabIndex = 23
        add_leave_btn.Text = "Add"
        add_leave_btn.UseVisualStyleBackColor = True
        ' 
        ' leave_reset_btn
        ' 
        leave_reset_btn.Location = New Point(529, 47)
        leave_reset_btn.Margin = New Padding(2)
        leave_reset_btn.Name = "leave_reset_btn"
        leave_reset_btn.Size = New Size(78, 23)
        leave_reset_btn.TabIndex = 22
        leave_reset_btn.Text = "Reset"
        leave_reset_btn.UseVisualStyleBackColor = True
        ' 
        ' leave_export_btn
        ' 
        leave_export_btn.Location = New Point(708, 47)
        leave_export_btn.Margin = New Padding(2)
        leave_export_btn.Name = "leave_export_btn"
        leave_export_btn.Size = New Size(90, 31)
        leave_export_btn.TabIndex = 21
        leave_export_btn.Text = "Export"
        leave_export_btn.UseVisualStyleBackColor = True
        ' 
        ' leave_print_btn
        ' 
        leave_print_btn.Location = New Point(708, 12)
        leave_print_btn.Margin = New Padding(2)
        leave_print_btn.Name = "leave_print_btn"
        leave_print_btn.Size = New Size(90, 31)
        leave_print_btn.TabIndex = 20
        leave_print_btn.Text = "Print"
        leave_print_btn.UseVisualStyleBackColor = True
        ' 
        ' leave_datagrid
        ' 
        leave_datagrid.AllowUserToAddRows = False
        leave_datagrid.AllowUserToDeleteRows = False
        leave_datagrid.AllowUserToResizeColumns = False
        leave_datagrid.AllowUserToResizeRows = False
        leave_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        leave_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        leave_datagrid.Location = New Point(20, 115)
        leave_datagrid.Name = "leave_datagrid"
        leave_datagrid.RowHeadersWidth = 62
        leave_datagrid.RowTemplate.Height = 33
        leave_datagrid.Size = New Size(798, 374)
        leave_datagrid.TabIndex = 19
        ' 
        ' leave_branch_cb
        ' 
        leave_branch_cb.FormattingEnabled = True
        leave_branch_cb.Location = New Point(418, 47)
        leave_branch_cb.Name = "leave_branch_cb"
        leave_branch_cb.Size = New Size(106, 23)
        leave_branch_cb.TabIndex = 14
        leave_branch_cb.Text = "San, Bartolome"
        ' 
        ' leave_end_date
        ' 
        leave_end_date.Location = New Point(212, 47)
        leave_end_date.Name = "leave_end_date"
        leave_end_date.Size = New Size(200, 23)
        leave_end_date.TabIndex = 13
        ' 
        ' leave_start_date
        ' 
        leave_start_date.Location = New Point(6, 47)
        leave_start_date.Name = "leave_start_date"
        leave_start_date.Size = New Size(200, 23)
        leave_start_date.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 11
        Label1.Text = "Leave"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(631, 50)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(180, 500)
        PictureBox7.TabIndex = 3
        PictureBox7.TabStop = False
        ' 
        ' dept_tab
        ' 
        dept_tab.Controls.Add(Panel12)
        dept_tab.Controls.Add(dept_gridview)
        dept_tab.Controls.Add(Label11)
        dept_tab.Controls.Add(PictureBox5)
        dept_tab.Location = New Point(4, 24)
        dept_tab.Name = "dept_tab"
        dept_tab.Padding = New Padding(3)
        dept_tab.Size = New Size(842, 503)
        dept_tab.TabIndex = 3
        dept_tab.Text = "TabPage4"
        dept_tab.UseVisualStyleBackColor = True
        ' 
        ' Panel12
        ' 
        Panel12.Controls.Add(id_dept_tb)
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
        Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Id.FillWeight = 10F
        Id.HeaderText = "ID"
        Id.MinimumWidth = 8
        Id.Name = "Id"
        Id.ReadOnly = True
        Id.Resizable = DataGridViewTriState.False
        ' 
        ' dep_col
        ' 
        dep_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dep_col.FillWeight = 60F
        dep_col.HeaderText = "Department Name"
        dep_col.MinimumWidth = 8
        dep_col.Name = "dep_col"
        dep_col.ReadOnly = True
        dep_col.Resizable = DataGridViewTriState.False
        ' 
        ' dep_desc
        ' 
        dep_desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dep_desc.FillWeight = 100.1044F
        dep_desc.HeaderText = "Department Description"
        dep_desc.MinimumWidth = 50
        dep_desc.Name = "dep_desc"
        dep_desc.ReadOnly = True
        dep_desc.Resizable = DataGridViewTriState.False
        ' 
        ' action_col
        ' 
        action_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        action_col.FillWeight = 20F
        action_col.HeaderText = "Action"
        action_col.MinimumWidth = 50
        action_col.Name = "action_col"
        action_col.ReadOnly = True
        action_col.Resizable = DataGridViewTriState.False
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
        ' report_tab
        ' 
        report_tab.Controls.Add(Button4)
        report_tab.Controls.Add(Button3)
        report_tab.Controls.Add(report_print_btn)
        report_tab.Controls.Add(report_grid_view)
        report_tab.Controls.Add(report_brach_cb)
        report_tab.Controls.Add(report_end_date)
        report_tab.Controls.Add(report_start_date)
        report_tab.Controls.Add(Label12)
        report_tab.Controls.Add(PictureBox2)
        report_tab.Location = New Point(4, 24)
        report_tab.Name = "report_tab"
        report_tab.Padding = New Padding(3)
        report_tab.Size = New Size(842, 503)
        report_tab.TabIndex = 4
        report_tab.Text = "TabPage5"
        report_tab.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(529, 48)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(78, 23)
        Button4.TabIndex = 22
        Button4.Text = "Reset"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(702, 30)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(97, 31)
        Button3.TabIndex = 21
        Button3.Text = "Export"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' report_print_btn
        ' 
        report_print_btn.Location = New Point(702, 65)
        report_print_btn.Margin = New Padding(2)
        report_print_btn.Name = "report_print_btn"
        report_print_btn.Size = New Size(97, 31)
        report_print_btn.TabIndex = 20
        report_print_btn.Text = "Print"
        report_print_btn.UseVisualStyleBackColor = True
        ' 
        ' report_grid_view
        ' 
        report_grid_view.AllowUserToAddRows = False
        report_grid_view.AllowUserToDeleteRows = False
        report_grid_view.AllowUserToOrderColumns = True
        report_grid_view.AllowUserToResizeColumns = False
        report_grid_view.AllowUserToResizeRows = False
        report_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        report_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        report_grid_view.Location = New Point(20, 115)
        report_grid_view.Name = "report_grid_view"
        report_grid_view.RowHeadersWidth = 62
        report_grid_view.RowTemplate.Height = 33
        report_grid_view.Size = New Size(798, 374)
        report_grid_view.TabIndex = 19
        ' 
        ' report_brach_cb
        ' 
        report_brach_cb.FormattingEnabled = True
        report_brach_cb.Location = New Point(418, 47)
        report_brach_cb.Name = "report_brach_cb"
        report_brach_cb.Size = New Size(106, 23)
        report_brach_cb.TabIndex = 14
        report_brach_cb.Text = "San, Bartolome"
        ' 
        ' report_end_date
        ' 
        report_end_date.Location = New Point(212, 47)
        report_end_date.Name = "report_end_date"
        report_end_date.Size = New Size(200, 23)
        report_end_date.TabIndex = 13
        ' 
        ' report_start_date
        ' 
        report_start_date.Location = New Point(6, 47)
        report_start_date.Name = "report_start_date"
        report_start_date.Size = New Size(200, 23)
        report_start_date.TabIndex = 12
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(160, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(810, 23)
        Panel1.TabIndex = 3
        ' 
        ' admindashboardform
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        ClientSize = New Size(970, 473)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Controls.Add(nav_panel)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        Name = "admindashboardform"
        StartPosition = FormStartPosition.CenterScreen
        nav_panel.ResumeLayout(False)
        Nav1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        brach_tab.ResumeLayout(False)
        brach_tab.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        employees_tab.ResumeLayout(False)
        employees_tab.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(employee_grid_view, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        dashboard_tab.ResumeLayout(False)
        dashboard_tab.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        leave_tab.ResumeLayout(False)
        leave_tab.PerformLayout()
        CType(leave_datagrid, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        dept_tab.ResumeLayout(False)
        dept_tab.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        CType(dept_gridview, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        report_tab.ResumeLayout(False)
        report_tab.PerformLayout()
        CType(report_grid_view, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents nav_panel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents dashboard_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents brach_tab As TabPage
    Friend WithEvents sanfrancisco_branch_btn As Button
    Friend WithEvents batasan_branch_btn As Button
    Friend WithEvents sanbartolome_branch_btn As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents employees_tab As TabPage
    Friend WithEvents Panel7 As Panel
    Friend WithEvents add_employees_btn As Button
    Friend WithEvents id_employees_tb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents employee_grid_view As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dashboard_tab As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents dept_tab As TabPage
    Friend WithEvents report_tab As TabPage
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents add_dept_btn As Button
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents report_start_date As DateTimePicker
    Friend WithEvents report_end_date As DateTimePicker
    Friend WithEvents report_brach_cb As ComboBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents depa As DataGridView
    Friend WithEvents dept_gridview As DataGridView
    Friend WithEvents dep_filter_btn As Label
    Friend WithEvents branch_filter_lb As Label
    Friend WithEvents id_dept_tb As TextBox
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
    Friend WithEvents id_col As DataGridViewTextBoxColumn
    Friend WithEvents name_col As DataGridViewTextBoxColumn
    Friend WithEvents shift_col As DataGridViewTextBoxColumn
    Friend WithEvents gender_col As DataGridViewTextBoxColumn
    Friend WithEvents dob_col As DataGridViewTextBoxColumn
    Friend WithEvents hired_col As DataGridViewTextBoxColumn
    Friend WithEvents act_col As DataGridViewButtonColumn
    Friend WithEvents report_grid_view As DataGridView
    Friend WithEvents report_print_btn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents v_absent As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents leave_btn As Button
    Friend WithEvents leave_tab As TabPage
    Friend WithEvents add_leave_btn As Button
    Friend WithEvents leave_reset_btn As Button
    Friend WithEvents leave_export_btn As Button
    Friend WithEvents leave_print_btn As Button
    Friend WithEvents leave_datagrid As DataGridView
    Friend WithEvents leave_branch_cb As ComboBox
    Friend WithEvents leave_end_date As DateTimePicker
    Friend WithEvents leave_start_date As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents dep_col As DataGridViewTextBoxColumn
    Friend WithEvents dep_desc As DataGridViewTextBoxColumn
    Friend WithEvents action_col As DataGridViewButtonColumn
End Class
