<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addLeave
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
        Label3 = New Label()
        date_picker = New DateTimePicker()
        TableLayoutPanel1 = New TableLayoutPanel()
        branch_tb = New TextBox()
        code_tb = New TextBox()
        emp_name_tb = New TextBox()
        Label4 = New Label()
        add_leave_btn = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(23, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 72)
        Label1.TabIndex = 2
        Label1.Text = "CODE"
        Label1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(23, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(347, 43)
        Label2.TabIndex = 3
        Label2.Text = "BRANCH"
        Label2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(441, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(348, 43)
        Label3.TabIndex = 4
        Label3.Text = "DATE"
        Label3.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' date_picker
        ' 
        date_picker.Dock = DockStyle.Fill
        date_picker.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        date_picker.Location = New Point(441, 164)
        date_picker.Name = "date_picker"
        date_picker.Size = New Size(348, 34)
        date_picker.TabIndex = 5
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.78587F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.428262F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.78587F))
        TableLayoutPanel1.Controls.Add(branch_tb, 0, 4)
        TableLayoutPanel1.Controls.Add(code_tb, 0, 1)
        TableLayoutPanel1.Controls.Add(Label3, 2, 3)
        TableLayoutPanel1.Controls.Add(date_picker, 2, 4)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 3)
        TableLayoutPanel1.Controls.Add(emp_name_tb, 2, 1)
        TableLayoutPanel1.Controls.Add(Label4, 2, 0)
        TableLayoutPanel1.Controls.Add(add_leave_btn, 2, 5)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(20, 3, 20, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(20, 0, 20, 0)
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25.2525253F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.8047142F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 2.6936028F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.0349646F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.62937F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 22.0279713F))
        TableLayoutPanel1.Size = New Size(812, 286)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' branch_tb
        ' 
        branch_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        branch_tb.AutoCompleteSource = AutoCompleteSource.CustomSource
        branch_tb.Dock = DockStyle.Fill
        branch_tb.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        branch_tb.Location = New Point(23, 164)
        branch_tb.Name = "branch_tb"
        branch_tb.Size = New Size(347, 34)
        branch_tb.TabIndex = 15
        ' 
        ' code_tb
        ' 
        code_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        code_tb.AutoCompleteSource = AutoCompleteSource.CustomSource
        code_tb.Dock = DockStyle.Fill
        code_tb.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        code_tb.Location = New Point(23, 75)
        code_tb.Name = "code_tb"
        code_tb.Size = New Size(347, 34)
        code_tb.TabIndex = 9
        ' 
        ' emp_name_tb
        ' 
        emp_name_tb.Dock = DockStyle.Fill
        emp_name_tb.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        emp_name_tb.Location = New Point(441, 75)
        emp_name_tb.Name = "emp_name_tb"
        emp_name_tb.ReadOnly = True
        emp_name_tb.Size = New Size(348, 34)
        emp_name_tb.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(441, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(348, 72)
        Label4.TabIndex = 2
        Label4.Text = "NAME"
        Label4.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' add_leave_btn
        ' 
        add_leave_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        add_leave_btn.BackColor = Color.Red
        add_leave_btn.ForeColor = SystemColors.ButtonFace
        add_leave_btn.Location = New Point(441, 223)
        add_leave_btn.Name = "add_leave_btn"
        add_leave_btn.Size = New Size(348, 42)
        add_leave_btn.TabIndex = 7
        add_leave_btn.Text = "ADD"
        add_leave_btn.UseVisualStyleBackColor = False
        ' 
        ' addLeave
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(812, 286)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "addLeave"
        Text = "addLeave"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents date_picker As DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents emp_name_tb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents add_leave_btn As Button
    Friend WithEvents branch_tb As TextBox
    Friend WithEvents code_tb As TextBox
End Class
