<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BranchSelect
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
        select_branch_tb = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' select_branch_tb
        ' 
        select_branch_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        select_branch_tb.AutoCompleteSource = AutoCompleteSource.CustomSource
        select_branch_tb.Font = New Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point)
        select_branch_tb.Location = New Point(47, 137)
        select_branch_tb.Margin = New Padding(3, 3, 3, 100)
        select_branch_tb.Name = "select_branch_tb"
        select_branch_tb.Size = New Size(606, 74)
        select_branch_tb.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(692, 134)
        Label1.TabIndex = 1
        Label1.Text = "BRANCH"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BranchSelect
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(692, 266)
        Controls.Add(select_branch_tb)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "BranchSelect"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents select_branch_tb As TextBox
    Friend WithEvents Label1 As Label
End Class
