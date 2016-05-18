Imports System.IO
Imports System.Text

Public Partial Class GenerateBill
    Private ReadOnly _billWriter As New StringBuilder()

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        _billWriter.Clear()

        _billWriter.AppendLine("PMS - Client Bill")
        _billWriter.AppendLine(New String("="C, "PMS - Client Bill".Length) + Environment.NewLine)

        _billWriter.AppendLine("Client Name: " + ClientNameTextBox.Text)
        _billWriter.AppendLine("Client Address: " + ClientAddressTextBox.Text)
        _billWriter.AppendLine("Issued On: " + IssuedOnDateTimePicker.Value.[Date].ToString("d") + Environment.NewLine)

        _billWriter.AppendLine("Details:")
        _billWriter.AppendLine(New String("-"C, "Details:".Length) + Environment.NewLine)
        _billWriter.AppendLine(BillDetailsTextBox.Text + Environment.NewLine)

        _billWriter.AppendLine("Total Amount: " + AmountNumericBox.Value.ToString("C"))

        GeneratedBillTextBox.Text = _billWriter.ToString()
    End Sub

    Private Sub GeneratedBillTextBox_DoubleClick(sender As Object, e As EventArgs) Handles GeneratedBillTextBox.DoubleClick
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Text File (*.txt)|*.txt"
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                File.WriteAllText(saveFileDialog.FileName, _billWriter.ToString())
                MessageBox.Show("Client Bill successfully exported to " + saveFileDialog.FileName, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        For Each control As Control In BillDetailsGroupBox.Controls
            If control.[GetType]() = GetType(TextBox) Then
                CType(control, TextBox).Clear()
            ElseIf control.[GetType]() = GetType(NumericUpDown) Then
                CType(control, NumericUpDown).Value = (CType(control, NumericUpDown)).Minimum
            ElseIf control.[GetType]() = GetType(RichTextBox) Then
                CType(control, RichTextBox).Clear()
            End If
        Next

        GeneratedBillTextBox.Clear()
    End Sub

    Private Sub GenerateBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IssuedOnDateTimePicker.Value = DateTime.Today
    End Sub
End Class