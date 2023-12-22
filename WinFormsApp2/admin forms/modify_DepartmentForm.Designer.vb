<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modify_DepartmentForm
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
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 95)
        Label1.TabIndex = 1
        Label1.Text = "Select the action you would like to  " & vbCrLf & "perform on the Employee Department  " & vbCrLf & "Name:" & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label2.Location = New Point(68, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 19)
        Label2.TabIndex = 6
        Label2.Text = "Name"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(78, 196)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 38)
        Button1.TabIndex = 7
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(190, 196)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 38)
        Button2.TabIndex = 8
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.Red
        Button4.Location = New Point(302, 196)
        Button4.Name = "Button4"
        Button4.Size = New Size(100, 38)
        Button4.TabIndex = 9
        Button4.Text = "Cancel"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' modify_DepartmentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(495, 257)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "modify_DepartmentForm"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
End Class
