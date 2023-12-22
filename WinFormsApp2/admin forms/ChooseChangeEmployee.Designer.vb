<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseChangeEmployee
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
        update_tbn = New Button()
        del_btn = New Button()
        set_as_admin_btn = New Button()
        cancel_btn = New Button()
        Label2 = New Label()
        addsched_btn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 80)
        Label1.TabIndex = 0
        Label1.Text = "Select the action you would" & vbCrLf & " like to perform on the Employee " & vbCrLf & "profile: " & vbCrLf & vbCrLf
        ' 
        ' update_tbn
        ' 
        update_tbn.BackColor = Color.Blue
        update_tbn.FlatStyle = FlatStyle.Flat
        update_tbn.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        update_tbn.ForeColor = Color.White
        update_tbn.Location = New Point(73, 199)
        update_tbn.Name = "update_tbn"
        update_tbn.Size = New Size(100, 38)
        update_tbn.TabIndex = 1
        update_tbn.Text = "Update"
        update_tbn.UseVisualStyleBackColor = False
        ' 
        ' del_btn
        ' 
        del_btn.BackColor = Color.Red
        del_btn.FlatStyle = FlatStyle.Flat
        del_btn.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        del_btn.ForeColor = Color.White
        del_btn.Location = New Point(190, 199)
        del_btn.Name = "del_btn"
        del_btn.Size = New Size(100, 38)
        del_btn.TabIndex = 2
        del_btn.Text = "Delete"
        del_btn.UseVisualStyleBackColor = False
        ' 
        ' set_as_admin_btn
        ' 
        set_as_admin_btn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        set_as_admin_btn.FlatStyle = FlatStyle.Flat
        set_as_admin_btn.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        set_as_admin_btn.ForeColor = Color.White
        set_as_admin_btn.Location = New Point(492, 3)
        set_as_admin_btn.Name = "set_as_admin_btn"
        set_as_admin_btn.Size = New Size(73, 32)
        set_as_admin_btn.TabIndex = 3
        set_as_admin_btn.Text = "+ ADMIN"
        set_as_admin_btn.UseVisualStyleBackColor = False
        ' 
        ' cancel_btn
        ' 
        cancel_btn.BackColor = Color.White
        cancel_btn.FlatStyle = FlatStyle.Flat
        cancel_btn.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        cancel_btn.ForeColor = Color.Red
        cancel_btn.Location = New Point(419, 199)
        cancel_btn.Name = "cancel_btn"
        cancel_btn.Size = New Size(100, 38)
        cancel_btn.TabIndex = 4
        cancel_btn.Text = "Cancel"
        cancel_btn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label2.Location = New Point(73, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 5
        Label2.Text = "Name"
        ' 
        ' addsched_btn
        ' 
        addsched_btn.BackColor = Color.Green
        addsched_btn.FlatStyle = FlatStyle.Flat
        addsched_btn.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        addsched_btn.ForeColor = Color.White
        addsched_btn.Location = New Point(313, 199)
        addsched_btn.Name = "addsched_btn"
        addsched_btn.Size = New Size(100, 38)
        addsched_btn.TabIndex = 6
        addsched_btn.Text = "Add Schedule"
        addsched_btn.UseVisualStyleBackColor = False
        ' 
        ' ChooseChangeEmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 262)
        Controls.Add(addsched_btn)
        Controls.Add(Label2)
        Controls.Add(cancel_btn)
        Controls.Add(set_as_admin_btn)
        Controls.Add(del_btn)
        Controls.Add(update_tbn)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "ChooseChangeEmployee"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents update_tbn As Button
    Friend WithEvents del_btn As Button
    Friend WithEvents set_as_admin_btn As Button
    Friend WithEvents cancel_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents addsched_btn As Button
End Class
