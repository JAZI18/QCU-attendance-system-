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
        count_lb = New Label()
        label_lb = New Label()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' count_lb
        ' 
        count_lb.BackColor = Color.Transparent
        count_lb.Dock = DockStyle.Fill
        count_lb.FlatStyle = FlatStyle.Flat
        count_lb.Font = New Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point)
        count_lb.Location = New Point(235, 0)
        count_lb.Margin = New Padding(0)
        count_lb.Name = "count_lb"
        count_lb.Size = New Size(237, 101)
        count_lb.TabIndex = 4
        count_lb.Text = "200"
        count_lb.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' label_lb
        ' 
        label_lb.BackColor = Color.Transparent
        label_lb.Dock = DockStyle.Fill
        label_lb.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        label_lb.Location = New Point(20, 0)
        label_lb.Margin = New Padding(0)
        label_lb.Name = "label_lb"
        label_lb.Size = New Size(215, 101)
        label_lb.TabIndex = 3
        label_lb.Text = "-----"
        label_lb.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(20, 101)
        Panel1.TabIndex = 6
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 47.6190453F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 52.38095F))
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(count_lb, 2, 0)
        TableLayoutPanel1.Controls.Add(label_lb, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(472, 101)
        TableLayoutPanel1.TabIndex = 7
        ' 
        ' stats_button
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(0)
        Name = "stats_button"
        Size = New Size(472, 101)
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents label_lb As Label
    Friend WithEvents count_lb As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
