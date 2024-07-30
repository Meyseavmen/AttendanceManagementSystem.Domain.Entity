namespace AttendanceManagementSystem.Presentation
{
    partial class LoginForm
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
            label2 = new Label();
            label3 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 104);
            label1.Name = "label1";
            label1.Size = new Size(236, 54);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(91, 190);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 1;
            label2.Text = "Username: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(102, 246);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 14F);
            usernameTextBox.Location = new Point(230, 183);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(411, 39);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14F);
            passwordTextBox.Location = new Point(230, 240);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(411, 39);
            passwordTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 14F);
            loginButton.Location = new Point(385, 313);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 42);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
    }
}