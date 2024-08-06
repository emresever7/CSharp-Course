namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentList = new Label();
            lbxStudentList = new ListBox();
            lblStudentName = new Label();
            tbxStudentName = new TextBox();
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            SuspendLayout();
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.Location = new Point(58, 73);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(81, 25);
            lblStudentList.TabIndex = 0;
            lblStudentList.Text = "Students";
            lblStudentList.Click += label1_Click;
            // 
            // lbxStudentList
            // 
            lbxStudentList.FormattingEnabled = true;
            lbxStudentList.Location = new Point(58, 113);
            lbxStudentList.Name = "lbxStudentList";
            lbxStudentList.Size = new Size(258, 454);
            lbxStudentList.TabIndex = 1;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 12F);
            lblStudentName.Location = new Point(364, 110);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(168, 32);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Student Name";
            lblStudentName.Click += label1_Click_1;
            // 
            // tbxStudentName
            // 
            tbxStudentName.Font = new Font("Segoe UI", 12F);
            tbxStudentName.Location = new Point(538, 107);
            tbxStudentName.Name = "tbxStudentName";
            tbxStudentName.Size = new Size(286, 39);
            tbxStudentName.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(853, 107);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(111, 39);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Font = new Font("Segoe UI", 12F);
            btnRemoveStudent.Location = new Point(57, 583);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(259, 53);
            btnRemoveStudent.TabIndex = 5;
            btnRemoveStudent.Text = "Remove";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 693);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(tbxStudentName);
            Controls.Add(lblStudentName);
            Controls.Add(lbxStudentList);
            Controls.Add(lblStudentList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentList;
        private ListBox lbxStudentList;
        private Label lblStudentName;
        private TextBox tbxStudentName;
        private Button btnAddStudent;
        private Button btnRemoveStudent;
    }
}
