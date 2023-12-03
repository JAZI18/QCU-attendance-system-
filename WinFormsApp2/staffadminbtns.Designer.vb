<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffadminbtns
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
        admin_btn = New Button()
        staff_btn = New Button()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' admin_btn
        ' 
        admin_btn.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        admin_btn.Location = New Point(643, 167)
        admin_btn.Margin = New Padding(4, 5, 4, 5)
        admin_btn.Name = "admin_btn"
        admin_btn.Size = New Size(429, 333)
        admin_btn.TabIndex = 0
        admin_btn.Text = "ADMIN"
        admin_btn.UseVisualStyleBackColor = True
        ' 
        ' staff_btn
        ' 
        staff_btn.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        staff_btn.Location = New Point(71, 167)
        staff_btn.Margin = New Padding(4, 5, 4, 5)
        staff_btn.Name = "staff_btn"
        staff_btn.Size = New Size(429, 333)
        staff_btn.TabIndex = 1
        staff_btn.Text = "STAFF"
        staff_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Location = New Point(26, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1117, 35)
        Panel1.TabIndex = 2
        ' 
        ' staffadminbtns
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 667)
        Controls.Add(Panel1)
        Controls.Add(staff_btn)
        Controls.Add(admin_btn)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "staffadminbtns"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents admin_btn As Button
    Friend WithEvents staff_btn As Button
    Friend WithEvents Panel1 As Panel
End Class
