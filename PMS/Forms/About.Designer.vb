<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(14, 145)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(273, 88)
        Me.label4.TabIndex = 7
        Me.label4.Text = "11500114118 - Tanmoy Pal"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"11500114119 - Tasmia Javed"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"11500114120 - Tathagat Bisw"& _ 
    "as"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"11500114121 - Trisha Bhaduri "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"11500114122 - Uday Pratap"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"11500114124 - Md. "& _ 
    "Abdul Halim Gazi"
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label3.Location = New System.Drawing.Point(13, 117)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(194, 19)
        Me.label3.TabIndex = 6
        Me.label3.Text = "This Program is Developed By:"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(14, 32)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(273, 85)
        Me.label2.TabIndex = 5
        Me.label2.Text = resources.GetString("label2.Text")
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label1.Location = New System.Drawing.Point(13, 6)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(241, 20)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Project management System - PMS"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 237)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
