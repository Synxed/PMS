Imports System.IO
Imports System.Text

Public Partial Class GenerateTimesheet
    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        Try
            Dim timesheetWriter As New StringBuilder()

            timesheetWriter.AppendLine("PMS - Employee Timesheet")
            timesheetWriter.AppendLine(New String("="C, "PMS - Employee Timesheet".Length) + Environment.NewLine)

            timesheetWriter.AppendLine("Employee Name: " + NameTextBox.Text)
            timesheetWriter.AppendLine("Employee ID: " + IDTextBox.Text)
            timesheetWriter.AppendLine("Department: " + DepartmentTextBox.Text)
            timesheetWriter.AppendLine("Working On: " + ProjectTextBox.Text + Environment.NewLine)

            For Each row As DataGridViewRow In TimesheetDataGridView.Rows
                If row.IsNewRow Then
                    Exit For
                End If

                Dim totalWorkingHours As Object = Integer.Parse(row.Cells("WorkHoursColumn").Value.ToString()) + Integer.Parse(row.Cells("ExtraHoursColumn").Value.ToString())

                timesheetWriter.Append(row.Cells("DayColumn").Value + ": ")
                timesheetWriter.Append(String.Format("{0} Hours ({1} Extra) ", totalWorkingHours, row.Cells("ExtraHoursColumn").Value))

                timesheetWriter.AppendLine(row.Cells("FeesColumn").Value.ToString())
            Next

            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Text File (*.txt)|*.txt"
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    File.WriteAllText(saveFileDialog.FileName, timesheetWriter.ToString())
                    MessageBox.Show("Timesheet successfully exported to " + saveFileDialog.FileName, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch exception As Exception
            MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        For Each control As Control In Controls
            If control.[GetType]() = GetType(TextBox) Then
                CType(control, TextBox).Clear()
            ElseIf control.[GetType]() = GetType(DataGridView) Then
                CType(control, DataGridView).Rows.Clear()
            End If
        Next
    End Sub
End Class