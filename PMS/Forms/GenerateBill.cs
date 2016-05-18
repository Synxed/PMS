using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PMS
{
    public partial class GenerateBill : Form
    {
        private readonly StringBuilder _billWriter = new StringBuilder();

        public GenerateBill()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            _billWriter.Clear();

            _billWriter.AppendLine("PMS - Client Bill");
            _billWriter.AppendLine(new string('=', "PMS - Client Bill".Length) + Environment.NewLine);

            _billWriter.AppendLine("Client Name: " + ClientNameTextBox.Text);
            _billWriter.AppendLine("Client Address: " + ClientAddressTextBox.Text);
            _billWriter.AppendLine("Issued On: " + IssuedOnDateTimePicker.Value.Date.ToString("d") + Environment.NewLine);

            _billWriter.AppendLine("Details:");
            _billWriter.AppendLine(new string('-', "Details:".Length) + Environment.NewLine);
            _billWriter.AppendLine(BillDetailsTextBox.Text + Environment.NewLine);

            _billWriter.AppendLine("Total Amount: " + AmountNumericBox.Value.ToString("C"));

            GeneratedBillTextBox.Text = _billWriter.ToString();
        }

        private void GeneratedBillTextBox_DoubleClick(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text File (*.txt)|*.txt";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, _billWriter.ToString());
                    MessageBox.Show("Client Bill successfully exported to " + saveFileDialog.FileName,
                        "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in BillDetailsGroupBox.Controls)
            {
                if (control.GetType() == typeof (TextBox))
                {
                    ((TextBox) control).Clear();
                }
                else if (control.GetType() == typeof (NumericUpDown))
                {
                    ((NumericUpDown) control).Value = ((NumericUpDown) control).Minimum;
                }
                else if (control.GetType() == typeof (RichTextBox))
                {
                    ((RichTextBox) control).Clear();
                }
            }

            GeneratedBillTextBox.Clear();
        }

        private void GenerateBill_Load(object sender, EventArgs e)
        {
            IssuedOnDateTimePicker.Value = DateTime.Today;
        }
    }
}