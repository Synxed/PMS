namespace PMS
{
    partial class GenerateTimesheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateTimesheet));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.ProjectTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TimesheetDataGridView = new System.Windows.Forms.DataGridView();
            this.DayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkHoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraHoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(57, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(163, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(57, 40);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(163, 22);
            this.IDTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Project:";
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Location = new System.Drawing.Point(303, 12);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(163, 22);
            this.DepartmentTextBox.TabIndex = 9;
            // 
            // ProjectTextBox
            // 
            this.ProjectTextBox.Location = new System.Drawing.Point(303, 40);
            this.ProjectTextBox.Name = "ProjectTextBox";
            this.ProjectTextBox.Size = new System.Drawing.Size(163, 22);
            this.ProjectTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Department:";
            // 
            // TimesheetDataGridView
            // 
            this.TimesheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimesheetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DayColumn,
            this.WorkHoursColumn,
            this.ExtraHoursColumn,
            this.FeesColumn});
            this.TimesheetDataGridView.Location = new System.Drawing.Point(12, 68);
            this.TimesheetDataGridView.Name = "TimesheetDataGridView";
            this.TimesheetDataGridView.Size = new System.Drawing.Size(453, 182);
            this.TimesheetDataGridView.TabIndex = 12;
            // 
            // DayColumn
            // 
            this.DayColumn.HeaderText = "Day";
            this.DayColumn.Name = "DayColumn";
            // 
            // WorkHoursColumn
            // 
            this.WorkHoursColumn.HeaderText = "Work Hours";
            this.WorkHoursColumn.Name = "WorkHoursColumn";
            // 
            // ExtraHoursColumn
            // 
            this.ExtraHoursColumn.HeaderText = "Extra Hours";
            this.ExtraHoursColumn.Name = "ExtraHoursColumn";
            // 
            // FeesColumn
            // 
            this.FeesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FeesColumn.HeaderText = "Fees";
            this.FeesColumn.Name = "FeesColumn";
            // 
            // ExportButton
            // 
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.Location = new System.Drawing.Point(12, 256);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 13;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Location = new System.Drawing.Point(390, 256);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 14;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // GenerateTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 287);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.TimesheetDataGridView);
            this.Controls.Add(this.ProjectTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GenerateTimesheet";
            this.Text = "Generate Timesheet";
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.TextBox ProjectTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TimesheetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkHoursColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraHoursColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeesColumn;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ResetButton;
    }
}