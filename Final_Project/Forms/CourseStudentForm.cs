using db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class CourseStudentForm : Form
    {
        private AppDbContext db = new AppDbContext();

        public CourseStudentForm()
        {
            InitializeComponent();
            LoadGrid();
            LoadCourses();
            LoadStudents();
        }

        void LoadGrid()
        {
            dataGrid.DataSource = db.CourseStudents
                .Select(c => new
                {
                    c.CourseId,
                    c.StudentId,
                })
                .ToList();
        }
        void LoadCourses()
        {
            comboCourse.DataSource = db.Courses.ToList();
            comboCourse.DisplayMember = "Name"; comboCourse.ValueMember = "Id";

            comboCourse2.DataSource = db.Courses.ToList();
            comboCourse2.DisplayMember = "Name"; comboCourse2.ValueMember = "Id";
        }

        void LoadStudents()
        {
            comboStudent.DataSource = db.Students.ToList();
            comboStudent.DisplayMember = "FirstName"; comboStudent.ValueMember = "Id";

            comboStudent2.DataSource = db.Students.ToList();
            comboStudent2.DisplayMember = "FirstName"; comboStudent2.ValueMember = "Id";
        }

        private void btnBack_Click(object sender, EventArgs e) {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void AddCourseStudent(object sender, EventArgs e)
        {
            if (comboCourse2.SelectedValue == null || comboStudent2.SelectedValue == null)
            { MessageBox.Show("Please select both a course and a student.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int courseId = (int)comboCourse2.SelectedValue;
            int studentId = (int)comboStudent2.SelectedValue;

            bool exists = db.CourseStudents.Any(cs => cs.CourseId == courseId && cs.StudentId == studentId);
            if (exists)
            { MessageBox.Show("This student is already enrolled in this course.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var cs = new CourseStudent { CourseId = courseId, StudentId = studentId };

            db.CourseStudents.Add(cs);
            db.SaveChanges();
            LoadGrid(); LoadCourses(); LoadStudents();
            MessageBox.Show("Student enrolled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteCourseStudent(object sender, EventArgs e)
        {
            if (comboCourse.SelectedValue == null || comboStudent.SelectedValue == null)
            { MessageBox.Show("Please select both a course and a student.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int courseId = (int)comboCourse.SelectedValue;
            int studentId = (int)comboStudent.SelectedValue;

            var cs = db.CourseStudents.FirstOrDefault(x => x.CourseId == courseId && x.StudentId == studentId);
            if (cs == null)
            { MessageBox.Show("This enrollment record does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            var confirm = MessageBox.Show("Are you sure you want to remove this student from the course?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            db.CourseStudents.Remove(cs);
            db.SaveChanges();
            LoadGrid(); LoadCourses(); LoadStudents();
            MessageBox.Show("Student removed from course successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}