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
        Panel11 = New Panel()
        Label10 = New Label()
        TabControl2 = New TabControl()
        TabPage6 = New TabPage()
        branch_gridview = New DataGridView()
        TabPage7 = New TabPage()
        DataGridView5 = New DataGridView()
        TabPage8 = New TabPage()
        DataGridView6 = New DataGridView()
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
        add_employees_btn = New Button()
        search_employees_btn = New Button()
        id_employees_tb = New TextBox()
        Label8 = New Label()
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
        Label6 = New Label()
        branch_grid_view = New DataGridView()
        branch_col = New DataGridViewTextBoxColumn()
        department_grid_view = New DataGridView()
        depart_col = New DataGridViewTextBoxColumn()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel4 = New Panel()
        PictureBox6 = New PictureBox()
        TabControl1 = New TabControl()
        TabPage4 = New TabPage()
        Panel12 = New Panel()
        add_dept_btn = New Button()
        search_dept_btn = New Button()
        id_dept_tb = New TextBox()
        Label13 = New Label()
        DataGridView7 = New DataGridView()
        id_dep = New DataGridViewTextBoxColumn()
        dep_col = New DataGridViewTextBoxColumn()
        action_col = New DataGridViewTextBoxColumn()
        Label11 = New Label()
        PictureBox5 = New PictureBox()
        TabPage5 = New TabPage()
        dept_pr_btn = New Button()
        search_pr_btn = New Button()
        ComboBox1 = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label12 = New Label()
        PictureBox2 = New PictureBox()
        branch_num = New Label()
        employee_num = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        TabPage3.SuspendLayout()
        Panel11.SuspendLayout()
        TabControl2.SuspendLayout()
        TabPage6.SuspendLayout()
        CType(branch_gridview, ComponentModel.ISupportInitialize).BeginInit()
        TabPage7.SuspendLayout()
        CType(DataGridView5, ComponentModel.ISupportInitialize).BeginInit()
        TabPage8.SuspendLayout()
        CType(DataGridView6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        Panel7.SuspendLayout()
        CType(employee_grid_view, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TabPage1.SuspendLayout()
        CType(branch_grid_view, ComponentModel.ISupportInitialize).BeginInit()
        CType(department_grid_view, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage4.SuspendLayout()
        Panel12.SuspendLayout()
        CType(DataGridView7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        TabPage5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(134), CByte(134), CByte(134))
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(printreport_btn)
        Panel1.Controls.Add(branch_btn)
        Panel1.Controls.Add(department_btn)
        Panel1.Controls.Add(employee_btn)
        Panel1.Controls.Add(dashboard_btn)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(150, 600)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(25, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 21)
        Label2.TabIndex = 0
        Label2.Text = "C.C.F"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(-17, 203)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 15)
        Label1.TabIndex = 0
        Label1.Text = "________________________________"
        ' 
        ' printreport_btn
        ' 
        printreport_btn.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        printreport_btn.Image = My.Resources.Resources.report_card
        printreport_btn.ImageAlign = ContentAlignment.MiddleLeft
        printreport_btn.Location = New Point(10, 401)
        printreport_btn.Name = "printreport_btn"
        printreport_btn.Size = New Size(130, 40)
        printreport_btn.TabIndex = 2
        printreport_btn.Text = "  Print Report"
        printreport_btn.UseVisualStyleBackColor = True
        ' 
        ' branch_btn
        ' 
        branch_btn.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        branch_btn.Image = My.Resources.Resources.branch
        branch_btn.ImageAlign = ContentAlignment.MiddleLeft
        branch_btn.Location = New Point(10, 290)
        branch_btn.Name = "branch_btn"
        branch_btn.Size = New Size(130, 40)
        branch_btn.TabIndex = 2
        branch_btn.Text = "Branch"
        branch_btn.UseVisualStyleBackColor = True
        ' 
        ' department_btn
        ' 
        department_btn.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        department_btn.Image = My.Resources.Resources.department
        department_btn.ImageAlign = ContentAlignment.MiddleLeft
        department_btn.Location = New Point(10, 345)
        department_btn.Name = "department_btn"
        department_btn.Size = New Size(130, 40)
        department_btn.TabIndex = 1
        department_btn.Text = "  Department"
        department_btn.UseVisualStyleBackColor = True
        ' 
        ' employee_btn
        ' 
        employee_btn.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        employee_btn.Image = My.Resources.Resources.user__1_1
        employee_btn.ImageAlign = ContentAlignment.MiddleLeft
        employee_btn.Location = New Point(10, 232)
        employee_btn.Name = "employee_btn"
        employee_btn.Size = New Size(130, 40)
        employee_btn.TabIndex = 1
        employee_btn.Text = "  Employee"
        employee_btn.UseVisualStyleBackColor = True
        ' 
        ' dashboard_btn
        ' 
        dashboard_btn.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        dashboard_btn.Image = My.Resources.Resources.home
        dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft
        dashboard_btn.Location = New Point(10, 160)
        dashboard_btn.Name = "dashboard_btn"
        dashboard_btn.Size = New Size(130, 40)
        dashboard_btn.TabIndex = 0
        dashboard_btn.Text = "  Dash Board"
        dashboard_btn.UseVisualStyleBackColor = True
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
        PictureBox1.BackgroundImage = My.Resources.Resources.user
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(15, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 90)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(209), CByte(210), CByte(210))
        Panel2.Controls.Add(Button1)
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(153, -24)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(850, 44)
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
        TabPage3.Controls.Add(TabControl2)
        TabPage3.Controls.Add(sanfrancisco_branch_btn)
        TabPage3.Controls.Add(batasan_branch_btn)
        TabPage3.Controls.Add(sanbartolome_branch_btn)
        TabPage3.Controls.Add(Panel10)
        TabPage3.Controls.Add(Panel9)
        TabPage3.Controls.Add(Panel8)
        TabPage3.Controls.Add(Label9)
        TabPage3.Controls.Add(PictureBox4)
        TabPage3.Controls.Add(Panel11)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3, 3, 3, 3)
        TabPage3.Size = New Size(842, 546)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(Label10)
        Panel11.Location = New Point(20, 130)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(800, 40)
        Panel11.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(7, 10)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 17)
        Label10.TabIndex = 0
        Label10.Text = "Branch"
        ' 
        ' TabControl2
        ' 
        TabControl2.Controls.Add(TabPage6)
        TabControl2.Controls.Add(TabPage7)
        TabControl2.Controls.Add(TabPage8)
        TabControl2.Location = New Point(20, 140)
        TabControl2.Name = "TabControl2"
        TabControl2.SelectedIndex = 0
        TabControl2.Size = New Size(800, 386)
        TabControl2.TabIndex = 16
        ' 
        ' TabPage6
        ' 
        TabPage6.Controls.Add(branch_gridview)
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3, 3, 3, 3)
        TabPage6.Size = New Size(792, 358)
        TabPage6.TabIndex = 0
        TabPage6.Text = "TabPage6"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' branch_gridview
        ' 
        branch_gridview.AllowUserToAddRows = False
        branch_gridview.AllowUserToDeleteRows = False
        branch_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        branch_gridview.Dock = DockStyle.Fill
        branch_gridview.Location = New Point(3, 3)
        branch_gridview.Name = "branch_gridview"
        branch_gridview.ReadOnly = True
        branch_gridview.RowHeadersWidth = 62
        branch_gridview.Size = New Size(786, 352)
        branch_gridview.TabIndex = 0
        ' 
        ' TabPage7
        ' 
        TabPage7.Controls.Add(DataGridView5)
        TabPage7.Location = New Point(4, 24)
        TabPage7.Name = "TabPage7"
        TabPage7.Padding = New Padding(3, 3, 3, 3)
        TabPage7.Size = New Size(792, 358)
        TabPage7.TabIndex = 1
        TabPage7.Text = "TabPage7"
        TabPage7.UseVisualStyleBackColor = True
        ' 
        ' DataGridView5
        ' 
        DataGridView5.AllowUserToAddRows = False
        DataGridView5.AllowUserToDeleteRows = False
        DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView5.Dock = DockStyle.Fill
        DataGridView5.Location = New Point(3, 3)
        DataGridView5.Name = "DataGridView5"
        DataGridView5.ReadOnly = True
        DataGridView5.RowHeadersWidth = 62
        DataGridView5.Size = New Size(786, 352)
        DataGridView5.TabIndex = 0
        ' 
        ' TabPage8
        ' 
        TabPage8.Controls.Add(DataGridView6)
        TabPage8.Location = New Point(4, 24)
        TabPage8.Name = "TabPage8"
        TabPage8.Padding = New Padding(3, 3, 3, 3)
        TabPage8.Size = New Size(792, 358)
        TabPage8.TabIndex = 2
        TabPage8.Text = "TabPage8"
        TabPage8.UseVisualStyleBackColor = True
        ' 
        ' DataGridView6
        ' 
        DataGridView6.AllowUserToAddRows = False
        DataGridView6.AllowUserToDeleteRows = False
        DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView6.Dock = DockStyle.Fill
        DataGridView6.Location = New Point(3, 3)
        DataGridView6.Name = "DataGridView6"
        DataGridView6.ReadOnly = True
        DataGridView6.RowHeadersWidth = 62
        DataGridView6.Size = New Size(786, 352)
        DataGridView6.TabIndex = 0
        ' 
        ' sanfrancisco_branch_btn
        ' 
        sanfrancisco_branch_btn.FlatAppearance.BorderSize = 0
        sanfrancisco_branch_btn.FlatStyle = FlatStyle.Flat
        sanfrancisco_branch_btn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        sanfrancisco_branch_btn.Location = New Point(406, 50)
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
        batasan_branch_btn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        batasan_branch_btn.Location = New Point(223, 50)
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
        sanbartolome_branch_btn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        sanbartolome_branch_btn.Location = New Point(40, 50)
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
        Panel10.Location = New Point(399, 50)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(5, 60)
        Panel10.TabIndex = 12
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Yellow
        Panel9.ForeColor = Color.Black
        Panel9.Location = New Point(216, 50)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(5, 60)
        Panel9.TabIndex = 12
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Blue
        Panel8.ForeColor = Color.Black
        Panel8.Location = New Point(35, 50)
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
        TabPage2.Padding = New Padding(3, 3, 3, 3)
        TabPage2.Size = New Size(842, 546)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(add_employees_btn)
        Panel7.Controls.Add(search_employees_btn)
        Panel7.Controls.Add(id_employees_tb)
        Panel7.Controls.Add(Label8)
        Panel7.Location = New Point(20, 61)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(801, 40)
        Panel7.TabIndex = 10
        ' 
        ' add_employees_btn
        ' 
        add_employees_btn.BackColor = Color.Red
        add_employees_btn.FlatAppearance.BorderColor = Color.Red
        add_employees_btn.FlatStyle = FlatStyle.Flat
        add_employees_btn.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        add_employees_btn.ForeColor = Color.White
        add_employees_btn.Location = New Point(715, 10)
        add_employees_btn.Name = "add_employees_btn"
        add_employees_btn.Size = New Size(75, 23)
        add_employees_btn.TabIndex = 3
        add_employees_btn.Text = "Add"
        add_employees_btn.UseVisualStyleBackColor = False
        ' 
        ' search_employees_btn
        ' 
        search_employees_btn.BackColor = Color.Red
        search_employees_btn.FlatAppearance.BorderColor = Color.Red
        search_employees_btn.FlatStyle = FlatStyle.Flat
        search_employees_btn.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        search_employees_btn.ForeColor = Color.White
        search_employees_btn.Location = New Point(148, 10)
        search_employees_btn.Name = "search_employees_btn"
        search_employees_btn.Size = New Size(75, 23)
        search_employees_btn.TabIndex = 2
        search_employees_btn.Text = "Search"
        search_employees_btn.UseVisualStyleBackColor = False
        ' 
        ' id_employees_tb
        ' 
        id_employees_tb.Location = New Point(42, 10)
        id_employees_tb.Name = "id_employees_tb"
        id_employees_tb.Size = New Size(100, 23)
        id_employees_tb.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(10, 10)
        Label8.Name = "Label8"
        Label8.Size = New Size(26, 21)
        Label8.TabIndex = 0
        Label8.Text = "ID"
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
        employee_grid_view.Size = New Size(801, 426)
        employee_grid_view.TabIndex = 2
        ' 
        ' id_col
        ' 
        id_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        id_col.HeaderText = "ID"
        id_col.MinimumWidth = 8
        id_col.Name = "id_col"
        id_col.ReadOnly = True
        ' 
        ' name_col
        ' 
        name_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        name_col.HeaderText = "Name"
        name_col.MinimumWidth = 8
        name_col.Name = "name_col"
        name_col.ReadOnly = True
        ' 
        ' shift_col
        ' 
        shift_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        shift_col.HeaderText = "Shift"
        shift_col.MinimumWidth = 8
        shift_col.Name = "shift_col"
        shift_col.ReadOnly = True
        ' 
        ' gender_col
        ' 
        gender_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        gender_col.HeaderText = "Gender"
        gender_col.MinimumWidth = 8
        gender_col.Name = "gender_col"
        gender_col.ReadOnly = True
        ' 
        ' dob_col
        ' 
        dob_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dob_col.HeaderText = "DOB"
        dob_col.MinimumWidth = 8
        dob_col.Name = "dob_col"
        dob_col.ReadOnly = True
        ' 
        ' hired_col
        ' 
        hired_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        hired_col.HeaderText = "Hired Date"
        hired_col.MinimumWidth = 8
        hired_col.Name = "hired_col"
        hired_col.ReadOnly = True
        ' 
        ' act_col
        ' 
        act_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        act_col.HeaderText = "Action"
        act_col.MinimumWidth = 8
        act_col.Name = "act_col"
        act_col.ReadOnly = True
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
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(branch_grid_view)
        TabPage1.Controls.Add(department_grid_view)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Panel5)
        TabPage1.Controls.Add(Panel6)
        TabPage1.Controls.Add(Panel4)
        TabPage1.Controls.Add(PictureBox6)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 3, 3, 3)
        TabPage1.Size = New Size(842, 546)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(6, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 25)
        Label6.TabIndex = 8
        Label6.Text = "Dash Board"
        ' 
        ' branch_grid_view
        ' 
        branch_grid_view.AllowUserToAddRows = False
        branch_grid_view.AllowUserToDeleteRows = False
        branch_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        branch_grid_view.Columns.AddRange(New DataGridViewColumn() {branch_col})
        branch_grid_view.Location = New Point(435, 185)
        branch_grid_view.Name = "branch_grid_view"
        branch_grid_view.ReadOnly = True
        branch_grid_view.RowHeadersWidth = 62
        branch_grid_view.Size = New Size(386, 331)
        branch_grid_view.TabIndex = 7
        ' 
        ' branch_col
        ' 
        branch_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        branch_col.HeaderText = "Branch"
        branch_col.MinimumWidth = 8
        branch_col.Name = "branch_col"
        branch_col.ReadOnly = True
        ' 
        ' department_grid_view
        ' 
        department_grid_view.AllowUserToAddRows = False
        department_grid_view.AllowUserToDeleteRows = False
        department_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        department_grid_view.Columns.AddRange(New DataGridViewColumn() {depart_col, Desciption})
        department_grid_view.Location = New Point(47, 370)
        department_grid_view.Margin = New Padding(5, 6, 5, 6)
