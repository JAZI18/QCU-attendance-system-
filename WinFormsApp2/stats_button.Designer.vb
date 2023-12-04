<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stats_button
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
        Panel1 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        label_lb = New Label()
        count_lb = New Label()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(14, 192)
        Panel1.TabIndex = 6
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 14F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(2)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(330, 192)
        TableLayoutPanel2.TabIndex = 8
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(label_lb, 0, 1)
        TableLayoutPanel3.Controls.Add(count_lb, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(14, 0)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 72.2067947F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 27.7931976F))
        TableLayoutPanel3.Size = New Size(316, 192)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' label_lb
        ' 
        label_lb.BackColor = Color.Transparent
        label_lb.Dock = DockStyle.Fill
        label_lb.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        label_lb.ForeColor = Color.DimGray
        label_lb.Location = New Point(0, 138)
        label_lb.Margin = New Padding(0)
        label_lb.Name = "label_lb"
        label_lb.Padding = New Padding(30, 0, 0, 0)
        label_lb.Size = New Size(316, 54)
        label_lb.TabIndex = 9
        label_lb.Text = "-----"
        ' 
        ' count_lb
        ' 
        count_lb.BackColor = Color.Transparent
        count_lb.Dock = DockStyle.Fill
        count_lb.FlatStyle = FlatStyle.Flat
        count_lb.Font = New Font("Sitka Text", 40F, FontStyle.Bold, GraphicsUnit.Point)
        count_lb.Location = New Point(0, 0)
        count_lb.Margin = New Padding(0)
        count_lb.Name = "count_lb"
        count_lb.Padding = New Padding(25, 0, 0, 0)
        count_lb.Size = New Size(316, 138)
        count_lb.TabIndex = 7
        count_lb.Text = "200"
        count_lb.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' stats_button
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        Controls.Add(TableLayoutPanel2)
        Margin = New Padding(0)
        Name = "stats_button"
        Size = New Size(330, 192)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents count_lb As Label
    Friend WithEvents label_lb As Label
End Class
