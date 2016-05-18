Imports System.Data.OleDb

Public Partial Class ProjectRegistration
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Try
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb""")
                connection.Open()
                Dim command As Object = "INSERT INTO Projects (ProjectName, ClientDetails, ProjectBudget, ProjectDuration, ScheduledDate, RequiredSkillset, ResourceAssigned, ProjectProgress)" + "Values (@ProjectName, @ClientDetails, @ProjectBudget, @ProjectDuration, @ScheduledDate, @RequiredSkillset, @ResourceAssigned, @ProjectProgress)"

                Using addQueryCommand As New OleDbCommand(command, connection)
                    addQueryCommand.Parameters.AddWithValue("@ProjectName", ProjectNameTextBox.Text)
                    addQueryCommand.Parameters.AddWithValue("@ClientDetails", ClientDetailsTextBox.Text)
                    addQueryCommand.Parameters.AddWithValue("@ProjectBudget", BudgetNumericBox.Value)
                    addQueryCommand.Parameters.AddWithValue("@ProjectDuration", DurationNumericBox.Value)
                    addQueryCommand.Parameters.AddWithValue("@ScheduledDate", DateTime.Today.ToString("d"))
                    addQueryCommand.Parameters.AddWithValue("@RequiredSkillset", SkillsetTextbox.Text)
                    addQueryCommand.Parameters.AddWithValue("@ResourceAssigned", ResourceNumericBox.Value)
                    addQueryCommand.Parameters.AddWithValue("@ProjectProgress", 0)

                    addQueryCommand.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("The project has been successfully registered.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch exception As Exception
            MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        For Each control As Control In Controls
            If control.[GetType]() = GetType(TextBox) Then
                CType(control, TextBox).Clear()
            ElseIf control.[GetType]() = GetType(NumericUpDown) Then
                CType(control, NumericUpDown).Value = (CType(control, NumericUpDown)).Minimum
            End If
        Next
    End Sub
End Class