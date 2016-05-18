namespace PMS
{
    partial class ProjectRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientDetailsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SkillsetTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ResourceNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.DurationNumericBox = new System.Windows.Forms.NumericUpDown();
            this.BudgetNumericBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name:";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Location = new System.Drawing.Point(95, 12);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(177, 22);
            this.ProjectNameTextBox.TabIndex = 0;
            // 
            // ClientDetailsTextBox
            // 
            this.ClientDetailsTextBox.Location = new System.Drawing.Point(95, 40);
            this.ClientDetailsTextBox.Name = "ClientDetailsTextBox";
            this.ClientDetailsTextBox.Size = new System.Drawing.Size(177, 22);
            this.ClientDetailsTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Budget:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duration:";
            // 
            // SkillsetTextbox
            // 
            this.SkillsetTextbox.Location = new System.Drawing.Point(95, 124);
            this.SkillsetTextbox.Name = "SkillsetTextbox";
            this.SkillsetTextbox.Size = new System.Drawing.Size(177, 22);
            this.SkillsetTextbox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Skillset:";
            // 
            // ResourceNumericBox
            // 
            this.ResourceNumericBox.Location = new System.Drawing.Point(95, 152);
            this.ResourceNumericBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ResourceNumericBox.Name = "ResourceNumericBox";
            this.ResourceNumericBox.Size = new System.Drawing.Size(177, 22);
            this.ResourceNumericBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Resource:";
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Location = new System.Drawing.Point(197, 180);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Location = new System.Drawing.Point(12, 180);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 14;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // DurationNumericBox
            // 
            this.DurationNumericBox.Location = new System.Drawing.Point(95, 96);
            this.DurationNumericBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.DurationNumericBox.Name = "DurationNumericBox";
            this.DurationNumericBox.Size = new System.Drawing.Size(177, 22);
            this.DurationNumericBox.TabIndex = 3;
            // 
            // BudgetNumericBox
            // 
            this.BudgetNumericBox.Location = new System.Drawing.Point(95, 68);
            this.BudgetNumericBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.BudgetNumericBox.Name = "BudgetNumericBox";
            this.BudgetNumericBox.Size = new System.Drawing.Size(177, 22);
            this.BudgetNumericBox.TabIndex = 2;
            // 
            // ProjectRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.BudgetNumericBox);
            this.Controls.Add(this.DurationNumericBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResourceNumericBox);
            this.Controls.Add(this.SkillsetTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientDetailsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectRegistration";
            this.Text = "Project Registration";
            ((System.ComponentModel.ISupportInitialize)(this.ResourceNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.TextBox ClientDetailsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SkillsetTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ResourceNumericBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.NumericUpDown DurationNumericBox;
        private System.Windows.Forms.NumericUpDown BudgetNumericBox;
    }
}