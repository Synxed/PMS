<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectRegistration))
        Me.BudgetNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.DurationNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.ResourceNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.SkillsetTextbox = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.ClientDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ProjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.BudgetNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DurationNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ResourceNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'BudgetNumericBox
        '
        Me.BudgetNumericBox.Location = New System.Drawing.Point(96, 66)
        Me.BudgetNumericBox.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.BudgetNumericBox.Name = "BudgetNumericBox"
        Me.BudgetNumericBox.Size = New System.Drawing.Size(177, 20)
        Me.BudgetNumericBox.TabIndex = 18
        '
        'DurationNumericBox
        '
        Me.DurationNumericBox.Location = New System.Drawing.Point(96, 94)
        Me.DurationNumericBox.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.DurationNumericBox.Name = "DurationNumericBox"
        Me.DurationNumericBox.Size = New System.Drawing.Size(177, 20)
        Me.DurationNumericBox.TabIndex = 20
        '
        'RegisterButton
        '
        Me.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegisterButton.Location = New System.Drawing.Point(13, 178)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 23)
        Me.RegisterButton.TabIndex = 28
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = true
        '
        'ResetButton
        '
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Location = New System.Drawing.Point(198, 178)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 27
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = true
        '
        'label6
        '
        Me.label6.AutoSize = true
        Me.label6.Location = New System.Drawing.Point(33, 152)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 13)
        Me.label6.TabIndex = 26
        Me.label6.Text = "Resource:"
        '
        'ResourceNumericBox
        '
        Me.ResourceNumericBox.Location = New System.Drawing.Point(96, 150)
        Me.ResourceNumericBox.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.ResourceNumericBox.Name = "ResourceNumericBox"
        Me.ResourceNumericBox.Size = New System.Drawing.Size(177, 20)
        Me.ResourceNumericBox.TabIndex = 23
        '
        'SkillsetTextbox
        '
        Me.SkillsetTextbox.Location = New System.Drawing.Point(96, 122)
        Me.SkillsetTextbox.Name = "SkillsetTextbox"
        Me.SkillsetTextbox.Size = New System.Drawing.Size(177, 20)
        Me.SkillsetTextbox.TabIndex = 21
        '
        'label5
        '
        Me.label5.AutoSize = true
        Me.label5.Location = New System.Drawing.Point(44, 125)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(43, 13)
        Me.label5.TabIndex = 25
        Me.label5.Text = "Skillset:"
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(32, 96)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(50, 13)
        Me.label4.TabIndex = 24
        Me.label4.Text = "Duration:"
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(42, 69)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(44, 13)
        Me.label3.TabIndex = 22
        Me.label3.Text = "Budget:"
        '
        'ClientDetailsTextBox
        '
        Me.ClientDetailsTextBox.Location = New System.Drawing.Point(96, 38)
        Me.ClientDetailsTextBox.Name = "ClientDetailsTextBox"
        Me.ClientDetailsTextBox.Size = New System.Drawing.Size(177, 20)
        Me.ClientDetailsTextBox.TabIndex = 17
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(12, 41)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(71, 13)
        Me.label2.TabIndex = 19
        Me.label2.Text = "Client Details:"
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.Location = New System.Drawing.Point(96, 10)
        Me.ProjectNameTextBox.Name = "ProjectNameTextBox"
        Me.ProjectNameTextBox.Size = New System.Drawing.Size(177, 20)
        Me.ProjectNameTextBox.TabIndex = 15
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(13, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(74, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Project Name:"
        '
        'ProjectRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 210)
        Me.Controls.Add(Me.BudgetNumericBox)
        Me.Controls.Add(Me.DurationNumericBox)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.ResourceNumericBox)
        Me.Controls.Add(Me.SkillsetTextbox)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.ClientDetailsTextBox)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.ProjectNameTextBox)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "ProjectRegistration"
        Me.Text = "ProjectRegistration"
        CType(Me.BudgetNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DurationNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ResourceNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents BudgetNumericBox As NumericUpDown
    Private WithEvents DurationNumericBox As NumericUpDown
    Private WithEvents RegisterButton As Button
    Private WithEvents ResetButton As Button
    Private WithEvents label6 As Label
    Private WithEvents ResourceNumericBox As NumericUpDown
    Private WithEvents SkillsetTextbox As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents ClientDetailsTextBox As TextBox
    Private WithEvents label2 As Label
    Private WithEvents ProjectNameTextBox As TextBox
    Private WithEvents label1 As Label
End Class
