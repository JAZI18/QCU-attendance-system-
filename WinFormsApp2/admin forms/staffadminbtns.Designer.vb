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
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' admin_btn
        ' 
        admin_btn.Dock = DockStyle.Fill
        admin_btn.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        admin_btn.Image = My.Resources.Resources.Admin_button_icaon
        admin_btn.Location = New Point(610, 3)
        admin_btn.Name = "admin_btn"
        admin_btn.Size = New Size(397, 204)
        admin_btn.TabIndex = 0
        admin_btn.Text = "ADMIN"
        admin_btn.TextAlign = ContentAlignment.BottomCenter
        admin_btn.TextImageRelation = TextImageRelation.ImageAboveText
        admin_btn.UseVisualStyleBackColor = True
        ' 
        ' staff_btn
        ' 
        staff_btn.Dock = DockStyle.Fill
        staff_btn.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        staff_btn.Image = My.Resources.Resources.staff_button_icon
        staff_btn.Location = New Point(83, 3)
        staff_btn.Name = "staff_btn"
        staff_btn.Size = New Size(397, 204)
        staff_btn.TabIndex = 1
        staff_btn.Text = "STAFF"
        staff_btn.TextAlign = ContentAlignment.BottomCenter
        staff_btn.TextImageRelation = TextImageRelation.ImageAboveText
        staff_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(2, 2)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1095, 35)
        Panel1.TabIndex = 2
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.387445F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 36.9372253F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.3506622F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 36.9372253F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.387445F))
        TableLayoutPanel1.Controls.Add(admin_btn, 3, 0)
        TableLayoutPanel1.Controls.Add(staff_btn, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 219)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1093, 210)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 1)
        TableLayoutPanel2.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Size = New Size(1099, 650)
        TableLayoutPanel2.TabIndex = 4
        ' 
        ' staffadminbtns
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1099, 650)
        Controls.Add(TableLayoutPanel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "staffadminbtns"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents admin_btn As Button
    Friend WithEvents staff_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
