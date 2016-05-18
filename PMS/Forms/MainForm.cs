using System;
using System.Linq;
using System.Windows.Forms;

namespace PMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "Admin" && PasswordTextBox.Text == "Password")
            {
                OperationsGroupBox.Enabled = true;
                CredentialGroupBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("The username/password is incorrect.", "Invalid Credentials", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            LoginButton.Enabled = !(UsernameTextBox.Text == string.Empty || PasswordTextBox.Text == string.Empty);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            var selectedOperation = OperationsGroupBox.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            switch (selectedOperation.Name)
            {
                case "ProjectRegistrationRadioButton":
                    new ProjectRegistration().Show();
                    break;

                case "ProgressUpdateRadioButton":
                    new UpdateProgress().Show();
                    break;

                case "GenerateTimesheetRadioButton":
                    new GenerateTimesheet().Show();
                    break;

                case "GenerateBillRadioButton":
                    new GenerateBill().Show();
                    break;
            }
        }

        private void AboutStatusStripLabel_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}