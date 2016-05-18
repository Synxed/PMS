Imports System.Data.OleDb

Public Partial Class UpdateProgress
    Private Sub UpdateProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb""")
                connection.Open()
                Using fetchProjectCommand As New OleDbCommand("SELECT * FROM Projects WHERE ProjectProgress <> 100", connection)
                    Using reader As Object = fetchProjectCommand.ExecuteReader()
                        While reader IsNot Nothing AndAlso reader.Read()
                            ProjectsComboBox.Items.Add(reader("ProjectName"))
                        End While
                    End Using
                End Using

                If CheckProjectAvailability() Then
                    ProjectsComboBox.SelectedIndex = 0
                    ProjectsComboBox_SelectedIndexChanged(sender, e)
                End If
            End Using
        Catch exception As Exception
            MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub ProgressTrackBar_Scroll(sender As Object, e As EventArgs) Handles ProgressTrackBar.Scroll
        ProgressLabel.Text = ProgressTrackBar.Value.ToString() + "%"
    End Sub

    Private Sub ProjectsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ProjectsComboBox.SelectedItem.ToString() = "No Unfinished Projects Avalaible" Then
            Return
        End If
        Try
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb""")
                connection.Open()
                Using fetchProjectCommand As New OleDbCommand("SELECT * FROM Projects WHERE ProjectName = @name", connection)
                    fetchProjectCommand.Parameters.AddWithValue("@name", ProjectsComboBox.SelectedItem.ToString())
                    Using reader As Object = fetchProjectCommand.ExecuteReader()
                        While reader IsNot Nothing AndAlso reader.Read()
                            ProgressTrackBar.Value = Integer.Parse(reader("ProjectProgress").ToString())
                            ProgressLabel.Text = ProgressTrackBar.Value.ToString() + "%"
                        End While
                    End Using
                End Using
            End Using
        Catch exception As Exception
            MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb""")
                connection.Open()
                Using updateCommand As New OleDbCommand("UPDATE Projects Set ProjectProgress = @progress WHERE ProjectName = @name", connection)
                    updateCommand.Parameters.AddWithValue("@progress", ProgressTrackBar.Value)
                    updateCommand.Parameters.AddWithValue("@name", ProjectsComboBox.SelectedItem.ToString())

                    updateCommand.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Progress has been updated successfully.", "Progress Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exception As Exception
            MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Private Sub AllocateButton_Click(sender As Object, e As EventArgs) Handles AllocateButton.Click
        Try
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb""")
                Dim currentAssignedResource As Object = 0
                connection.Open()
                Using command As New OleDbCommand("Select * FROM Projects WHERE ProjectName = @name", connection)
                    command.Parameters.AddWithValue("@name", ProjectsComboBox.SelectedItem.ToString())
                    Using reader As Object = command.ExecuteReader()
                        While reader IsNot Nothing AndAlso reader.Read()
                            currentAssignedResource = CType(reader("ResourceAssigned"), Integer)
                        End While
                    End Using
                End Using

                Using updateCommand As New OleDbCommand("UPDATE Projects SET ResourceAssigned = @resource WHERE ProjectName = @name", connection)
                    updateCommand.Parameters.AddWithValue("@resource", currentAssignedResource + CType(ResourceNumericBox.Value, Integer))
                    updateCommand.Parameters.AddWithValue("@name", ProjectsComboBox.SelectedItem.ToString())

                    updateCommand.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("New resources have been assigned successfully.", "Resource Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exception As Exception
            MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    ''' <summary>
    '''     Checks if any unfinished projects, i.e., items is avalaible in the ProjectsComboBox
    ''' </summary>
    ''' <returns>true or flase based on item availability</returns>
    Private Function CheckProjectAvailability() As Boolean
        If ProjectsComboBox.Items.Count <> 0 Then
            Return True
        End If

        ProjectsComboBox.Items.Add("No Unfinished Projects Avalaible")
        ProjectsComboBox.SelectedIndex = 0
        UpdateProgressGroupBox.Enabled = False
        ResourceAllocationGroupBox.Enabled = False
        Return False
    End Function
End Class