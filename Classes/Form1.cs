namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.FirstName = "Emre";
            student1.Age = 24;
            student1.Email = "emre@gmail.com";

            Student student2 = new Student();
            student2.FirstName = "İlay";
            student2.Age = 5;
            student2.Email = "ilay@gmail.com";

            Student student3 = new Student();
            student3.FirstName = "Ayaz";
            student3.Age = 3;
            student3.Email = "ayaz@gmail.com";

            List<Student> students = new List<Student>() { student1, student2, student3 };

            foreach (Student student in students)
            {
                //MessageBox.Show(student.FirstName + " " + student.Age);
                lbxStudent.Items.Add(student.FirstName);
            }

            dgrwStudents.DataSource = students;

        }

        private void lbxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
