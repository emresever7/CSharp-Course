namespace WinFormsApp4
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
            dgrwCustomers = new DataGridView();
            tbxId = new TextBox();
            tbxFirstName = new TextBox();
            tbxLastName = new TextBox();
            tbxEmail = new TextBox();
            lblId = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            tbxCity = new TextBox();
            lblCity = new Label();
            btnAdd = new Button();
            gbxAdd = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).BeginInit();
            gbxAdd.SuspendLayout();
            SuspendLayout();
            // 
            // dgrwCustomers
            // 
            dgrwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwCustomers.Dock = DockStyle.Top;
            dgrwCustomers.Location = new Point(0, 0);
            dgrwCustomers.Name = "dgrwCustomers";
            dgrwCustomers.RowHeadersWidth = 62;
            dgrwCustomers.Size = new Size(1451, 311);
            dgrwCustomers.TabIndex = 0;
            // 
            // tbxId
            // 
            tbxId.Font = new Font("Segoe UI", 12F);
            tbxId.Location = new Point(204, 84);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(204, 39);
            tbxId.TabIndex = 1;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Font = new Font("Segoe UI", 12F);
            tbxFirstName.Location = new Point(204, 129);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(204, 39);
            tbxFirstName.TabIndex = 2;
            // 
            // tbxLastName
            // 
            tbxLastName.Font = new Font("Segoe UI", 12F);
            tbxLastName.Location = new Point(204, 174);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(204, 39);
            tbxLastName.TabIndex = 3;
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 12F);
            tbxEmail.Location = new Point(205, 219);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(204, 39);
            tbxEmail.TabIndex = 4;
            tbxEmail.TextChanged += textBox4_TextChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F);
            lblId.Location = new Point(141, 87);
            lblId.Name = "lblId";
            lblId.Size = new Size(39, 32);
            lblId.TabIndex = 5;
            lblId.Text = "Id:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F);
            lblFirstName.Location = new Point(97, 132);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 32);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F);
            lblLastName.Location = new Point(66, 177);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(114, 32);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Surname:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(104, 222);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 32);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // tbxCity
            // 
            tbxCity.Font = new Font("Segoe UI", 12F);
            tbxCity.Location = new Point(204, 264);
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new Size(204, 39);
            tbxCity.TabIndex = 9;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 12F);
            lblCity.Location = new Point(120, 267);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(60, 32);
            lblCity.TabIndex = 10;
            lblCity.Text = "City:";
            lblCity.Click += label5_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(285, 327);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 48);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Submit";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(tbxLastName);
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxId);
            gbxAdd.Controls.Add(lblCity);
            gbxAdd.Controls.Add(tbxFirstName);
            gbxAdd.Controls.Add(tbxCity);
            gbxAdd.Controls.Add(tbxEmail);
            gbxAdd.Controls.Add(lblEmail);
            gbxAdd.Controls.Add(lblId);
            gbxAdd.Controls.Add(lblLastName);
            gbxAdd.Controls.Add(lblFirstName);
            gbxAdd.Font = new Font("Segoe UI", 12F);
            gbxAdd.Location = new Point(51, 335);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(550, 430);
            gbxAdd.TabIndex = 12;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 855);
            Controls.Add(gbxAdd);
            Controls.Add(dgrwCustomers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrwCustomers;
        private TextBox tbxId;
        private TextBox tbxFirstName;
        private TextBox tbxLastName;
        private TextBox tbxEmail;
        private Label lblId;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private TextBox tbxCity;
        private Label lblCity;
        private Button btnAdd;
        private GroupBox gbxAdd;
    }
}
