<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateTimesheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateTimesheet))
        Me.TimesheetDataGridView = New System.Windows.Forms.DataGridView()
        Me.DayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkHoursColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtraHoursColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectTextBox = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        CType(Me.TimesheetDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TimesheetDataGridView
        '
        Me.TimesheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimesheetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DayColumn, Me.WorkHoursColumn, Me.ExtraHoursColumn, Me.FeesColumn})
        Me.TimesheetDataGridView.Location = New System.Drawing.Point(11, 66)
        Me.TimesheetDataGridView.Name = "TimesheetDataGridView"
        Me.TimesheetDataGridView.Size = New System.Drawing.Size(453, 182)
        Me.TimesheetDataGridView.TabIndex = 23
        '
        'DayColumn
        '
        Me.DayColumn.HeaderText = "Day"
        Me.DayColumn.Name = "DayColumn"
        '
        'WorkHoursColumn
        '
        Me.WorkHoursColumn.HeaderText = "Work Hours"
        Me.WorkHoursColumn.Name = "WorkHoursColumn"
        '
        'ExtraHoursColumn
        '
        Me.ExtraHoursColumn.HeaderText = "Extra Hours"
        Me.ExtraHoursColumn.Name = "ExtraHoursColumn"
        '
        'FeesColumn
        '
        Me.FeesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FeesColumn.HeaderText = "Fees"
        Me.FeesColumn.Name = "FeesColumn"
        '
        'ProjectTextBox
        '
        Me.ProjectTextBox.Location = New System.Drawing.Point(302, 38)
        Me.ProjectTextBox.Name = "ProjectTextBox"
        Me.ProjectTextBox.Size = New System.Drawing.Size(163, 20)
        Me.ProjectTextBox.TabIndex = 22
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(225, 13)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(65, 13)
        Me.label4.TabIndex = 21
        Me.label4.Text = "Department:"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.Location = New System.Drawing.Point(302, 10)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(163, 20)
        Me.DepartmentTextBox.TabIndex = 20
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(251, 41)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(43, 13)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Project:"
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(29, 41)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(21, 13)
        Me.label2.TabIndex = 18
        Me.label2.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(56, 38)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(163, 20)
        Me.IDTextBox.TabIndex = 17
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(11, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(56, 10)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(163, 20)
        Me.NameTextBox.TabIndex = 15
        '
        'ResetButton
        '
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Location = New System.Drawing.Point(389, 254)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 25
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = true
        '
        'ExportButton
        '
        Me.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExportButton.Location = New System.Drawing.Point(11, 254)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportButton.TabIndex = 24
        Me.ExportButton.Text = "Export"
        Me.ExportButton.UseVisualStyleBackColor = true
        '
        'GenerateTimesheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 287)
        Me.Controls.Add(Me.TimesheetDataGridView)
        Me.Controls.Add(Me.ProjectTextBox)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ExportButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "GenerateTimesheet"
        Me.Text = "Generate Timesheet"
        CType(Me.TimesheetDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents TimesheetDataGridView As DataGridView
    Private WithEvents DayColumn As DataGridViewTextBoxColumn
    Private WithEvents WorkHoursColumn As DataGridViewTextBoxColumn
    Private WithEvents ExtraHoursColumn As DataGridViewTextBoxColumn
    Private WithEvents FeesColumn As DataGridViewTextBoxColumn
    Private WithEvents ProjectTextBox As TextBox
    Private WithEvents label4 As Label
    Private WithEvents DepartmentTextBox As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents IDTextBox As TextBox
    Private WithEvents label1 As Label
    Private WithEvents NameTextBox As TextBox
    Private WithEvents ResetButton As Button
    Private WithEvents ExportButton As Button
End Class
