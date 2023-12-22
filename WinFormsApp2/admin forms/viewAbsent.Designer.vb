<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewAbsent
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
        search_absent = New TextBox()
        search_btn_dept = New Button()
        print = New Button()
        export = New Button()
        DataGridView1 = New DataGridView()
        emp_id = New DataGridViewTextBoxColumn()
        branch = New DataGridViewTextBoxColumn()
        emp_name = New DataGridViewTextBoxColumn()
        workday = New DataGridViewTextBoxColumn()
        dates = New DataGridViewTextBoxColumn()
        status = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' search_absent
        ' 
        search_absent.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        search_absent.Location = New Point(12, 33)
        search_absent.Name = "search_absent"
        search_absent.Size = New Size(211, 29)
        search_absent.TabIndex = 6
        ' 
        ' search_btn_dept
        ' 
        search_btn_dept.BackColor = Color.Red
        search_btn_dept.FlatAppearance.BorderColor = Color.Red
        search_btn_dept.FlatStyle = FlatStyle.Flat
        search_btn_dept.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        search_btn_dept.ForeColor = Color.White
        search_btn_dept.Location = New Point(229, 34)
        search_btn_dept.Name = "search_btn_dept"
        search_btn_dept.Size = New Size(80, 29)
        search_btn_dept.TabIndex = 7
        search_btn_dept.Text = "Search"
        search_btn_dept.UseVisualStyleBackColor = False
        ' 
        ' print
        ' 
        print.BackColor = Color.Blue
        print.FlatAppearance.BorderColor = Color.Red
        print.FlatStyle = FlatStyle.Flat
        print.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        print.ForeColor = Color.White
        print.Location = New Point(592, 33)
        print.Name = "print"
        print.Size = New Size(84, 30)
        print.TabIndex = 8
        print.Text = "Print Report"
        print.UseVisualStyleBackColor = False
        ' 
        ' export
        ' 
        export.BackColor = Color.Green
        export.FlatAppearance.BorderColor = Color.Red
        export.FlatStyle = FlatStyle.Flat
        export.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        export.ForeColor = Color.White
        export.Location = New Point(696, 33)
        export.Name = "export"
        export.Size = New Size(92, 30)
        export.TabIndex = 9
        export.Text = "Export Report"
        export.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {emp_id, branch, emp_name, workday, dates, status})
        DataGridView1.Location = New Point(17, 102)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(809, 315)
        DataGridView1.TabIndex = 10
        ' 
        ' emp_id
        ' 
        emp_id.HeaderText = "Employee Code"
        emp_id.Name = "emp_id"
        emp_id.Width = 115
        ' 
        ' branch
        ' 
        branch.HeaderText = "Branch Name"
        branch.Name = "branch"
        branch.Width = 130
        ' 
        ' emp_name
        ' 
        emp_name.HeaderText = "Employee Name"
        emp_name.Name = "emp_name"
        emp_name.Width = 160
        ' 
        ' workday
        ' 
        workday.HeaderText = "Workday"
        workday.Name = "workday"
        ' 
        ' dates
        ' 
        dates.HeaderText = "Date"
        dates.Name = "dates"
        dates.Width = 140
        ' 
        ' status
        ' 
        status.HeaderText = "Absent"
        status.Name = "status"
        status.Width = 120
        ' 
        ' viewAbsent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(830, 450)
        Controls.Add(DataGridView1)
        Controls.Add(export)
        Controls.Add(print)
        Controls.Add(search_btn_dept)
        Controls.Add(search_absent)
        Name = "viewAbsent"
        Text = "viewAbsent"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents search_absent As TextBox
    Friend WithEvents search_btn_dept As Button
    Friend WithEvents print As Button
    Friend WithEvents export As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents emp_id As DataGridViewTextBoxColumn
    Friend WithEvents branch As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents workday As DataGridViewTextBoxColumn
    Friend WithEvents dates As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
