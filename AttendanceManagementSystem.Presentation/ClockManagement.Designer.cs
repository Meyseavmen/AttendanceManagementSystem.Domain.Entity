namespace AttendanceManagementSystem.Presentation
{
    partial class ClockManagement
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            currentTimeLabel = new Label();
            label2 = new Label();
            cardnoTextBox = new TextBox();
            clockinButton = new Button();
            clockoutButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 18);
            label1.Name = "label1";
            label1.Size = new Size(176, 41);
            label1.TabIndex = 0;
            label1.Text = "Clock Form";
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentTimeLabel.Location = new Point(289, 79);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(88, 41);
            currentTimeLabel.TabIndex = 1;
            currentTimeLabel.Text = "Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 145);
            label2.Name = "label2";
            label2.Size = new Size(133, 38);
            label2.TabIndex = 2;
            label2.Text = "Card No: ";
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardnoTextBox.Location = new Point(241, 140);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(317, 43);
            cardnoTextBox.TabIndex = 3;
            // 
            // clockinButton
            // 
            clockinButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clockinButton.Location = new Point(200, 236);
            clockinButton.Name = "clockinButton";
            clockinButton.Size = new Size(135, 45);
            clockinButton.TabIndex = 4;
            clockinButton.Text = "Time-in";
            clockinButton.UseVisualStyleBackColor = true;
            clockinButton.Click += clockinButton_Click;
            // 
            // clockoutButton
            // 
            clockoutButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clockoutButton.Location = new Point(411, 236);
            clockoutButton.Name = "clockoutButton";
            clockoutButton.Size = new Size(147, 45);
            clockoutButton.TabIndex = 5;
            clockoutButton.Text = "Time-out";
            clockoutButton.UseVisualStyleBackColor = true;
            clockoutButton.Click += clockoutButton_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            // 
            // ClockManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clockoutButton);
            Controls.Add(clockinButton);
            Controls.Add(cardnoTextBox);
            Controls.Add(label2);
            Controls.Add(currentTimeLabel);
            Controls.Add(label1);
            Name = "ClockManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClockManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label currentTimeLabel;
        private Label label2;
        private TextBox cardnoTextBox;
        private Button clockinButton;
        private Button clockoutButton;
        private System.Windows.Forms.Timer timer;
    }
}