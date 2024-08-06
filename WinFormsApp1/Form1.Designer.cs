namespace WinFormsApp1
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
            lbxProducts = new ListBox();
            lblProducts = new Label();
            btnAddToCart = new Button();
            lbxCart = new ListBox();
            lblCart = new Label();
            btnRemoveFromCart = new Button();
            SuspendLayout();
            // 
            // lbxProducts
            // 
            lbxProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbxProducts.FormattingEnabled = true;
            lbxProducts.Location = new Point(53, 107);
            lbxProducts.Name = "lbxProducts";
            lbxProducts.Size = new Size(270, 420);
            lbxProducts.TabIndex = 0;
            lbxProducts.SelectedIndexChanged += lbxProducts_SelectedIndexChanged;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI", 12F);
            lblProducts.Location = new Point(56, 71);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(0, 32);
            lblProducts.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Font = new Font("Segoe UI", 11F);
            btnAddToCart.Location = new Point(381, 107);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(225, 82);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "button1";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lbxCart
            // 
            lbxCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbxCart.FormattingEnabled = true;
            lbxCart.Location = new Point(664, 107);
            lbxCart.Name = "lbxCart";
            lbxCart.Size = new Size(260, 420);
            lbxCart.TabIndex = 3;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCart.Location = new Point(664, 61);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(78, 32);
            lblCart.TabIndex = 4;
            lblCart.Text = "label1";
            lblCart.Click += label1_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnRemoveFromCart.Location = new Point(971, 107);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(211, 82);
            btnRemoveFromCart.TabIndex = 5;
            btnRemoveFromCart.Text = "button1";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 657);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(lblCart);
            Controls.Add(lbxCart);
            Controls.Add(btnAddToCart);
            Controls.Add(lblProducts);
            Controls.Add(lbxProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxProducts;
        private Label lblProducts;
        private Button btnAddToCart;
        private ListBox lbxCart;
        private Label lblCart;
        private Button btnRemoveFromCart;
    }
}
