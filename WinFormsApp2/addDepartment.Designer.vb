<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addDepartment
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
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        dep_name = New TextBox()
        dep_desc = New TextBox()
        Label4 = New Label()
        sub_btn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(23, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 25)
        Label1.TabIndex = 5
        Label1.Text = "Add Department"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(223, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 25)
        Label3.TabIndex = 14
        Label3.Text = "X"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(23, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 21)
        Label2.TabIndex = 15
        Label2.Text = "Department Name"
        ' 
        ' dep_name
        ' 
        dep_name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dep_name.Location = New Point(23, 94)
        dep_name.Name = "dep_name"
        dep_name.Size = New Size(235, 29)
        dep_name.TabIndex = 16
        ' 
        ' dep_desc
        ' 
        dep_desc.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dep_desc.Location = New Point(23, 171)
        dep_desc.Name = "dep_desc"
        dep_desc.Size = New Size(235, 29)
        dep_desc.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(31, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 21)
        Label4.TabIndex = 18
        Label4.Text = "Department Desc"
        ' 
        ' sub_btn
        ' 
        sub_btn.Location = New Point(146, 224)
        sub_btn.Name = "sub_btn"
        sub_btn.Size = New Size(112, 33)
        sub_btn.TabIndex = 19
        sub_btn.Text = "Submit"
        sub_btn.UseVisualStyleBackColor = True
        ' 
        ' addDepartment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(291, 280)
        Controls.Add(sub_btn)
        Controls.Add(Label4)
        Controls.Add(dep_desc)
        Controls.Add(dep_name)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "addDepartment"
        Text = "addDepartment"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dep_name As TextBox
    Friend WithEvents dep_desc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sub_btn As Button
End Class
