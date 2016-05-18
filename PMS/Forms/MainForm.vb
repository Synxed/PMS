Public Partial Class MainForm
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameTextBox.Text = "Admin" AndAlso PasswordTextBox.Text = "Password" Then
            OperationsGroupBox.Enabled = True
            CredentialGroupBox.Enabled = False
        Else
            MessageBox.Show("The username/password is incorrect.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged, PasswordTextBox.TextChanged
        LoginButton.Enabled = Not (UsernameTextBox.Text = String.Empty OrElse PasswordTextBox.Text = String.Empty)
    End Sub

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        Dim selectedOperation As Object = OperationsGroupBox.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked)
        Select Case selectedOperation.Name
            Case "ProjectRegistrationRadioButton"
                ProjectRegistration.Show()
                Exit Select

            Case "ProgressUpdateRadioButton"
                UpdateProgress.Show()
                Exit Select

            Case "GenerateTimesheetRadioButton"
                GenerateTimesheet.Show()
                Exit Select

            Case "GenerateBillRadioButton"
                GenerateBill.Show()
                Exit Select
        End Select
    End Sub

    Private Sub AboutStatusStripLabel_Click(sender As Object, e As EventArgs) Handles AboutStatusStripLabel.Click
        About.Show()
    End Sub
End Class