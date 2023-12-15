<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginform
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Panel5 = New Panel()
        pass_tb = New TextBox()
        Panel4 = New Panel()
        un_tb = New TextBox()
        mainform_back_btn = New Button()
        invalid_lb = New Label()
        login_btn = New Button()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(134), CByte(134), CByte(134))
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(mainform_back_btn)
        Panel1.Controls.Add(invalid_lb)
        Panel1.Controls.Add(login_btn)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(510, 473)
        Panel1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Silver
        Panel5.Controls.Add(pass_tb)
        Panel5.Location = New Point(150, 232)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(270, 34)
        Panel5.TabIndex = 10
        ' 
        ' pass_tb
        ' 
        pass_tb.BackColor = Color.Silver
        pass_tb.BorderStyle = BorderStyle.None
        pass_tb.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        pass_tb.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        pass_tb.Location = New Point(8, 4)
        pass_tb.Name = "pass_tb"
        pass_tb.PasswordChar = "*"c
        pass_tb.PlaceholderText = "Password"
        pass_tb.Size = New Size(254, 28)
        pass_tb.TabIndex = 6
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Silver
        Panel4.Controls.Add(un_tb)
        Panel4.Location = New Point(150, 170)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(270, 34)
        Panel4.TabIndex = 9
        ' 
        ' un_tb
        ' 
        un_tb.BackColor = Color.Silver
        un_tb.BorderStyle = BorderStyle.None
        un_tb.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        un_tb.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        un_tb.Location = New Point(8, 4)
        un_tb.Name = "un_tb"
        un_tb.PlaceholderText = "Username"
        un_tb.ShortcutsEnabled = False
        un_tb.Size = New Size(254, 28)
        un_tb.TabIndex = 2
        ' 
        ' mainform_back_btn
        ' 
        mainform_back_btn.FlatAppearance.BorderSize = 0
        mainform_back_btn.FlatStyle = FlatStyle.Flat
        mainform_back_btn.Location = New Point(21, 19)
        mainform_back_btn.Name = "mainform_back_btn"
        mainform_back_btn.Size = New Size(38, 31)
        mainform_back_btn.TabIndex = 5
        mainform_back_btn.UseVisualStyleBackColor = True
        ' 
        ' invalid_lb
        ' 
        invalid_lb.AutoSize = True
        invalid_lb.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        invalid_lb.ForeColor = Color.Red
        invalid_lb.Location = New Point(188, 269)
        invalid_lb.Margin = New Padding(2, 0, 2, 0)
        invalid_lb.Name = "invalid_lb"
        invalid_lb.Size = New Size(179, 15)
        invalid_lb.TabIndex = 8
        invalid_lb.Text = "Invalid Username and Password."
        invalid_lb.UseWaitCursor = True
        invalid_lb.Visible = False
        ' 
        ' login_btn
        ' 
        login_btn.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        login_btn.FlatAppearance.BorderColor = Color.Black
        login_btn.FlatStyle = FlatStyle.Flat
        login_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        login_btn.ForeColor = Color.White
        login_btn.Location = New Point(182, 313)
        login_btn.Name = "login_btn"
        login_btn.Size = New Size(133, 41)
        login_btn.TabIndex = 6
        login_btn.Text = "Login"
        login_btn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.lock
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(94, 229)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(50, 40)
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.user__2_
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(94, 168)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 40)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(182, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 45)
        Label1.TabIndex = 0
        Label1.Text = "ADMIN"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(634, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 600)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(34, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(180, 500)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' loginform
        ' 
        AcceptButton = login_btn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(970, 473)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "loginform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents login_btn As Button
    Friend WithEvents invalid_lb As Label
    Friend WithEvents mainform_back_btn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel

    Friend WithEvents Timer1 As Timer
    Friend WithEvents pass_tb As TextBox
    Friend WithEvents un_tb As TextBox
End Class
