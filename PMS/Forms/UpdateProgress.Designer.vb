<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProgress
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateProgress))
        Me.UpdateProgressGroupBox = New System.Windows.Forms.GroupBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.ProgressTrackBar = New System.Windows.Forms.TrackBar()
        Me.ProjectsComboBox = New System.Windows.Forms.ComboBox()
        Me.ResourceAllocationGroupBox = New System.Windows.Forms.GroupBox()
        Me.AllocateButton = New System.Windows.Forms.Button()
        Me.ResourceNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.UpdateProgressGroupBox.SuspendLayout
        CType(Me.ProgressTrackBar,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ResourceAllocationGroupBox.SuspendLayout
        CType(Me.ResourceNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'UpdateProgressGroupBox
        '
        Me.UpdateProgressGroupBox.Controls.Add(Me.UpdateButton)
        Me.UpdateProgressGroupBox.Controls.Add(Me.ProgressLabel)
        Me.UpdateProgressGroupBox.Controls.Add(Me.ProgressTrackBar)
        Me.UpdateProgressGroupBox.Controls.Add(Me.ProjectsComboBox)
        Me.UpdateProgressGroupBox.Location = New System.Drawing.Point(13, 10)
        Me.UpdateProgressGroupBox.Name = "UpdateProgressGroupBox"
        Me.UpdateProgressGroupBox.Size = New System.Drawing.Size(259, 130)
        Me.UpdateProgressGroupBox.TabIndex = 2
        Me.UpdateProgressGroupBox.TabStop = false
        Me.UpdateProgressGroupBox.Text = "Update Progress"
        '
        'UpdateButton
        '
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton.Location = New System.Drawing.Point(6, 99)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 7
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = true
        '
        'ProgressLabel
        '
        Me.ProgressLabel.AutoSize = true
        Me.ProgressLabel.Location = New System.Drawing.Point(219, 80)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(21, 13)
        Me.ProgressLabel.TabIndex = 6
        Me.ProgressLabel.Text = "0%"
        '
        'ProgressTrackBar
        '
        Me.ProgressTrackBar.Location = New System.Drawing.Point(5, 48)
        Me.ProgressTrackBar.Maximum = 100
        Me.ProgressTrackBar.Name = "ProgressTrackBar"
        Me.ProgressTrackBar.Size = New System.Drawing.Size(208, 45)
        Me.ProgressTrackBar.TabIndex = 5
        Me.ProgressTrackBar.TabStop = false
        '
        'ProjectsComboBox
        '
        Me.ProjectsComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProjectsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProjectsComboBox.FormattingEnabled = true
        Me.ProjectsComboBox.Location = New System.Drawing.Point(5, 21)
        Me.ProjectsComboBox.Name = "ProjectsComboBox"
        Me.ProjectsComboBox.Size = New System.Drawing.Size(248, 21)
        Me.ProjectsComboBox.TabIndex = 4
        '
        'ResourceAllocationGroupBox
        '
        Me.ResourceAllocationGroupBox.Controls.Add(Me.AllocateButton)
        Me.ResourceAllocationGroupBox.Controls.Add(Me.ResourceNumericBox)
        Me.ResourceAllocationGroupBox.Location = New System.Drawing.Point(12, 146)
        Me.ResourceAllocationGroupBox.Name = "ResourceAllocationGroupBox"
        Me.ResourceAllocationGroupBox.Size = New System.Drawing.Size(260, 55)
        Me.ResourceAllocationGroupBox.TabIndex = 3
        Me.ResourceAllocationGroupBox.TabStop = false
        Me.ResourceAllocationGroupBox.Text = "Allocate More Resource"
        '
        'AllocateButton
        '
        Me.AllocateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AllocateButton.Location = New System.Drawing.Point(179, 18)
        Me.AllocateButton.Name = "AllocateButton"
        Me.AllocateButton.Size = New System.Drawing.Size(75, 23)
        Me.AllocateButton.TabIndex = 8
        Me.AllocateButton.Text = "Allocate"
        Me.AllocateButton.UseVisualStyleBackColor = true
        '
        'ResourceNumericBox
        '
        Me.ResourceNumericBox.Location = New System.Drawing.Point(6, 21)
        Me.ResourceNumericBox.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.ResourceNumericBox.Name = "ResourceNumericBox"
        Me.ResourceNumericBox.Size = New System.Drawing.Size(167, 20)
        Me.ResourceNumericBox.TabIndex = 0
        '
        'UpdateProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 210)
        Me.Controls.Add(Me.UpdateProgressGroupBox)
        Me.Controls.Add(Me.ResourceAllocationGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "UpdateProgress"
        Me.Text = "UpdateProgress"
        Me.UpdateProgressGroupBox.ResumeLayout(false)
        Me.UpdateProgressGroupBox.PerformLayout
        CType(Me.ProgressTrackBar,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResourceAllocationGroupBox.ResumeLayout(false)
        CType(Me.ResourceNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Private WithEvents UpdateProgressGroupBox As GroupBox
    Private WithEvents UpdateButton As Button
    Private WithEvents ProgressLabel As Label
    Private WithEvents ProgressTrackBar As TrackBar
    Private WithEvents ProjectsComboBox As ComboBox
    Private WithEvents ResourceAllocationGroupBox As GroupBox
    Private WithEvents AllocateButton As Button
    Private WithEvents ResourceNumericBox As NumericUpDown
End Class
