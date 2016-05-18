<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateBill))
        Me.GeneratedBillTextBox = New System.Windows.Forms.RichTextBox()
        Me.BillDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.IssuedOnDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.label3 = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.BillDetailsTextBox = New System.Windows.Forms.RichTextBox()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.AmountNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ClientAddressTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ClientNameTextBox = New System.Windows.Forms.TextBox()
        Me.BillDetailsGroupBox.SuspendLayout
        CType(Me.AmountNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GeneratedBillTextBox
        '
        Me.GeneratedBillTextBox.Location = New System.Drawing.Point(13, 259)
        Me.GeneratedBillTextBox.Name = "GeneratedBillTextBox"
        Me.GeneratedBillTextBox.ReadOnly = true
        Me.GeneratedBillTextBox.Size = New System.Drawing.Size(541, 233)
        Me.GeneratedBillTextBox.TabIndex = 3
        Me.GeneratedBillTextBox.TabStop = false
        Me.GeneratedBillTextBox.Text = ""
        '
        'BillDetailsGroupBox
        '
        Me.BillDetailsGroupBox.Controls.Add(Me.IssuedOnDateTimePicker)
        Me.BillDetailsGroupBox.Controls.Add(Me.label3)
        Me.BillDetailsGroupBox.Controls.Add(Me.ResetButton)
        Me.BillDetailsGroupBox.Controls.Add(Me.BillDetailsTextBox)
        Me.BillDetailsGroupBox.Controls.Add(Me.GenerateButton)
        Me.BillDetailsGroupBox.Controls.Add(Me.AmountNumericBox)
        Me.BillDetailsGroupBox.Controls.Add(Me.label4)
        Me.BillDetailsGroupBox.Controls.Add(Me.label2)
        Me.BillDetailsGroupBox.Controls.Add(Me.ClientAddressTextBox)
        Me.BillDetailsGroupBox.Controls.Add(Me.label1)
        Me.BillDetailsGroupBox.Controls.Add(Me.ClientNameTextBox)
        Me.BillDetailsGroupBox.Location = New System.Drawing.Point(13, 12)
        Me.BillDetailsGroupBox.Name = "BillDetailsGroupBox"
        Me.BillDetailsGroupBox.Size = New System.Drawing.Size(541, 241)
        Me.BillDetailsGroupBox.TabIndex = 2
        Me.BillDetailsGroupBox.TabStop = false
        Me.BillDetailsGroupBox.Text = "Bill Details"
        '
        'IssuedOnDateTimePicker
        '
        Me.IssuedOnDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IssuedOnDateTimePicker.CustomFormat = ""
        Me.IssuedOnDateTimePicker.Location = New System.Drawing.Point(327, 49)
        Me.IssuedOnDateTimePicker.MinDate = New Date(2016, 5, 17, 0, 0, 0, 0)
        Me.IssuedOnDateTimePicker.Name = "IssuedOnDateTimePicker"
        Me.IssuedOnDateTimePicker.Size = New System.Drawing.Size(206, 22)
        Me.IssuedOnDateTimePicker.TabIndex = 3
        Me.IssuedOnDateTimePicker.Value = New Date(2016, 5, 17, 23, 30, 37, 0)
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(259, 52)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(62, 13)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Issued On:"
        '
        'ResetButton
        '
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Location = New System.Drawing.Point(458, 209)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 6
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = true
        '
        'BillDetailsTextBox
        '
        Me.BillDetailsTextBox.AcceptsTab = true
        Me.BillDetailsTextBox.Location = New System.Drawing.Point(6, 81)
        Me.BillDetailsTextBox.Name = "BillDetailsTextBox"
        Me.BillDetailsTextBox.Size = New System.Drawing.Size(527, 122)
        Me.BillDetailsTextBox.TabIndex = 4
        Me.BillDetailsTextBox.Text = "Bill Details"
        '
        'GenerateButton
        '
        Me.GenerateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenerateButton.Location = New System.Drawing.Point(6, 209)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerateButton.TabIndex = 5
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = true
        '
        'AmountNumericBox
        '
        Me.AmountNumericBox.Location = New System.Drawing.Point(84, 49)
        Me.AmountNumericBox.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.AmountNumericBox.Name = "AmountNumericBox"
        Me.AmountNumericBox.Size = New System.Drawing.Size(147, 22)
        Me.AmountNumericBox.TabIndex = 2
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(27, 51)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(51, 13)
        Me.label4.TabIndex = 8
        Me.label4.Text = "Amount:"
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(237, 24)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(84, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Client Address:"
        '
        'ClientAddressTextBox
        '
        Me.ClientAddressTextBox.Location = New System.Drawing.Point(327, 21)
        Me.ClientAddressTextBox.Name = "ClientAddressTextBox"
        Me.ClientAddressTextBox.Size = New System.Drawing.Size(206, 22)
        Me.ClientAddressTextBox.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(6, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Client Name:"
        '
        'ClientNameTextBox
        '
        Me.ClientNameTextBox.Location = New System.Drawing.Point(84, 21)
        Me.ClientNameTextBox.Name = "ClientNameTextBox"
        Me.ClientNameTextBox.Size = New System.Drawing.Size(147, 22)
        Me.ClientNameTextBox.TabIndex = 0
        '
        'GenerateBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 505)
        Me.Controls.Add(Me.GeneratedBillTextBox)
        Me.Controls.Add(Me.BillDetailsGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "GenerateBill"
        Me.Text = "Generate Bill"
        Me.BillDetailsGroupBox.ResumeLayout(false)
        Me.BillDetailsGroupBox.PerformLayout
        CType(Me.AmountNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Private WithEvents GeneratedBillTextBox As RichTextBox
    Private WithEvents BillDetailsGroupBox As GroupBox
    Private WithEvents IssuedOnDateTimePicker As DateTimePicker
    Private WithEvents label3 As Label
    Private WithEvents ResetButton As Button
    Private WithEvents BillDetailsTextBox As RichTextBox
    Private WithEvents GenerateButton As Button
    Private WithEvents AmountNumericBox As NumericUpDown
    Private WithEvents label4 As Label
    Private WithEvents label2 As Label
    Private WithEvents ClientAddressTextBox As TextBox
    Private WithEvents label1 As Label
    Private WithEvents ClientNameTextBox As TextBox
End Class
