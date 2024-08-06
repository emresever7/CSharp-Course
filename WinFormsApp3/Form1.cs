namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        List<string> students;

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() { "Emre Sever", "Mehmet Sever", "Neriman Sever" };

            foreach (string student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            if (tbxStudentName.Text.Length >= 2)
            {
                students.Add(tbxStudentName.Text);
                lbxStudentList.Items.Clear();

                foreach (string student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("En az iki karakterden oluþmalý.");
            }


        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lbxStudentList.SelectedItem != null)
            {
                students.Remove(lbxStudentList.SelectedItem.ToString());
                lbxStudentList.Items.Clear();
                foreach (string student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }

            else
            {
                MessageBox.Show("Öðe seçilmedi.");
            }
        }
    }
}
