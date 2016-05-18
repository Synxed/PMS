namespace PMS
{
    partial class UpdateProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProgress));
            this.UpdateProgressGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.ProgressTrackBar = new System.Windows.Forms.TrackBar();
            this.ProjectsComboBox = new System.Windows.Forms.ComboBox();
            this.ResourceAllocationGroupBox = new System.Windows.Forms.GroupBox();
            this.AllocateButton = new System.Windows.Forms.Button();
            this.ResourceNumericBox = new System.Windows.Forms.NumericUpDown();
            this.UpdateProgressGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressTrackBar)).BeginInit();
            this.ResourceAllocationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateProgressGroupBox
            // 
            this.UpdateProgressGroupBox.Controls.Add(this.UpdateButton);
            this.UpdateProgressGroupBox.Controls.Add(this.ProgressLabel);
            this.UpdateProgressGroupBox.Controls.Add(this.ProgressTrackBar);
            this.UpdateProgressGroupBox.Controls.Add(this.ProjectsComboBox);
            this.UpdateProgressGroupBox.Location = new System.Drawing.Point(13, 13);
            this.UpdateProgressGroupBox.Name = "UpdateProgressGroupBox";
            this.UpdateProgressGroupBox.Size = new System.Drawing.Size(259, 130);
            this.UpdateProgressGroupBox.TabIndex = 0;
            this.UpdateProgressGroupBox.TabStop = false;
            this.UpdateProgressGroupBox.Text = "Update Progress";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.Location = new System.Drawing.Point(6, 99);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(219, 80);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(22, 13);
            this.ProgressLabel.TabIndex = 6;
            this.ProgressLabel.Text = "0%";
            // 
            // ProgressTrackBar
            // 
            this.ProgressTrackBar.Location = new System.Drawing.Point(5, 48);
            this.ProgressTrackBar.Maximum = 100;
            this.ProgressTrackBar.Name = "ProgressTrackBar";
            this.ProgressTrackBar.Size = new System.Drawing.Size(208, 45);
            this.ProgressTrackBar.TabIndex = 5;
            this.ProgressTrackBar.TabStop = false;
            this.ProgressTrackBar.Scroll += new System.EventHandler(this.ProgressTrackBar_Scroll);
            // 
            // ProjectsComboBox
            // 
            this.ProjectsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectsComboBox.FormattingEnabled = true;
            this.ProjectsComboBox.Location = new System.Drawing.Point(5, 21);
            this.ProjectsComboBox.Name = "ProjectsComboBox";
            this.ProjectsComboBox.Size = new System.Drawing.Size(248, 21);
            this.ProjectsComboBox.TabIndex = 4;
            this.ProjectsComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectsComboBox_SelectedIndexChanged);
            // 
            // ResourceAllocationGroupBox
            // 
            this.ResourceAllocationGroupBox.Controls.Add(this.AllocateButton);
            this.ResourceAllocationGroupBox.Controls.Add(this.ResourceNumericBox);
            this.ResourceAllocationGroupBox.Location = new System.Drawing.Point(12, 149);
            this.ResourceAllocationGroupBox.Name = "ResourceAllocationGroupBox";
            this.ResourceAllocationGroupBox.Size = new System.Drawing.Size(260, 55);
            this.ResourceAllocationGroupBox.TabIndex = 1;
            this.ResourceAllocationGroupBox.TabStop = false;
            this.ResourceAllocationGroupBox.Text = "Allocate More Resource";
            // 
            // AllocateButton
            // 
            this.AllocateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllocateButton.Location = new System.Drawing.Point(179, 18);
            this.AllocateButton.Name = "AllocateButton";
            this.AllocateButton.Size = new System.Drawing.Size(75, 23);
            this.AllocateButton.TabIndex = 8;
            this.AllocateButton.Text = "Allocate";
            this.AllocateButton.UseVisualStyleBackColor = true;
            this.AllocateButton.Click += new System.EventHandler(this.AllocateButton_Click);
            // 
            // ResourceNumericBox
            // 
            this.ResourceNumericBox.Location = new System.Drawing.Point(6, 21);
            this.ResourceNumericBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.ResourceNumericBox.Name = "ResourceNumericBox";
            this.ResourceNumericBox.Size = new System.Drawing.Size(167, 22);
            this.ResourceNumericBox.TabIndex = 0;
            // 
            // UpdateProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.ResourceAllocationGroupBox);
            this.Controls.Add(this.UpdateProgressGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateProgress";
            this.Text = "Update Progress";
            this.Load += new System.EventHandler(this.UpdateProgress_Load);
            this.UpdateProgressGroupBox.ResumeLayout(false);
            this.UpdateProgressGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressTrackBar)).EndInit();
            this.ResourceAllocationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResourceNumericBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UpdateProgressGroupBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.TrackBar ProgressTrackBar;
        private System.Windows.Forms.ComboBox ProjectsComboBox;
        private System.Windows.Forms.GroupBox ResourceAllocationGroupBox;
        private System.Windows.Forms.Button AllocateButton;
        private System.Windows.Forms.NumericUpDown ResourceNumericBox;
    }
}