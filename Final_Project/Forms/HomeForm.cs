using db;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm f1 = new StudentForm();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InstructorForm f2 = new InstructorForm();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepartmentForm f3 = new DepartmentForm();
            f3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CourseStudentForm f4 = new CourseStudentForm();
            f4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CourseSessionForm f5 = new CourseSessionForm();
            f5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CourseForm f6 = new CourseForm();
            f6.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CourseSessionAttendanceForm f7 = new CourseSessionAttendanceForm();
            f7.Show();
            this.Hide();
        }
    }
}
