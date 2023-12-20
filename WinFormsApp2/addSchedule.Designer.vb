<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addSchedule
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
        e_dep = New ComboBox()
        f = New Label()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' e_dep
        ' 
        e_dep.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        e_dep.FormattingEnabled = True
        e_dep.Location = New Point(274, 52)
        e_dep.Name = "e_dep"
        e_dep.Size = New Size(194, 29)
        e_dep.TabIndex = 30
        ' 
        ' f
        ' 
        f.AutoSize = True
        f.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        f.Location = New Point(25, 28)
        f.Name = "f"
        f.Size = New Size(72, 21)
        f.TabIndex = 32
        f.Text = "Workday"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(25, 52)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(194, 29)
        ComboBox1.TabIndex = 33
        ' 
        ' addSchedule
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 349)
        Controls.Add(ComboBox1)
        Controls.Add(f)
        Controls.Add(e_dep)
        Name = "addSchedule"
        Text = "addSchedule"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents e_dep As ComboBox
    Friend WithEvents f As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
