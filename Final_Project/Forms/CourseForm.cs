using db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class CourseForm : Form
    {
        private AppDbContext db = new AppDbContext();

        public CourseForm()
        {
            InitializeComponent();
            LoadGrid();
            LoadCombo();
            LoadDepartments();
            LoadInstructors();
        }

        void LoadGrid()
        {
            dataGrid.DataSource = db.Courses
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.Duration,
                    c.InstructorId,
                    c.DepartmentId
                })
                .ToList();
        }

        void LoadCombo()
        {
            comboSearch.DataSource = db.Courses.ToList();
            comboSearch.DisplayMember = "Name";
            comboSearch.ValueMember = "Id";
        }

        void LoadDepartments()
        {
            comboDept.DataSource = db.Departments.ToList();
            comboDept.DisplayMember = "Name"; comboDept.ValueMember = "Id";

            comboDept2.DataSource = db.Departments.ToList();
            comboDept2.DisplayMember = "Name"; comboDept2.ValueMember = "Id";
        }

        void LoadInstructors()
        {
            comboInstructor.DataSource = db.Instructors.ToList();
            comboInstructor.DisplayMember = "FirstName"; comboInstructor.ValueMember = "Id";

            comboInstructor2.DataSource = db.Instructors.ToList();
            comboInstructor2.DisplayMember = "FirstName"; comboInstructor2.ValueMember = "Id";
        }

        private void btnBack_Click(object sender, EventArgs e) 
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearch.SelectedItem is Course c)
            {
                txtID.Text = c.Id.ToString();
                txtID.Enabled = false;
                txtName.Text = c.Name;
                txtDuration.Text = c.Duration.ToString();
                comboDept.SelectedValue = c.DepartmentId;
                comboInstructor.SelectedValue = c.InstructorId;
            }
        }

        private void AddCourse(object sender, EventArgs e)
        {
            if (!ValidateAdd()) return;


            var course = new Course
            {
                Name = txtName2.Text.Trim(),
                Duration = int.Parse(txtDuration2.Text),
                DepartmentId = (int)comboDept2.SelectedValue,
                InstructorId = (int)comboInstructor2.SelectedValue
            };

            db.Courses.Add(course);
            db.SaveChanges();
            LoadGrid(); LoadCombo(); LoadDepartments(); LoadInstructors();
            ClearAdd();
            MessageBox.Show("Course added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateCourse(object sender, EventArgs e)
        {
            if (!ValidateEdit()) return;

            int id = int.Parse(txtID.Text);
            var course = db.Courses.FirstOrDefault(c => c.Id == id);
            if (course == null) { MessageBox.Show("Course not found."); return; }

            course.Name = txtName.Text.Trim();
            course.Duration = int.Parse(txtDuration.Text);
            course.DepartmentId = (int)comboDept.SelectedValue;
            course.InstructorId = (int)comboInstructor.SelectedValue;

            db.SaveChanges();
            LoadGrid(); LoadCombo();
            MessageBox.Show("Course updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteCourse(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Select a course first."); return; }

            int id = int.Parse(txtID.Text);
            var course = db.Courses.FirstOrDefault(c => c.Id == id);
            if (course == null) { MessageBox.Show("Course not found."); return; }

            bool hasSessions = db.CourseSessions.Any(cs => cs.CourseId == id);
            bool hasStudents = db.CourseStudents.Any(cs => cs.CourseId == id);

            if (hasSessions || hasStudents)
            { MessageBox.Show("Cannot delete course because it has related records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            var confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            db.Courses.Remove(course);
            db.SaveChanges();
            LoadGrid(); LoadCombo();
            ClearEdit();
            MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool ValidateAdd()
        {
            
            if (!int.TryParse(txtDuration2.Text, out int dur) || dur <= 0)
            { MessageBox.Show("Please enter a valid positive duration.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (comboDept2.SelectedValue == null)
            { MessageBox.Show("Please select a department.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (comboInstructor2.SelectedValue == null)
            { MessageBox.Show("Please select an instructor.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        bool ValidateEdit()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            { MessageBox.Show("Select a course first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if ( !int.TryParse(txtDuration.Text, out int dur) || dur <= 0)
            { MessageBox.Show("Please enter a valid positive duration.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        void ClearAdd() { txtName2.Clear(); txtDuration2.Clear(); }
        void ClearEdit() { txtID.Clear(); txtName.Clear(); txtDuration.Clear(); }
    }
}