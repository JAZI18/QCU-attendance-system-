﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAdmin
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Label1 = New Label()
        e_firstname = New TextBox()
        f = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 25)
        Label1.TabIndex = 2
        Label1.Text = "Add Admin"
        ' 
        ' e_firstname
        ' 
        e_firstname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_firstname.Location = New Point(23, 100)
        e_firstname.Name = "e_firstname"
        e_firstname.Size = New Size(235, 29)
        e_firstname.TabIndex = 3
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        f.Location = New Point(23, 147)
        f.Name = "f"
        f.Size = New Size(79, 21)
        f.TabIndex = 4
        f.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(23, 171)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(235, 29)
        TextBox1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(21, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 21)
        Label2.TabIndex = 6
        Label2.Text = "Username"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(143, 222)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 29)
        Button1.TabIndex = 7
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(234, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 25)
        Label3.TabIndex = 8
        Label3.Text = "X"
        ' 
        ' addAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(f)
        Controls.Add(e_firstname)
        Controls.Add(Label1)
        Name = "addAdmin"
        Size = New Size(273, 288)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents e_firstname As TextBox
    Friend WithEvents f As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
