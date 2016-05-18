using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PMS
{
    public partial class ProjectRegistration : Form
    {
        public ProjectRegistration()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (
                    var connection =
                        new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\""))
                {
                    connection.Open();
                    var command =
                        "INSERT INTO Projects (ProjectName, ClientDetails, ProjectBudget, ProjectDuration, ScheduledDate, RequiredSkillset, ResourceAssigned, ProjectProgress)" +
                        "Values (@ProjectName, @ClientDetails, @ProjectBudget, @ProjectDuration, @ScheduledDate, @RequiredSkillset, @ResourceAssigned, @ProjectProgress)";

                    using (var addQueryCommand = new OleDbCommand(command, connection))
                    {
                        addQueryCommand.Parameters.AddWithValue("@ProjectName", ProjectNameTextBox.Text);
                        addQueryCommand.Parameters.AddWithValue("@ClientDetails", ClientDetailsTextBox.Text);
                        addQueryCommand.Parameters.AddWithValue("@ProjectBudget", BudgetNumericBox.Value);
                        addQueryCommand.Parameters.AddWithValue("@ProjectDuration", DurationNumericBox.Value);
                        addQueryCommand.Parameters.AddWithValue("@ScheduledDate", DateTime.Today.ToString("d"));
                        addQueryCommand.Parameters.AddWithValue("@RequiredSkillset", SkillsetTextbox.Text);
                        addQueryCommand.Parameters.AddWithValue("@ResourceAssigned", ResourceNumericBox.Value);
                        addQueryCommand.Parameters.AddWithValue("@ProjectProgress", 0);

                        addQueryCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("The project has been successfully registered.", "Registration Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception exception)
            {
                MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof (TextBox))
                {
                    ((TextBox) control).Clear();
                }
                else if (control.GetType() == typeof (NumericUpDown))
                {
                    ((NumericUpDown) control).Value = ((NumericUpDown) control).Minimum;
                }
            }
        }
    }
}