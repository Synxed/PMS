using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PMS
{
    public partial class UpdateProgress : Form
    {
        public UpdateProgress()
        {
            InitializeComponent();
        }

        private void UpdateProgress_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\""))
                {
                    connection.Open();
                    using (
                        var fetchProjectCommand = new OleDbCommand(
                            "SELECT * FROM Projects WHERE ProjectProgress <> 100", connection))
                    using (var reader = fetchProjectCommand.ExecuteReader())
                    {
                        while (reader != null && reader.Read())
                            ProjectsComboBox.Items.Add(reader["ProjectName"]);
                    }

                    if (CheckProjectAvailability())
                    {
                        ProjectsComboBox.SelectedIndex = 0;
                        ProjectsComboBox_SelectedIndexChanged(sender, e);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProgressTrackBar_Scroll(object sender, EventArgs e)
        {
            ProgressLabel.Text = ProgressTrackBar.Value + "%";
        }

        private void ProjectsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectsComboBox.SelectedItem.ToString() == "No Unfinished Projects Avalaible") return;
            try
            {
                using (
                    var connection =
                        new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\""))
                {
                    connection.Open();
                    using (
                        var fetchProjectCommand = new OleDbCommand("SELECT * FROM Projects WHERE ProjectName = @name",
                            connection))
                    {
                        fetchProjectCommand.Parameters.AddWithValue("@name", ProjectsComboBox.SelectedItem.ToString());
                        using (var reader = fetchProjectCommand.ExecuteReader())
                        {
                            while (reader != null && reader.Read())
                            {
                                ProgressTrackBar.Value = int.Parse(reader["ProjectProgress"].ToString());
                                ProgressLabel.Text = ProgressTrackBar.Value + "%";
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (
                    var connection =
                        new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\""))
                {
                    connection.Open();
                    using (
                        var updateCommand =
                            new OleDbCommand(
                                "UPDATE Projects Set ProjectProgress = @progress WHERE ProjectName = @name", connection)
                        )
                    {
                        updateCommand.Parameters.AddWithValue("@progress", ProgressTrackBar.Value);
                        updateCommand.Parameters.AddWithValue("@name", ProjectsComboBox.SelectedItem.ToString());

                        updateCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Progress has been updated successfully.", "Progress Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AllocateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection =new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\""))
                {
                    var currentAssignedResource = 0;
                    connection.Open();
                    using (
                        var command = new OleDbCommand("Select * FROM Projects WHERE ProjectName = @name", connection))
                    {
                        command.Parameters.AddWithValue("@name", ProjectsComboBox.SelectedItem.ToString());
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader != null && reader.Read())
                                currentAssignedResource = (int) reader["ResourceAssigned"];
                        }
                    }

                    using (var updateCommand =new OleDbCommand("UPDATE Projects SET ResourceAssigned = @resource WHERE ProjectName = @name", connection))
                    {
                        updateCommand.Parameters.AddWithValue("@resource",
                            currentAssignedResource + (int) ResourceNumericBox.Value);
                        updateCommand.Parameters.AddWithValue("@name", ProjectsComboBox.SelectedItem.ToString());

                        updateCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("New resources have been assigned successfully.", "Resource Assigned",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        ///     Checks if any unfinished projects, i.e., items is avalaible in the ProjectsComboBox
        /// </summary>
        /// <returns>true or flase based on item availability</returns>
        private bool CheckProjectAvailability()
        {
            if (ProjectsComboBox.Items.Count != 0) return true;

            ProjectsComboBox.Items.Add("No Unfinished Projects Avalaible");
            ProjectsComboBox.SelectedIndex = 0;
            UpdateProgressGroupBox.Enabled = false;
            ResourceAllocationGroupBox.Enabled = false;
            return false;
        }
    }
}