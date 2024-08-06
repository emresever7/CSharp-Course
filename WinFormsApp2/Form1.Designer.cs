namespace WinFormsApp2
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
            lblCars = new Label();
            lbxCars = new ListBox();
            btnRent = new Button();
            lblSelectedCar = new Label();
            lbxSelectedCar = new ListBox();
            btnLeave = new Button();
            lblWarning = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btnAddNewCar = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // lblCars
            // 
            lblCars.AutoSize = true;
            lblCars.Font = new Font("Segoe UI", 12F);
            lblCars.Location = new Point(61, 60);
            lblCars.Name = "lblCars";
            lblCars.Size = new Size(78, 32);
            lblCars.TabIndex = 0;
            lblCars.Text = "label1";
            // 
            // lbxCars
            // 
            lbxCars.Font = new Font("Segoe UI", 11F);
            lbxCars.FormattingEnabled = true;
            lbxCars.Location = new Point(61, 105);
            lbxCars.Name = "lbxCars";
            lbxCars.Size = new Size(271, 484);
            lbxCars.TabIndex = 1;
            // 
            // btnRent
            // 
            btnRent.Font = new Font("Segoe UI", 11F);
            btnRent.Location = new Point(360, 619);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(186, 68);
            btnRent.TabIndex = 2;
            btnRent.Text = "button1";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // lblSelectedCar
            // 
            lblSelectedCar.AutoSize = true;
            lblSelectedCar.Font = new Font("Segoe UI", 12F);
            lblSelectedCar.Location = new Point(669, 585);
            lblSelectedCar.Name = "lblSelectedCar";
            lblSelectedCar.Size = new Size(78, 32);
            lblSelectedCar.TabIndex = 3;
            lblSelectedCar.Text = "label2";
            // 
            // lbxSelectedCar
            // 
            lbxSelectedCar.Font = new Font("Segoe UI", 16F);
            lbxSelectedCar.FormattingEnabled = true;
            lbxSelectedCar.Location = new Point(600, 619);
            lbxSelectedCar.Name = "lbxSelectedCar";
            lbxSelectedCar.Size = new Size(396, 49);
            lbxSelectedCar.TabIndex = 4;
            // 
            // btnLeave
            // 
            btnLeave.Font = new Font("Segoe UI", 11F);
            btnLeave.Location = new Point(1036, 619);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(203, 68);
            btnLeave.TabIndex = 5;
            btnLeave.Text = "button1";
            btnLeave.UseVisualStyleBackColor = true;
            btnLeave.Click += btnLeave_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 12F);
            lblWarning.ForeColor = Color.Maroon;
            lblWarning.Location = new Point(600, 696);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 32);
            lblWarning.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(396, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 39);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(396, 102);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 8;
            label1.Text = "Add New Car";
            // 
            // btnAddNewCar
            // 
            btnAddNewCar.Font = new Font("Segoe UI", 11F);
            btnAddNewCar.Location = new Point(714, 152);
            btnAddNewCar.Name = "btnAddNewCar";
            btnAddNewCar.Size = new Size(128, 40);
            btnAddNewCar.TabIndex = 9;
            btnAddNewCar.Text = "Add";
            btnAddNewCar.UseVisualStyleBackColor = true;
            btnAddNewCar.Click += button1_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F);
            btnRemove.Location = new Point(61, 607);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(271, 101);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 771);
            Controls.Add(btnRemove);
            Controls.Add(btnAddNewCar);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblWarning);
            Controls.Add(btnLeave);
            Controls.Add(lbxSelectedCar);
            Controls.Add(lblSelectedCar);
            Controls.Add(btnRent);
            Controls.Add(lbxCars);
            Controls.Add(lblCars);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCars;
        private ListBox lbxCars;
        private Button btnRent;
        private Label lblSelectedCar;
        private ListBox lbxSelectedCar;
        private Button btnLeave;
        private Label lblWarning;
        private TextBox textBox1;
        private Label label1;
        private Button btnAddNewCar;
        private Button btnRemove;
    }
}
