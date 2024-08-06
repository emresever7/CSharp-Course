namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> cars;


        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] cars = new string[] { "Hyundai Bayon", "Volkswagen Caddy", "Audi A3", "Audi R8", "Ford Ranger" };

            string carsText = "Cars";
            string rentButtonText = "Rent This Car";
            string selectedCarText = "Your Car";
            string leaveButtonText = "Leave";


            lblCars.Text = carsText;
            btnRent.Text = rentButtonText;
            lblSelectedCar.Text = selectedCarText;
            btnLeave.Text = leaveButtonText;

            cars = new List<string>() { "Hyundai Bayon", "Volkswagen Caddy", "Audi A3", "Audi R8", "Ford Ranger" };

            foreach (string car in cars)
            {
                lbxCars.Items.Add(car);
            }


        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (lbxCars.SelectedItem != null)
            {
                lbxSelectedCar.Items.Add(lbxCars.SelectedItem);
                lbxCars.Enabled = false;
                string warningText = "You can choose only one car at one time.";
                btnRent.Enabled = false;
                lblWarning.Text = warningText;
            }
            else
            {
                MessageBox.Show("Choose your car first.");
            }

            //if(lbxSelectedCar.Items != null)
            //{

            //}

        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            string warningTextNone = " "; 

            if (lbxSelectedCar.Items != null && lbxSelectedCar.SelectedItem != null)
            {
                lbxSelectedCar.Items.Remove(lbxSelectedCar.SelectedItem);
                btnRent.Enabled = true;
                lbxCars.Enabled = true;
                lblWarning.Text = warningTextNone;
            }
            else
            {
                MessageBox.Show("Choose the car you want to leave.");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 2)
            {
                cars.Add(textBox1.Text);
                lbxCars.Items.Clear();

                foreach (string car in cars)
                {
                    lbxCars.Items.Add(car);
                }
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxSelectedCar.Items != null) 
            {
                cars.Remove(lbxCars.SelectedItem.ToString());
                lbxCars.Items.Clear();

                foreach (string car in cars)
                {
                    lbxCars.Items.Add(car);
                }
            }
            
        }
    }
}
