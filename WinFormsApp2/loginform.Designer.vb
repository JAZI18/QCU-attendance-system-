﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Panel1 = New Panel()
        login_btn = New Button()
        pass_tb = New TextBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        un_tb = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        settings_login_btn = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(134), CByte(134), CByte(134))
        Panel1.Controls.Add(login_btn)
        Panel1.Controls.Add(pass_tb)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(un_tb)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1071, 1000)
        Panel1.TabIndex = 0
        ' 
        ' login_btn
        ' 
        login_btn.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        login_btn.FlatAppearance.BorderColor = Color.Black
        login_btn.FlatStyle = FlatStyle.Flat
        login_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        login_btn.ForeColor = Color.White
        login_btn.Location = New Point(440, 592)
        login_btn.Margin = New Padding(4, 5, 4, 5)
        login_btn.Name = "login_btn"
        login_btn.Size = New Size(190, 68)
        login_btn.TabIndex = 6
        login_btn.Text = "Login"
        login_btn.UseVisualStyleBackColor = False
        ' 
        ' pass_tb
        ' 
        pass_tb.BackColor = SystemColors.ButtonShadow
        pass_tb.BorderStyle = BorderStyle.None
        pass_tb.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        pass_tb.ForeColor = Color.White
        pass_tb.Location = New Point(394, 513)
        pass_tb.Margin = New Padding(4, 5, 4, 5)
        pass_tb.Name = "pass_tb"
        pass_tb.PasswordChar = "*"c
        pass_tb.Size = New Size(363, 42)
        pass_tb.TabIndex = 5
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.lock
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(314, 492)
        PictureBox3.Margin = New Padding(4, 5, 4, 5)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(71, 67)
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.user__2_
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(314, 400)
        PictureBox2.Margin = New Padding(4, 5, 4, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(71, 67)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' un_tb
        ' 
        un_tb.BackColor = SystemColors.ButtonShadow
        un_tb.BorderStyle = BorderStyle.None
        un_tb.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        un_tb.ForeColor = Color.White
        un_tb.Location = New Point(394, 420)
        un_tb.Margin = New Padding(4, 5, 4, 5)
        un_tb.Name = "un_tb"
        un_tb.Size = New Size(363, 42)
        un_tb.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(440, 283)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 65)
        Label1.TabIndex = 0
        Label1.Text = "ADMIN"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(1071, 0)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(357, 1000)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(209), CByte(210), CByte(210))
        Panel3.Controls.Add(settings_login_btn)
        Panel3.Location = New Point(-857, 0)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1214, 83)
        Panel3.TabIndex = 1
        ' 
        ' settings_login_btn
        ' 
        settings_login_btn.BackgroundImage = My.Resources.Resources.settings
        settings_login_btn.BackgroundImageLayout = ImageLayout.Stretch
        settings_login_btn.FlatAppearance.BorderSize = 0
        settings_login_btn.FlatStyle = FlatStyle.Flat
        settings_login_btn.Location = New Point(1157, 8)
        settings_login_btn.Margin = New Padding(4, 5, 4, 5)
        settings_login_btn.Name = "settings_login_btn"
        settings_login_btn.Size = New Size(50, 58)
        settings_login_btn.TabIndex = 0
        settings_login_btn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.tower_na_malupet_removebg_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(50, 167)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(257, 833)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' loginform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1429, 1000)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "loginform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents un_tb As TextBox
    Friend WithEvents pass_tb As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents settings_login_btn As Button
    Friend WithEvents login_btn As Button

End Class