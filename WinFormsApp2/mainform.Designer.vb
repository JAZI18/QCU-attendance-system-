<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        date_lb = New Label()
        Panel1 = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        afternoon_out_tb = New TextBox()
        afternoon_in_tb = New TextBox()
        morning_out_tb = New TextBox()
        overtime_out_tb = New TextBox()
        overtime_in_tb = New TextBox()
        morning_in_tb = New TextBox()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        sched_lb = New Label()
        Label3 = New Label()
        fullname_lb = New Label()
        Panel7 = New Panel()
        Label8 = New Label()
        Panel8 = New Panel()
        pic_box = New PictureBox()
        Panel2 = New Panel()
        employee_code_tb = New TextBox()
        employee_id_tb = New TextBox()
        Panel4 = New Panel()
        cam_pic_box = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        CType(pic_box, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(cam_pic_box, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' date_lb
        ' 
        date_lb.AutoSize = True
        date_lb.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        date_lb.Location = New Point(205, 25)
        date_lb.Name = "date_lb"
        date_lb.Size = New Size(243, 25)
        date_lb.TabIndex = 0
        date_lb.Text = "Monday, October 20,2023"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(afternoon_out_tb)
        Panel1.Controls.Add(afternoon_in_tb)
        Panel1.Controls.Add(morning_out_tb)
        Panel1.Controls.Add(overtime_out_tb)
        Panel1.Controls.Add(overtime_in_tb)
        Panel1.Controls.Add(morning_in_tb)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(sched_lb)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(fullname_lb)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel8)
        Panel1.Location = New Point(200, 90)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 230)
        Panel1.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.FlatStyle = FlatStyle.Flat
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(269, 147)
        Label11.Name = "Label11"
        Label11.Size = New Size(92, 15)
        Label11.TabIndex = 6
        Label11.Text = "OVERTIME OUT"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.FlatStyle = FlatStyle.Flat
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(275, 105)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 15)
        Label10.TabIndex = 6
        Label10.Text = "OVERTIME IN"
        ' 
        ' afternoon_out_tb
        ' 
        afternoon_out_tb.BackColor = Color.Silver
        afternoon_out_tb.BorderStyle = BorderStyle.None
        afternoon_out_tb.Location = New Point(126, 184)
        afternoon_out_tb.Name = "afternoon_out_tb"
        afternoon_out_tb.Size = New Size(100, 16)
        afternoon_out_tb.TabIndex = 5
        ' 
        ' afternoon_in_tb
        ' 
        afternoon_in_tb.BackColor = Color.Silver
        afternoon_in_tb.BorderStyle = BorderStyle.None
        afternoon_in_tb.Location = New Point(126, 165)
        afternoon_in_tb.Name = "afternoon_in_tb"
        afternoon_in_tb.Size = New Size(100, 16)
        afternoon_in_tb.TabIndex = 5
        ' 
        ' morning_out_tb
        ' 
        morning_out_tb.BackColor = Color.Silver
        morning_out_tb.BorderStyle = BorderStyle.None
        morning_out_tb.Location = New Point(126, 134)
        morning_out_tb.Name = "morning_out_tb"
        morning_out_tb.Size = New Size(100, 16)
        morning_out_tb.TabIndex = 5
        ' 
        ' overtime_out_tb
        ' 
        overtime_out_tb.BackColor = Color.Silver
        overtime_out_tb.BorderStyle = BorderStyle.None
        overtime_out_tb.Location = New Point(265, 165)
        overtime_out_tb.Name = "overtime_out_tb"
        overtime_out_tb.Size = New Size(100, 16)
        overtime_out_tb.TabIndex = 5
        ' 
        ' overtime_in_tb
        ' 
        overtime_in_tb.BackColor = Color.Silver
        overtime_in_tb.BorderStyle = BorderStyle.None
        overtime_in_tb.Location = New Point(265, 123)
        overtime_in_tb.Name = "overtime_in_tb"
        overtime_in_tb.Size = New Size(100, 16)
        overtime_in_tb.TabIndex = 5
        ' 
        ' morning_in_tb
        ' 
        morning_in_tb.BackColor = Color.Silver
        morning_in_tb.BorderStyle = BorderStyle.None
        morning_in_tb.Location = New Point(126, 115)
        morning_in_tb.Name = "morning_in_tb"
        morning_in_tb.Size = New Size(100, 16)
        morning_in_tb.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(248, 64)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 164)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(18, 185)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 15)
        Label7.TabIndex = 4
        Label7.Text = "AFTERNOON OUT"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(18, 165)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 15)
        Label6.TabIndex = 4
        Label6.Text = "AFTERNOON IN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(18, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 15)
        Label5.TabIndex = 4
        Label5.Text = "MORNING OUT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(18, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 15)
        Label4.TabIndex = 4
        Label4.Text = "MORNING IN"
        ' 
        ' sched_lb
        ' 
        sched_lb.AutoSize = True
        sched_lb.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        sched_lb.Location = New Point(94, 79)
        sched_lb.Name = "sched_lb"
        sched_lb.Size = New Size(115, 15)
        sched_lb.TabIndex = 4
        sched_lb.Text = "8:00 AM to 5:00 PM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(94, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 15)
        Label3.TabIndex = 4
        Label3.Text = "Quezon City University"
        ' 
        ' fullname_lb
        ' 
        fullname_lb.AutoSize = True
        fullname_lb.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        fullname_lb.Location = New Point(94, 49)
        fullname_lb.Name = "fullname_lb"
        fullname_lb.Size = New Size(142, 15)
        fullname_lb.TabIndex = 3
        fullname_lb.Text = "Mangmang, Jay Prince T." & vbCrLf
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Silver
        Panel7.Controls.Add(Label8)
        Panel7.Location = New Point(97, 9)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(200, 20)
        Panel7.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(63, 2)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 15)
        Label8.TabIndex = 4
        Label8.Text = "TIMELAPSE"
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(pic_box)
        Panel8.Location = New Point(18, 35)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(75, 65)
        Panel8.TabIndex = 0
        ' 
        ' pic_box
        ' 
        pic_box.BackColor = Color.LightGray
        pic_box.Image = CType(resources.GetObject("pic_box.Image"), Image)
        pic_box.Location = New Point(4, 4)
        pic_box.Name = "pic_box"
        pic_box.Size = New Size(65, 55)
        pic_box.TabIndex = 0
        pic_box.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(employee_code_tb)
        Panel2.Controls.Add(employee_id_tb)
        Panel2.Controls.Add(Panel4)
        Panel2.Location = New Point(20, 90)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(180, 230)
        Panel2.TabIndex = 2
        ' 
        ' employee_code_tb
        ' 
        employee_code_tb.BackColor = Color.DimGray
        employee_code_tb.BorderStyle = BorderStyle.None
        employee_code_tb.Enabled = False
        employee_code_tb.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        employee_code_tb.Location = New Point(13, 195)
        employee_code_tb.Name = "employee_code_tb"
        employee_code_tb.Size = New Size(150, 20)
        employee_code_tb.TabIndex = 5
        employee_code_tb.Text = "EMPLOYEE CODE"
        employee_code_tb.TextAlign = HorizontalAlignment.Center
        ' 
        ' employee_id_tb
        ' 
        employee_id_tb.BackColor = Color.DimGray
        employee_id_tb.BorderStyle = BorderStyle.None
        employee_id_tb.Enabled = False
        employee_id_tb.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        employee_id_tb.Location = New Point(13, 160)
        employee_id_tb.Name = "employee_id_tb"
        employee_id_tb.Size = New Size(150, 20)
        employee_id_tb.TabIndex = 5
        employee_id_tb.Text = "EMPLOYEE ID"
        employee_id_tb.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(cam_pic_box)
        Panel4.Location = New Point(13, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(150, 140)
        Panel4.TabIndex = 0
        ' 
        ' cam_pic_box
        ' 
        cam_pic_box.BackColor = Color.LightGray
        cam_pic_box.Image = My.Resources.Resources.user__5_
        cam_pic_box.Location = New Point(7, 9)
        cam_pic_box.Name = "cam_pic_box"
        cam_pic_box.Size = New Size(130, 120)
        cam_pic_box.TabIndex = 0
        cam_pic_box.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources.qcu_removebg_preview
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(149, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(50, 50)
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = My.Resources.Resources.qcu_removebg_preview
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(470, 12)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(50, 50)
        PictureBox5.TabIndex = 3
        PictureBox5.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = My.Resources.Resources.back
        Button1.Location = New Point(610, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(28, 21)
        Button1.TabIndex = 4
        Button1.UseVisualStyleBackColor = True
        ' 
        ' mainform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(650, 350)
        Controls.Add(Button1)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(date_lb)
        FormBorderStyle = FormBorderStyle.None
        Name = "mainform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "mainform"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        CType(pic_box, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(cam_pic_box, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents date_lb As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cam_pic_box As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents pic_box As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents fullname_lb As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents sched_lb As Label
    Friend WithEvents employee_code_tb As TextBox
    Friend WithEvents employee_id_tb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents afternoon_out_tb As TextBox
    Friend WithEvents afternoon_in_tb As TextBox
    Friend WithEvents morning_out_tb As TextBox
    Friend WithEvents morning_in_tb As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents overtime_out_tb As TextBox
    Friend WithEvents overtime_in_tb As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button1 As Button
End Class
