namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string productsText = "Products";
            var addToCartButtonText = "Add To Cart";
            var cartText = "Your Cart";
            var removeFromCartText = "Remove from Cart";


            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartButtonText;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartText;

            string[] products = new string[] { "Laptop", "Desktop", "Klavye", "Mouse", "Monitor" };

            //foreach (string product in products) 
            //{
            //    lbxProducts.Items.Add(product);

            //}

            for (int i = 0; i < products.Length; i++)
            {
                lbxProducts.Items.Add(products[i]);

            }

            //lbxProducts.Items.Add("Laptop");
            //lbxProducts.Items.Add("Desktop");
            //lbxProducts.Items.Add("Keyboard");
            //lbxProducts.Items.Add("Mouse");
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;
            }
            else
            {
                MessageBox.Show("No item selected.");
            }

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }

            else
            {
                MessageBox.Show("No item selected.");
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
