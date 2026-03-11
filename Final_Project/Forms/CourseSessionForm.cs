using db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class CourseSessionForm : Form
    {
        private AppDbContext db = new AppDbContext();

        public CourseSessionForm()
        {
            InitializeComponent();
            LoadGrid();
            LoadCombo();
            LoadCourses();
            LoadInstructors();
        }

        void LoadGrid()
        {
            dataGrid.DataSource = db.CourseSessions
                .Select(c => new
                {
                    c.Id,
                    c.CourseId,
                    c.InstructorId,
                    c.Date,
                    c.Title,
                })
                .ToList();
        }
        void LoadCombo()
        {
            comboSearch.DataSource = db.CourseSessions.ToList();
            comboSearch.DisplayMember = "Title";
            comboSearch.ValueMember = "Id";
        }

        void LoadCourses()
        {
            comboCourse.DataSource = db.Courses.ToList();
            comboCourse.DisplayMember = "Name"; comboCourse.ValueMember = "Id";

            comboCourse2.DataSource = db.Courses.ToList();
            comboCourse2.DisplayMember = "Name"; comboCourse2.ValueMember = "Id";
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
            if (comboSearch.SelectedItem is CourseSession cs)
            {
                txtID.Text = cs.Id.ToString();
                txtID.Enabled = false;
                txtSessionTitle.Text = cs.Title;
                dtpDate.Value = cs.Date;
                comboCourse.SelectedValue = cs.CourseId;
                comboInstructor.SelectedValue = cs.InstructorId;
            }
        }

        private void AddSession(object sender, EventArgs e)
        {
            if (!ValidateAdd()) return;

           

            var session = new CourseSession
            {
                Title = txtSessionTitle2.Text.Trim(),
                Date = dtpDate2.Value,
                CourseId = (int)comboCourse2.SelectedValue,
                InstructorId = (int)comboInstructor2.SelectedValue
            };

            db.CourseSessions.Add(session);
            db.SaveChanges();
            LoadGrid(); LoadCombo(); LoadCourses(); LoadInstructors();
            ClearAdd();
            MessageBox.Show("Session added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateSession(object sender, EventArgs e)
        {
            if (!ValidateEdit()) return;

            int id = int.Parse(txtID.Text);
            var session = db.CourseSessions.FirstOrDefault(s => s.Id == id);
            if (session == null) { MessageBox.Show("Session not found."); return; }

            session.Title = txtSessionTitle.Text.Trim();
            session.Date = dtpDate.Value;
            session.CourseId = (int)comboCourse.SelectedValue;
            session.InstructorId = (int)comboInstructor.SelectedValue;

            db.SaveChanges();
            LoadGrid(); LoadCombo();
            MessageBox.Show("Session updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteSession(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Select a session first."); return; }

            int id = int.Parse(txtID.Text);
            var session = db.CourseSessions.FirstOrDefault(s => s.Id == id);
            if (session == null) { MessageBox.Show("Session not found."); return; }

            bool hasAttendance = db.CourseSessionAttendances.Any(a => a.CourseSessionId == id);
            if (hasAttendance)
            { MessageBox.Show("Cannot delete session because it has attendance records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            var confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            db.CourseSessions.Remove(session);
            db.SaveChanges();
            LoadGrid(); LoadCombo();
            ClearEdit();
            MessageBox.Show("Session deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool ValidateAdd()
        {
            if (comboCourse2.SelectedValue == null)
            { MessageBox.Show("Please select a course.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (comboInstructor2.SelectedValue == null)
            { MessageBox.Show("Please select an instructor.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        bool ValidateEdit()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            { MessageBox.Show("Select a session first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        void ClearAdd() {txtSessionTitle2.Clear(); }
        void ClearEdit() { txtID.Clear(); txtSessionTitle.Clear(); }
    }
}