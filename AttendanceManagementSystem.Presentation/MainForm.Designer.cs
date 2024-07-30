namespace AttendanceManagementSystem.Presentation
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
            label1 = new Label();
            timeRecordButton = new Button();
            managementEmployeeButton = new Button();
            LoginLinkLable = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 46);
            label1.Name = "label1";
            label1.Size = new Size(587, 50);
            label1.TabIndex = 0;
            label1.Text = "Employee Timesheet Management";
            // 
            // timeRecordButton
            // 
            timeRecordButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeRecordButton.Location = new Point(363, 129);
            timeRecordButton.Name = "timeRecordButton";
            timeRecordButton.Size = new Size(212, 47);
            timeRecordButton.TabIndex = 1;
            timeRecordButton.Text = "Time Record";
            timeRecordButton.UseVisualStyleBackColor = true;
            timeRecordButton.Click += timeRecordButton_Click;
            // 
            // managementEmployeeButton
            // 
            managementEmployeeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            managementEmployeeButton.Location = new Point(331, 217);
            managementEmployeeButton.Name = "managementEmployeeButton";
            managementEmployeeButton.Size = new Size(271, 49);
            managementEmployeeButton.TabIndex = 2;
            managementEmployeeButton.Text = "Manage Employee";
            managementEmployeeButton.UseVisualStyleBackColor = true;
            managementEmployeeButton.Click += managementEmployeeButton_Click;
            // 
            // LoginLinkLable
            // 
            LoginLinkLable.AutoSize = true;
            LoginLinkLable.Location = new Point(21, 25);
            LoginLinkLable.Name = "LoginLinkLable";
            LoginLinkLable.Size = new Size(46, 20);
            LoginLinkLable.TabIndex = 3;
            LoginLinkLable.TabStop = true;
            LoginLinkLable.Text = "Login";
            LoginLinkLable.LinkClicked += LoginLinkLable_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 356);
            Controls.Add(LoginLinkLable);
            Controls.Add(managementEmployeeButton);
            Controls.Add(timeRecordButton);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button timeRecordButton;
        private Button managementEmployeeButton;
        private LinkLabel LoginLinkLable;
    }
}