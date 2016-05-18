using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PMS
{
    public partial class GenerateTimesheet : Form
    {
        public GenerateTimesheet()
        {
            InitializeComponent();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                var timesheetWriter = new StringBuilder();

                timesheetWriter.AppendLine("PMS - Employee Timesheet");
                timesheetWriter.AppendLine(new string('=', "PMS - Employee Timesheet".Length) + Environment.NewLine);

                timesheetWriter.AppendLine("Employee Name: " + NameTextBox.Text);
                timesheetWriter.AppendLine("Employee ID: " + IDTextBox.Text);
                timesheetWriter.AppendLine("Department: " + DepartmentTextBox.Text);
                timesheetWriter.AppendLine("Working On: " + ProjectTextBox.Text + Environment.NewLine);

                foreach (DataGridViewRow row in TimesheetDataGridView.Rows)
                {
                    if (row.IsNewRow) break;

                    var totalWorkingHours = int.Parse(row.Cells["WorkHoursColumn"].Value.ToString()) +
                                            int.Parse(row.Cells["ExtraHoursColumn"].Value.ToString());

                    timesheetWriter.Append(row.Cells["DayColumn"].Value + ": ");
                    timesheetWriter.Append(string.Format("{0} Hours ({1} Extra) ", totalWorkingHours,
                        row.Cells["ExtraHoursColumn"].Value));

                    timesheetWriter.AppendLine(row.Cells["FeesColumn"].Value.ToString());
                }

                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text File (*.txt)|*.txt";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, timesheetWriter.ToString());
                        MessageBox.Show("Timesheet successfully exported to " + saveFileDialog.FileName,
                            "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
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
                else if (control.GetType() == typeof (DataGridView))
                {
                    ((DataGridView) control).Rows.Clear();
                }
            }
        }
    }
}