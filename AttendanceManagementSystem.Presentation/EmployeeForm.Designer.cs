namespace AttendanceManagementSystem.Presentation
{
    partial class EmployeeForm
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
            label4 = new Label();
            label5 = new Label();
            employeeIDTextBox = new TextBox();
            fullNameTextBox = new TextBox();
            positionTextBox = new TextBox();
            cardnoTextBox = new TextBox();
            addnewButton = new Button();
            saveButton = new Button();
            updateButton = new Button();
            dataGridView1 = new DataGridView();
            deleteButton = new Button();
            label6 = new Label();
            label7 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 41);
            label1.TabIndex = 0;
            label1.Text = "Employee Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 23);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "Employee ID: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 60);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Full Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 99);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Position:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 139);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 4;
            label5.Text = "Card No: ";
            // 
            // employeeIDTextBox
            // 
            employeeIDTextBox.Location = new Point(131, 16);
            employeeIDTextBox.Name = "employeeIDTextBox";
            employeeIDTextBox.ReadOnly = true;
            employeeIDTextBox.Size = new Size(230, 27);
            employeeIDTextBox.TabIndex = 5;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(131, 53);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(230, 27);
            fullNameTextBox.TabIndex = 6;
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(131, 92);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(230, 27);
            positionTextBox.TabIndex = 7;
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(131, 132);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(230, 27);
            cardnoTextBox.TabIndex = 8;
            // 
            // addnewButton
            // 
            addnewButton.Location = new Point(23, 396);
            addnewButton.Name = "addnewButton";
            addnewButton.Size = new Size(94, 29);
            addnewButton.TabIndex = 9;
            addnewButton.Text = "Add New";
            addnewButton.UseVisualStyleBackColor = true;
            addnewButton.Click += addnewButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(162, 396);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(296, 396);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(561, 300);
            dataGridView1.TabIndex = 12;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(427, 396);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(99, 29);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 38);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 14;
            label6.Text = "Username: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 73);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 15;
            label7.Text = "Password: ";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(131, 31);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(230, 27);
            usernameTextBox.TabIndex = 17;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(131, 66);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(230, 27);
            passwordTextBox.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(employeeIDTextBox);
            groupBox1.Controls.Add(fullNameTextBox);
            groupBox1.Controls.Add(positionTextBox);
            groupBox1.Controls.Add(cardnoTextBox);
            groupBox1.Location = new Point(12, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 164);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Info";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(usernameTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(passwordTextBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(378, 125);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Account";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 438);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(deleteButton);
            Controls.Add(dataGridView1);
            Controls.Add(updateButton);
            Controls.Add(saveButton);
            Controls.Add(addnewButton);
            Controls.Add(label1);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox employeeIDTextBox;
        private TextBox fullNameTextBox;
        private TextBox positionTextBox;
        private TextBox cardnoTextBox;
        private Button addnewButton;
        private Button saveButton;
        private Button updateButton;
        private DataGridView dataGridView1;
        private Button deleteButton;
        private Label label6;
        private Label label7;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}