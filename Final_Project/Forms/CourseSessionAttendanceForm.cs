using db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class CourseSessionAttendanceForm : Form
    {
        private AppDbContext db = new AppDbContext();

        public CourseSessionAttendanceForm()
        {
            InitializeComponent();
            LoadGrid();
            LoadCombo();
            LoadSessions();
            LoadStudents();
        }

        void LoadGrid()
        {
            dataGrid.DataSource = db.CourseSessionAttendances
                .Select(c => new
                {
                   c.Id,
                   c.CourseSessionId,
                   c.StudentId,
                   c.Grade,
                   c.Notes
                })
                .ToList();
        }
        void LoadCombo()
        {
            comboSearch.DataSource = db.CourseSessionAttendances.ToList();
            comboSearch.DisplayMember = "Id";
            comboSearch.ValueMember = "Id";
        }

        void LoadSessions()
        {
            comboSession.DataSource = db.CourseSessions.ToList();
            comboSession.DisplayMember = "Title"; comboSession.ValueMember = "Id";

            comboSession2.DataSource = db.CourseSessions.ToList();
            comboSession2.DisplayMember = "Title"; comboSession2.ValueMember = "Id";
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

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearch.SelectedItem is CourseSessionAttendance a)
            {
                txtID.Text = a.Id.ToString();
                txtID.Enabled = false;
                txtGrade.Text = a.Grade.ToString();
                txtNotes.Text = a.Notes;
                comboSession.SelectedValue = a.CourseSessionId;
                comboStudent.SelectedValue = a.StudentId;
            }
        }

        private void AddAttendance(object sender, EventArgs e)
        {
            if (!ValidateAdd()) return;

            

            int sessionId = (int)comboSession2.SelectedValue;
            int studentId = (int)comboStudent2.SelectedValue;

            bool alreadyExists = db.CourseSessionAttendances
                .Any(a => a.CourseSessionId == sessionId && a.StudentId == studentId);

            if (alreadyExists)
            { MessageBox.Show("This student already has an attendance record for this session.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var attendance = new CourseSessionAttendance
            {
               
                Grade = int.TryParse(txtGrade2.Text, out int g) ? g : (int?)null,
                Notes = txtNotes2.Text.Trim(),
                CourseSessionId = sessionId,
                StudentId = studentId
            };

            db.CourseSessionAttendances.Add(attendance);
            db.SaveChanges();
            LoadGrid(); LoadCombo(); LoadSessions(); LoadStudents();
            ClearAdd();
            MessageBox.Show("Attendance added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateAttendance(object sender, EventArgs e)
        {
            if (!ValidateEdit()) return;

            int id = int.Parse(txtID.Text);
            var attendance = db.CourseSessionAttendances.FirstOrDefault(a => a.Id == id);
            if (attendance == null) { MessageBox.Show("Record not found."); return; }

            attendance.Grade = int.TryParse(txtGrade.Text, out int g) ? g : (int?)null;
            attendance.Notes = txtNotes.Text.Trim();
            attendance.CourseSessionId = (int)comboSession.SelectedValue;
            attendance.StudentId = (int)comboStudent.SelectedValue;

            db.SaveChanges();
            LoadGrid(); LoadCombo();
            MessageBox.Show("Attendance updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteAttendance(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Select a record first."); return; }

            int id = int.Parse(txtID.Text);
            var attendance = db.CourseSessionAttendances.FirstOrDefault(a => a.Id == id);
            if (attendance == null) { MessageBox.Show("Record not found."); return; }

            var confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            db.CourseSessionAttendances.Remove(attendance);
            db.SaveChanges();
            LoadGrid(); LoadCombo();
            ClearEdit();
            MessageBox.Show("Attendance deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool ValidateAdd()
        {
            if (!string.IsNullOrWhiteSpace(txtGrade2.Text) && (!int.TryParse(txtGrade2.Text, out int g) || g < 0 || g > 100))
            { MessageBox.Show("Grade must be a number between 0 and 100.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (comboSession2.SelectedValue == null)
            { MessageBox.Show("Please select a session.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (comboStudent2.SelectedValue == null)
            { MessageBox.Show("Please select a student.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        bool ValidateEdit()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            { MessageBox.Show("Select a record first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!string.IsNullOrWhiteSpace(txtGrade.Text) && (!int.TryParse(txtGrade.Text, out int g) || g < 0 || g > 100))
            { MessageBox.Show("Grade must be a number between 0 and 100.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        void ClearAdd() {txtGrade2.Clear(); txtNotes2.Clear(); }
        void ClearEdit() { txtID.Clear(); txtGrade.Clear(); txtNotes.Clear(); }
    }
}