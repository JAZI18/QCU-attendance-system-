<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminAdd
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
        Label2 = New Label()
        e_firstname = New TextBox()
        f = New Label()
        e_password = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(38, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 7
        Label2.Text = "Username"
        ' 
        ' e_firstname
        ' 
        e_firstname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_firstname.Location = New Point(41, 53)
        e_firstname.Name = "e_firstname"
        e_firstname.Size = New Size(235, 29)
        e_firstname.TabIndex = 8
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        f.Location = New Point(39, 99)
        f.Name = "f"
        f.Size = New Size(76, 21)
        f.TabIndex = 9
        f.Text = "Password"
        ' 
        ' e_password
        ' 
        e_password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_password.Location = New Point(41, 123)
        e_password.Name = "e_password"
        e_password.Size = New Size(235, 29)
        e_password.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(42, 184)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 35)
        Button1.TabIndex = 11
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' adminAdd
        ' 
        AcceptButton = Button1
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(223), CByte(223), CByte(223))
        ClientSize = New Size(322, 252)
        Controls.Add(Button1)
        Controls.Add(e_password)
        Controls.Add(f)
        Controls.Add(e_firstname)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "adminAdd"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents e_firstname As TextBox
    Friend WithEvents f As Label
    Friend WithEvents e_password As TextBox
    Friend WithEvents Button1 As Button
End Class
