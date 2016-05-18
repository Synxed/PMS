namespace PMS
{
    partial class GenerateBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateBill));
            this.BillDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.IssuedOnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BillDetailsTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.AmountNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.GeneratedBillTextBox = new System.Windows.Forms.RichTextBox();
            this.BillDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BillDetailsGroupBox
            // 
            this.BillDetailsGroupBox.Controls.Add(this.IssuedOnDateTimePicker);
            this.BillDetailsGroupBox.Controls.Add(this.label3);
            this.BillDetailsGroupBox.Controls.Add(this.ResetButton);
            this.BillDetailsGroupBox.Controls.Add(this.BillDetailsTextBox);
            this.BillDetailsGroupBox.Controls.Add(this.GenerateButton);
            this.BillDetailsGroupBox.Controls.Add(this.AmountNumericBox);
            this.BillDetailsGroupBox.Controls.Add(this.label4);
            this.BillDetailsGroupBox.Controls.Add(this.label2);
            this.BillDetailsGroupBox.Controls.Add(this.ClientAddressTextBox);
            this.BillDetailsGroupBox.Controls.Add(this.label1);
            this.BillDetailsGroupBox.Controls.Add(this.ClientNameTextBox);
            this.BillDetailsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.BillDetailsGroupBox.Name = "BillDetailsGroupBox";
            this.BillDetailsGroupBox.Size = new System.Drawing.Size(541, 241);
            this.BillDetailsGroupBox.TabIndex = 0;
            this.BillDetailsGroupBox.TabStop = false;
            this.BillDetailsGroupBox.Text = "Bill Details";
            // 
            // IssuedOnDateTimePicker
            // 
            this.IssuedOnDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IssuedOnDateTimePicker.CustomFormat = "";
            this.IssuedOnDateTimePicker.Location = new System.Drawing.Point(327, 49);
            this.IssuedOnDateTimePicker.MinDate = new System.DateTime(2016, 5, 17, 0, 0, 0, 0);
            this.IssuedOnDateTimePicker.Name = "IssuedOnDateTimePicker";
            this.IssuedOnDateTimePicker.Size = new System.Drawing.Size(206, 22);
            this.IssuedOnDateTimePicker.TabIndex = 3;
            this.IssuedOnDateTimePicker.Value = new System.DateTime(2016, 5, 17, 23, 30, 37, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Issued On:";
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Location = new System.Drawing.Point(458, 209);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BillDetailsTextBox
            // 
            this.BillDetailsTextBox.AcceptsTab = true;
            this.BillDetailsTextBox.Location = new System.Drawing.Point(6, 81);
            this.BillDetailsTextBox.Name = "BillDetailsTextBox";
            this.BillDetailsTextBox.Size = new System.Drawing.Size(527, 122);
            this.BillDetailsTextBox.TabIndex = 4;
            this.BillDetailsTextBox.Text = "Bill Details";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateButton.Location = new System.Drawing.Point(6, 209);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // AmountNumericBox
            // 
            this.AmountNumericBox.Location = new System.Drawing.Point(84, 49);
            this.AmountNumericBox.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.AmountNumericBox.Name = "AmountNumericBox";
            this.AmountNumericBox.Size = new System.Drawing.Size(147, 22);
            this.AmountNumericBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client Address:";
            // 
            // ClientAddressTextBox
            // 
            this.ClientAddressTextBox.Location = new System.Drawing.Point(327, 21);
            this.ClientAddressTextBox.Name = "ClientAddressTextBox";
            this.ClientAddressTextBox.Size = new System.Drawing.Size(206, 22);
            this.ClientAddressTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Name:";
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(84, 21);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(147, 22);
            this.ClientNameTextBox.TabIndex = 0;
            // 
            // GeneratedBillTextBox
            // 
            this.GeneratedBillTextBox.Location = new System.Drawing.Point(13, 260);
            this.GeneratedBillTextBox.Name = "GeneratedBillTextBox";
            this.GeneratedBillTextBox.ReadOnly = true;
            this.GeneratedBillTextBox.Size = new System.Drawing.Size(541, 233);
            this.GeneratedBillTextBox.TabIndex = 1;
            this.GeneratedBillTextBox.TabStop = false;
            this.GeneratedBillTextBox.Text = "";
            this.GeneratedBillTextBox.DoubleClick += new System.EventHandler(this.GeneratedBillTextBox_DoubleClick);
            // 
            // GenerateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 505);
            this.Controls.Add(this.GeneratedBillTextBox);
            this.Controls.Add(this.BillDetailsGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GenerateBill";
            this.Text = "Generate Bill";
            this.Load += new System.EventHandler(this.GenerateBill_Load);
            this.BillDetailsGroupBox.ResumeLayout(false);
            this.BillDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BillDetailsGroupBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.NumericUpDown AmountNumericBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.RichTextBox BillDetailsTextBox;
        private System.Windows.Forms.RichTextBox GeneratedBillTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.DateTimePicker IssuedOnDateTimePicker;
        private System.Windows.Forms.Label label3;
    }
}