=======
        department_grid_view.Columns.AddRange(New DataGridViewColumn() {depart_col})
        department_grid_view.Location = New Point(27, 185)
>>>>>>> b4a30c14e513619d0dc2a3ddbbeac68ac43ba75d
        department_grid_view.Name = "department_grid_view"
        department_grid_view.ReadOnly = True
        department_grid_view.RowHeadersWidth = 62
        department_grid_view.Size = New Size(386, 331)
        department_grid_view.TabIndex = 7
        ' 
        ' depart_col
        ' 
        depart_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        depart_col.HeaderText = "Department"
        depart_col.MinimumWidth = 8
        depart_col.Name = "depart_col"
        depart_col.ReadOnly = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(502, 68)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 15)
        Label5.TabIndex = 6
        Label5.Text = "Employee"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(270, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 5
        Label4.Text = "Branch"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 4
        Label3.Text = "Department"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Yellow
        Panel5.Location = New Point(259, 67)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(5, 90)
        Panel5.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Red
        Panel6.Location = New Point(491, 67)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(5, 90)
        Panel6.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Blue
        Panel4.ForeColor = Color.Black
        Panel4.Location = New Point(27, 67)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(5, 90)
        Panel4.TabIndex = 2
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox6.Location = New Point(631, 50)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(180, 500)
        PictureBox6.TabIndex = 1
        PictureBox6.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Location = New Point(150, 26)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(850, 574)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Panel12)
        TabPage4.Controls.Add(DataGridView7)
        TabPage4.Controls.Add(Label11)
        TabPage4.Controls.Add(PictureBox5)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3, 3, 3, 3)
        TabPage4.Size = New Size(842, 546)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TabPage4"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Panel12
        ' 
        Panel12.Controls.Add(add_dept_btn)
        Panel12.Controls.Add(search_dept_btn)
        Panel12.Controls.Add(id_dept_tb)
        Panel12.Controls.Add(Label13)
        Panel12.Location = New Point(20, 61)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(801, 40)
        Panel12.TabIndex = 13
        ' 
        ' add_dept_btn
        ' 
        add_dept_btn.BackColor = Color.Red
        add_dept_btn.FlatAppearance.BorderColor = Color.Red
        add_dept_btn.FlatStyle = FlatStyle.Flat
        add_dept_btn.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        add_dept_btn.ForeColor = Color.White
        add_dept_btn.Location = New Point(715, 10)
        add_dept_btn.Name = "add_dept_btn"
        add_dept_btn.Size = New Size(75, 23)
        add_dept_btn.TabIndex = 3
        add_dept_btn.Text = "Add"
        add_dept_btn.UseVisualStyleBackColor = False
        ' 
        ' search_dept_btn
        ' 
        search_dept_btn.BackColor = Color.Red
        search_dept_btn.FlatAppearance.BorderColor = Color.Red
        search_dept_btn.FlatStyle = FlatStyle.Flat
        search_dept_btn.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        search_dept_btn.ForeColor = Color.White
        search_dept_btn.Location = New Point(148, 10)
        search_dept_btn.Name = "search_dept_btn"
        search_dept_btn.Size = New Size(75, 23)
        search_dept_btn.TabIndex = 2
        search_dept_btn.Text = "Search"
        search_dept_btn.UseVisualStyleBackColor = False
        ' 
        ' id_dept_tb
        ' 
        id_dept_tb.Location = New Point(42, 10)
        id_dept_tb.Name = "id_dept_tb"
        id_dept_tb.Size = New Size(100, 23)
        id_dept_tb.TabIndex = 1
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(10, 10)
        Label13.Name = "Label13"
        Label13.Size = New Size(26, 21)
        Label13.TabIndex = 0
        Label13.Text = "ID"
        ' 
        ' DataGridView7
        ' 
        DataGridView7.AllowUserToAddRows = False
        DataGridView7.AllowUserToDeleteRows = False
        DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView7.Columns.AddRange(New DataGridViewColumn() {id_dep, dep_col, action_col})
        DataGridView7.Location = New Point(20, 100)
        DataGridView7.Name = "DataGridView7"
        DataGridView7.ReadOnly = True
        DataGridView7.RowHeadersWidth = 62
        DataGridView7.Size = New Size(801, 426)
        DataGridView7.TabIndex = 12
        ' 
        ' id_dep
        ' 
        id_dep.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        id_dep.HeaderText = "ID"
        id_dep.MinimumWidth = 8
        id_dep.Name = "id_dep"
        id_dep.ReadOnly = True
        ' 
        ' dep_col
        ' 
        dep_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dep_col.HeaderText = "Department Name"
        dep_col.MinimumWidth = 8
        dep_col.Name = "dep_col"
        dep_col.ReadOnly = True
        ' 
        ' action_col
        ' 
        action_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        action_col.HeaderText = "Action"
        action_col.MinimumWidth = 8
        action_col.Name = "action_col"
        action_col.ReadOnly = True
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
        TabPage5.Controls.Add(dept_pr_btn)
        TabPage5.Controls.Add(search_pr_btn)
        TabPage5.Controls.Add(ComboBox1)
        TabPage5.Controls.Add(DateTimePicker2)
        TabPage5.Controls.Add(DateTimePicker1)
        TabPage5.Controls.Add(Label12)
        TabPage5.Controls.Add(PictureBox2)
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3, 3, 3, 3)
        TabPage5.Size = New Size(842, 546)
        TabPage5.TabIndex = 4
        TabPage5.Text = "TabPage5"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' dept_pr_btn
        ' 
        dept_pr_btn.BackColor = Color.Gray
        dept_pr_btn.FlatAppearance.BorderColor = Color.Black
        dept_pr_btn.FlatStyle = FlatStyle.Flat
        dept_pr_btn.ForeColor = Color.White
        dept_pr_btn.Location = New Point(530, 46)
        dept_pr_btn.Name = "dept_pr_btn"
        dept_pr_btn.Size = New Size(83, 23)
        dept_pr_btn.TabIndex = 16
        dept_pr_btn.Text = "Department"
        dept_pr_btn.UseVisualStyleBackColor = False
        ' 
        ' search_pr_btn
        ' 
        search_pr_btn.BackColor = Color.Red
        search_pr_btn.FlatAppearance.BorderColor = Color.Black
        search_pr_btn.FlatStyle = FlatStyle.Flat
        search_pr_btn.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        search_pr_btn.ForeColor = Color.White
        search_pr_btn.Location = New Point(619, 46)
        search_pr_btn.Name = "search_pr_btn"
        search_pr_btn.Size = New Size(75, 23)
        search_pr_btn.TabIndex = 15
        search_pr_btn.Text = "Search"
        search_pr_btn.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(418, 47)
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
        Label12.Size = New Size(123, 25)
        Label12.TabIndex = 11
        Label12.Text = "Print Report"
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
        ' branch_num
        ' 
        branch_num.AutoSize = True
        branch_num.Font = New Font("Segoe UI", 48.0F, FontStyle.Regular, GraphicsUnit.Point)
        branch_num.Location = New Point(463, 169)
        branch_num.Name = "branch_num"
        branch_num.Size = New Size(123, 149)
        branch_num.TabIndex = 10
        branch_num.Text = "0"
        ' 
        ' employee_num
        ' 
        employee_num.AutoSize = True
        employee_num.Font = New Font("Segoe UI", 48.0F, FontStyle.Regular, GraphicsUnit.Point)
        employee_num.Location = New Point(860, 169)
        employee_num.Name = "employee_num"
        employee_num.Size = New Size(123, 149)
        employee_num.TabIndex = 11
        employee_num.Text = "0"
        ' 
        ' admindashboardform
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 600)
        Controls.Add(Panel2)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
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
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        TabControl2.ResumeLayout(False)
        TabPage6.ResumeLayout(False)
        CType(branch_gridview, ComponentModel.ISupportInitialize).EndInit()
        TabPage7.ResumeLayout(False)
        CType(DataGridView5, ComponentModel.ISupportInitialize).EndInit()
        TabPage8.ResumeLayout(False)
        CType(DataGridView6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(employee_grid_view, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(branch_grid_view, ComponentModel.ISupportInitialize).EndInit()
        CType(department_grid_view, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        CType(DataGridView7, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
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
    Friend WithEvents search_employees_btn As Button
    Friend WithEvents id_employees_tb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents employee_grid_view As DataGridView
    Friend WithEvents id_col As DataGridViewTextBoxColumn
    Friend WithEvents name_col As DataGridViewTextBoxColumn
    Friend WithEvents shift_col As DataGridViewTextBoxColumn
    Friend WithEvents gender_col As DataGridViewTextBoxColumn
    Friend WithEvents dob_col As DataGridViewTextBoxColumn
    Friend WithEvents hired_col As DataGridViewTextBoxColumn
    Friend WithEvents act_col As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents branch_grid_view As DataGridView
    Friend WithEvents branch_col As DataGridViewTextBoxColumn
    Friend WithEvents department_grid_view As DataGridView
    Friend WithEvents depart_col As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents branch_gridview As DataGridView
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents Panel12 As Panel
    Friend WithEvents add_dept_btn As Button
    Friend WithEvents search_dept_btn As Button
    Friend WithEvents id_dept_tb As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents id_dep As DataGridViewTextBoxColumn
    Friend WithEvents dep_col As DataGridViewTextBoxColumn
    Friend WithEvents action_col As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents dept_pr_btn As Button
    Friend WithEvents search_pr_btn As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents depart_col As DataGridViewTextBoxColumn
    Friend WithEvents Desciption As DataGridViewTextBoxColumn
    Friend WithEvents dept_num As Label
    Friend WithEvents employee_num As Label
    Friend WithEvents branch_num As Label
End Class
