<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_department
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
        dep_name = New TextBox()
        dep_desc = New TextBox()
        Label4 = New Label()
        sub_btn = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(57, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 21)
        Label2.TabIndex = 14
        Label2.Text = "Department Name"
        ' 
        ' dep_name
        ' 
        dep_name.BackColor = Color.White
        dep_name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dep_name.Location = New Point(57, 70)
        dep_name.Name = "dep_name"
        dep_name.Size = New Size(235, 29)
        dep_name.TabIndex = 15
        ' 
        ' dep_desc
        ' 
        dep_desc.BackColor = Color.White
        dep_desc.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dep_desc.Location = New Point(57, 143)
        dep_desc.Name = "dep_desc"
        dep_desc.Size = New Size(235, 29)
        dep_desc.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(57, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 21)
        Label4.TabIndex = 17
        Label4.Text = "Department Desc"
        ' 
        ' sub_btn
        ' 
        sub_btn.BackColor = Color.Red
        sub_btn.FlatAppearance.BorderSize = 0
        sub_btn.FlatStyle = FlatStyle.Flat
        sub_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        sub_btn.ForeColor = SystemColors.ButtonHighlight
        sub_btn.Location = New Point(127, 198)
        sub_btn.Name = "sub_btn"
        sub_btn.Size = New Size(100, 38)
        sub_btn.TabIndex = 19
        sub_btn.Text = "Submit"
        sub_btn.UseVisualStyleBackColor = False
        ' 
        ' Update_department
        ' 
        AcceptButton = sub_btn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(223), CByte(223), CByte(223))
        ClientSize = New Size(353, 293)
        Controls.Add(sub_btn)
        Controls.Add(Label4)
        Controls.Add(dep_desc)
        Controls.Add(dep_name)
        Controls.Add(Label2)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Update_department"
        Text = "Update"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents dep_name As TextBox
    Friend WithEvents dep_desc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sub_btn As Button
End Class
