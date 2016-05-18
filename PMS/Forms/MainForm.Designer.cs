namespace PMS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TSISStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AboutStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OperationsGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.GenerateTimesheetRadioButton = new System.Windows.Forms.RadioButton();
            this.GenerateBillRadioButton = new System.Windows.Forms.RadioButton();
            this.ProgressUpdateRadioButton = new System.Windows.Forms.RadioButton();
            this.ProjectRegistrationRadioButton = new System.Windows.Forms.RadioButton();
            this.CredentialGroupBox = new System.Windows.Forms.GroupBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.TSISStatusStrip.SuspendLayout();
            this.OperationsGroupBox.SuspendLayout();
            this.CredentialGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSISStatusStrip
            // 
            this.TSISStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.AboutStatusStripLabel});
            this.TSISStatusStrip.Location = new System.Drawing.Point(0, 274);
            this.TSISStatusStrip.Name = "TSISStatusStrip";
            this.TSISStatusStrip.Size = new System.Drawing.Size(284, 22);
            this.TSISStatusStrip.SizingGrip = false;
            this.TSISStatusStrip.TabIndex = 5;
            this.TSISStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(154, 17);
            this.toolStripStatusLabel1.Text = "CS492 VB Project (2014 - 18)";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // AboutStatusStripLabel
            // 
            this.AboutStatusStripLabel.IsLink = true;
            this.AboutStatusStripLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.AboutStatusStripLabel.LinkColor = System.Drawing.Color.Blue;
            this.AboutStatusStripLabel.Name = "AboutStatusStripLabel";
            this.AboutStatusStripLabel.Size = new System.Drawing.Size(40, 17);
            this.AboutStatusStripLabel.Text = "About";
            this.AboutStatusStripLabel.Click += new System.EventHandler(this.AboutStatusStripLabel_Click);
            // 
            // OperationsGroupBox
            // 
            this.OperationsGroupBox.Controls.Add(this.OpenButton);
            this.OperationsGroupBox.Controls.Add(this.GenerateTimesheetRadioButton);
            this.OperationsGroupBox.Controls.Add(this.GenerateBillRadioButton);
            this.OperationsGroupBox.Controls.Add(this.ProgressUpdateRadioButton);
            this.OperationsGroupBox.Controls.Add(this.ProjectRegistrationRadioButton);
            this.OperationsGroupBox.Enabled = false;
            this.OperationsGroupBox.Location = new System.Drawing.Point(12, 121);
            this.OperationsGroupBox.Name = "OperationsGroupBox";
            this.OperationsGroupBox.Size = new System.Drawing.Size(260, 146);
            this.OperationsGroupBox.TabIndex = 4;
            this.OperationsGroupBox.TabStop = false;
            this.OperationsGroupBox.Text = "Operations";
            // 
            // OpenButton
            // 
            this.OpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenButton.Location = new System.Drawing.Point(6, 113);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 5;
            this.OpenButton.Tag = "UserAccess";
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // GenerateTimesheetRadioButton
            // 
            this.GenerateTimesheetRadioButton.AutoSize = true;
            this.GenerateTimesheetRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateTimesheetRadioButton.Location = new System.Drawing.Point(6, 67);
            this.GenerateTimesheetRadioButton.Name = "GenerateTimesheetRadioButton";
            this.GenerateTimesheetRadioButton.Size = new System.Drawing.Size(126, 17);
            this.GenerateTimesheetRadioButton.TabIndex = 4;
            this.GenerateTimesheetRadioButton.Tag = "4";
            this.GenerateTimesheetRadioButton.Text = "Generate Timesheet";
            this.GenerateTimesheetRadioButton.UseVisualStyleBackColor = true;
            // 
            // GenerateBillRadioButton
            // 
            this.GenerateBillRadioButton.AutoSize = true;
            this.GenerateBillRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateBillRadioButton.Location = new System.Drawing.Point(6, 90);
            this.GenerateBillRadioButton.Name = "GenerateBillRadioButton";
            this.GenerateBillRadioButton.Size = new System.Drawing.Size(91, 17);
            this.GenerateBillRadioButton.TabIndex = 2;
            this.GenerateBillRadioButton.Tag = "3";
            this.GenerateBillRadioButton.Text = "Generate Bill";
            this.GenerateBillRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProgressUpdateRadioButton
            // 
            this.ProgressUpdateRadioButton.AutoSize = true;
            this.ProgressUpdateRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProgressUpdateRadioButton.Location = new System.Drawing.Point(6, 44);
            this.ProgressUpdateRadioButton.Name = "ProgressUpdateRadioButton";
            this.ProgressUpdateRadioButton.Size = new System.Drawing.Size(110, 17);
            this.ProgressUpdateRadioButton.TabIndex = 1;
            this.ProgressUpdateRadioButton.Tag = "2";
            this.ProgressUpdateRadioButton.Text = "Update Progress";
            this.ProgressUpdateRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProjectRegistrationRadioButton
            // 
            this.ProjectRegistrationRadioButton.AutoSize = true;
            this.ProjectRegistrationRadioButton.Checked = true;
            this.ProjectRegistrationRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectRegistrationRadioButton.Location = new System.Drawing.Point(6, 21);
            this.ProjectRegistrationRadioButton.Name = "ProjectRegistrationRadioButton";
            this.ProjectRegistrationRadioButton.Size = new System.Drawing.Size(126, 17);
            this.ProjectRegistrationRadioButton.TabIndex = 0;
            this.ProjectRegistrationRadioButton.TabStop = true;
            this.ProjectRegistrationRadioButton.Tag = "";
            this.ProjectRegistrationRadioButton.Text = "Project Registration";
            this.ProjectRegistrationRadioButton.UseVisualStyleBackColor = true;
            // 
            // CredentialGroupBox
            // 
            this.CredentialGroupBox.Controls.Add(this.LoginButton);
            this.CredentialGroupBox.Controls.Add(this.label2);
            this.CredentialGroupBox.Controls.Add(this.PasswordTextBox);
            this.CredentialGroupBox.Controls.Add(this.label1);
            this.CredentialGroupBox.Controls.Add(this.UsernameTextBox);
            this.CredentialGroupBox.Location = new System.Drawing.Point(13, 7);
            this.CredentialGroupBox.Name = "CredentialGroupBox";
            this.CredentialGroupBox.Size = new System.Drawing.Size(259, 108);
            this.CredentialGroupBox.TabIndex = 3;
            this.CredentialGroupBox.TabStop = false;
            this.CredentialGroupBox.Text = "Login";
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Location = new System.Drawing.Point(9, 77);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(73, 49);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(180, 22);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(73, 21);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(180, 22);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.Text = "Admin";
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.TSISStatusStrip);
            this.Controls.Add(this.OperationsGroupBox);
            this.Controls.Add(this.CredentialGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PMS";
            this.TSISStatusStrip.ResumeLayout(false);
            this.TSISStatusStrip.PerformLayout();
            this.OperationsGroupBox.ResumeLayout(false);
            this.OperationsGroupBox.PerformLayout();
            this.CredentialGroupBox.ResumeLayout(false);
            this.CredentialGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip TSISStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel AboutStatusStripLabel;
        private System.Windows.Forms.GroupBox OperationsGroupBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.RadioButton GenerateTimesheetRadioButton;
        private System.Windows.Forms.RadioButton GenerateBillRadioButton;
        private System.Windows.Forms.RadioButton ProgressUpdateRadioButton;
        private System.Windows.Forms.RadioButton ProjectRegistrationRadioButton;
        private System.Windows.Forms.GroupBox CredentialGroupBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameTextBox;
    }
}

