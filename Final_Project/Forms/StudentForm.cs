using db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class StudentForm : Form
    {
        private AppDbContext db = new AppDbContext();

        public StudentForm()
        {
            InitializeComponent();
            LoadGrid();
            LoadCombo();
        }

        void LoadGrid()
        {
            dataGrid.DataSource = db.Students
                .Select(c => new
                {
                    c.Id,
                    c.FirstName,
                    c.LastName,
                    c.Phone,
                })
                .ToList();
        }

        void LoadCombo()
        {
            comboSearch.DataSource = db.Students.ToList();
            comboSearch.DisplayMember = "FirstName";
            comboSearch.ValueMember = "Id";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearch.SelectedItem is Student s)
            {
                txtID.Text = s.Id.ToString();
                txtID.Enabled = false;
                txtFirstName.Text = s.FirstName;
                txtLastName.Text = s.LastName;
                txtPhone.Text = s.Phone;
            }
        }

        private void AddStudent(object sender, EventArgs e)
        {
           
            var student = new Student
            {
                FirstName = txtFirstName2.Text.Trim(),
                LastName = txtLastName2.Text.Trim(),
                Phone = txtPhone2.Text.Trim()
            };

            db.Students.Add(student);
            db.SaveChanges();
            LoadGrid(); LoadCombo();
            ClearAdd();
            MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateStudent(object sender, EventArgs e)
        {

            int id = int.Parse(txtID.Text);
            var student = db.Students.FirstOrDefault(s => s.Id == id);
            if (student == null) { MessageBox.Show("Student not found."); return; }

            student.FirstName = txtFirstName.Text.Trim();
            student.LastName = txtLastName.Text.Trim();
            student.Phone = txtPhone.Text.Trim();

            db.SaveChanges();
            LoadGrid(); LoadCombo();
            MessageBox.Show("Student updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteStudent(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Select a student first."); return; }

            int id = int.Parse(txtID.Text);
            var student = db.Students.FirstOrDefault(s => s.Id == id);
            if (student == null) { MessageBox.Show("Student not found."); return; }

            bool hasAttendance = db.CourseSessionAttendances.Any(a => a.StudentId == id);
            bool hasCourses = db.CourseStudents.Any(cs => cs.StudentId == id);

            if (hasAttendance || hasCourses)
            {
                MessageBox.Show("Cannot delete student because they have related records (attendance or courses).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            db.Students.Remove(student);
            db.SaveChanges();
            LoadGrid(); LoadCombo();
            ClearEdit();
            MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void ClearAdd()
        {
             txtFirstName2.Clear(); txtLastName2.Clear(); txtPhone2.Clear();
        }

        void ClearEdit()
        {
            txtID.Clear(); txtFirstName.Clear(); txtLastName.Clear(); txtPhone.Clear();
        }
    }
}