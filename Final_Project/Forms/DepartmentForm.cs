using db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class DepartmentForm : Form
    {
        private AppDbContext db = new AppDbContext();

        public DepartmentForm()
        {
            InitializeComponent();
            LoadGrid();
            LoadCombo();
            LoadManagers();
        }

        void LoadGrid()
        {
            dataGrid.DataSource = db.Departments
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.ManagerId,
                    c.Location
                })
                .ToList();
        }

        void LoadCombo()
        {
            comboSearch.DataSource = db.Departments.ToList();
            comboSearch.DisplayMember = "Name";
            comboSearch.ValueMember = "Id";
        }

        void LoadManagers()
        {
            comboManager.DataSource = db.Instructors.ToList();
            comboManager.DisplayMember = "FirstName";
            comboManager.ValueMember = "Id";

            comboManager2.DataSource = db.Instructors.ToList();
            comboManager2.DisplayMember = "FirstName";
            comboManager2.ValueMember = "Id";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearch.SelectedItem is Department dept)
            {
                txtID.Text = dept.Id.ToString();
                txtID.Enabled = false;
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
                comboManager.SelectedValue = dept.ManagerId;
            }
        }

        private void AddDepartment(object sender, EventArgs e)
        {
            if (!ValidateAdd()) return;

          

            int managerId = (int)comboManager2.SelectedValue;

            bool managerHasDept = db.Departments.Any(d => d.ManagerId == managerId);
            if (managerHasDept)
            {
                MessageBox.Show("This manager already manages another department.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dept = new Department
            {
                Name = txtName2.Text.Trim(),
                Location = txtLocation2.Text.Trim(),
                ManagerId = managerId
            };

            db.Departments.Add(dept);
            db.SaveChanges();
            LoadGrid(); LoadCombo(); LoadManagers();
            ClearAdd();
            MessageBox.Show("Department added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateDepartment(object sender, EventArgs e)
        {
            if (!ValidateEdit()) return;

            int id = int.Parse(txtID.Text);
            int managerId = (int)comboManager.SelectedValue;

            bool managerHasDept = db.Departments.Any(d => d.ManagerId == managerId && d.Id != id);
            if (managerHasDept)
            {
                MessageBox.Show("This manager already manages another department.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dept = db.Departments.FirstOrDefault(d => d.Id == id);
            if (dept == null) { MessageBox.Show("Department not found."); return; }

            dept.Name = txtName.Text.Trim();
            dept.Location = txtLocation.Text.Trim();
            dept.ManagerId = managerId;

            db.SaveChanges();
            LoadGrid(); LoadCombo();
            MessageBox.Show("Department updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteDepartment(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Select a department first."); return; }

            int id = int.Parse(txtID.Text);
            var dept = db.Departments.FirstOrDefault(d => d.Id == id);
            if (dept == null) { MessageBox.Show("Department not found."); return; }

            bool hasInstructors = db.Instructors.Any(i => i.DepartmentId == id);
            bool hasCourses = db.Courses.Any(c => c.DepartmentId == id);

            if (hasInstructors || hasCourses)
            {
                MessageBox.Show("Cannot delete department because it has related instructors or courses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this department?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            db.Departments.Remove(dept);
            db.SaveChanges();
            LoadGrid(); LoadCombo();
            ClearEdit();
            MessageBox.Show("Department deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool ValidateAdd()
        {
           
            if (string.IsNullOrWhiteSpace(txtName2.Text))
            { MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (comboManager2.SelectedValue == null)
            { MessageBox.Show("Please select a manager.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        bool ValidateEdit()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            { MessageBox.Show("Select a department first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (comboManager.SelectedValue == null)
            { MessageBox.Show("Please select a manager.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        void ClearAdd() { txtName2.Clear(); txtLocation2.Clear(); }
        void ClearEdit() { txtID.Clear(); txtName.Clear(); txtLocation.Clear(); }
    }
}