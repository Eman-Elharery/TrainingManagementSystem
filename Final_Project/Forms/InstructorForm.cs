using db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class InstructorForm : Form
    {
        private AppDbContext db = new AppDbContext();

        public InstructorForm()
        {
            InitializeComponent();
            LoadGrid();
            LoadCombo();
            LoadDepartments();
        }

        void LoadGrid()
        {
            dataGrid.DataSource = db.Instructors
                .Select(c => new
                {
                    c.Id,
                    c.FirstName,
                    c.LastName,
                    c.DepartmentId,
                    c.Phone,
                })
                .ToList();
        }

        void LoadCombo()
        {
            comboSearch.DataSource = db.Instructors.ToList();
            comboSearch.DisplayMember = "FirstName";
            comboSearch.ValueMember = "Id";
        }

        void LoadDepartments()
        {
            var depts = db.Departments.ToList();
            comboDept.DataSource = depts;
            comboDept.DisplayMember = "Name";
            comboDept.ValueMember = "Id";

            comboDept2.DataSource = db.Departments.ToList();
            comboDept2.DisplayMember = "Name";
            comboDept2.ValueMember = "Id";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearch.SelectedItem is Instructor ins)
            {
                txtID.Text = ins.Id.ToString();
                txtID.Enabled = false;
                txtFirstName.Text = ins.FirstName;
                txtLastName.Text = ins.LastName;
                txtPhone.Text = ins.Phone;
                comboDept.SelectedValue = ins.DepartmentId;
            }
        }

        private void AddInstructor(object sender, EventArgs e)
        {
            if (!ValidateAdd()) return;

          

            var ins = new Instructor
            {
                FirstName = txtFirstName2.Text.Trim(),
                LastName = txtLastName2.Text.Trim(),
                Phone = txtPhone2.Text.Trim(),
                DepartmentId = (int)comboDept2.SelectedValue
            };

            db.Instructors.Add(ins);
            db.SaveChanges();
            LoadGrid(); LoadCombo(); LoadDepartments();
            ClearAdd();
            MessageBox.Show("Instructor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateInstructor(object sender, EventArgs e)
        {
            if (!ValidateEdit()) return;

            int id = int.Parse(txtID.Text);
            var ins = db.Instructors.FirstOrDefault(i => i.Id == id);
            if (ins == null) { MessageBox.Show("Instructor not found."); return; }

            ins.FirstName = txtFirstName.Text.Trim();
            ins.LastName = txtLastName.Text.Trim();
            ins.Phone = txtPhone.Text.Trim();
            ins.DepartmentId = (int)comboDept.SelectedValue;

            db.SaveChanges();
            LoadGrid(); LoadCombo();
            MessageBox.Show("Instructor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteInstructor(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Select an instructor first."); return; }

            int id = int.Parse(txtID.Text);
            var ins = db.Instructors.FirstOrDefault(i => i.Id == id);
            if (ins == null) { MessageBox.Show("Instructor not found."); return; }

            bool managesDept = db.Departments.Any(d => d.ManagerId == id);
            bool hasCourses = db.Courses.Any(c => c.InstructorId == id);
            bool hasSessions = db.CourseSessions.Any(cs => cs.InstructorId == id);

            if (managesDept || hasCourses || hasSessions)
            {
                MessageBox.Show("Cannot delete instructor because they have related records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            db.Instructors.Remove(ins);
            db.SaveChanges();
            LoadGrid(); LoadCombo();
            ClearEdit();
            MessageBox.Show("Instructor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool ValidateAdd()
        {
            if (comboDept2.SelectedValue == null)
            { MessageBox.Show("Please select a department.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        bool ValidateEdit()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            { MessageBox.Show("Select an instructor first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (comboDept.SelectedValue == null)
            { MessageBox.Show("Please select a department.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        void ClearAdd() { txtFirstName2.Clear(); txtLastName2.Clear(); txtPhone2.Clear(); }
        void ClearEdit() { txtID.Clear(); txtFirstName.Clear(); txtLastName.Clear(); txtPhone.Clear(); }
    }
}