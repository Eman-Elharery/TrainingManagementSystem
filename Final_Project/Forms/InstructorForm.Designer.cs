namespace Final_Project
{
    partial class InstructorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnBack = new Button();
            lblTitle = new Label();
            dataGrid = new DataGridView();
            splitContainer1 = new SplitContainer();
            lblID = new Label(); lblFirstName = new Label(); lblLastName = new Label();
            lblPhone = new Label(); lblDept = new Label();
            txtID = new TextBox(); txtFirstName = new TextBox(); txtLastName = new TextBox();
            txtPhone = new TextBox(); comboDept = new ComboBox();
            btnDelete = new Button(); btnUpdate = new Button();
            lblFirstName2 = new Label(); lblLastName2 = new Label();
            lblPhone2 = new Label(); lblDept2 = new Label();
             txtFirstName2 = new TextBox(); txtLastName2 = new TextBox();
            txtPhone2 = new TextBox(); comboDept2 = new ComboBox();
            btnAdd = new Button();
            comboSearch = new ComboBox();

            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();

            btnBack.Location = new Point(26, 32); btnBack.Size = new Size(39, 29);
            btnBack.Text = "<"; btnBack.Click += btnBack_Click;

            comboSearch.Location = new Point(83, 33); comboSearch.Size = new Size(151, 28);
            comboSearch.SelectedIndexChanged += comboSearch_SelectedIndexChanged;

            lblTitle.AutoSize = true; lblTitle.Font = new Font("Segoe UI", 25F);
            lblTitle.Location = new Point(255, 15); lblTitle.Text = "Instructor Form";

            splitContainer1.Location = new Point(45, 105);
            splitContainer1.Size = new Size(709, 290);
            splitContainer1.SplitterDistance = 362;

            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.Controls.AddRange(new Control[] {
                lblID, lblFirstName, lblLastName, lblPhone, lblDept,
                txtID, txtFirstName, txtLastName, txtPhone, comboDept,
                btnDelete, btnUpdate
            });

            splitContainer1.Panel2.BackColor = Color.PeachPuff;
            splitContainer1.Panel2.Controls.AddRange(new Control[] {
                 lblFirstName2, lblLastName2, lblPhone2, lblDept2,
                 txtFirstName2, txtLastName2, txtPhone2, comboDept2,
                btnAdd
            });

            lblID.AutoSize = true; lblID.Location = new Point(54, 35); lblID.Text = "ID";
            lblFirstName.AutoSize = true; lblFirstName.Location = new Point(20, 70); lblFirstName.Text = "First Name";
            lblLastName.AutoSize = true; lblLastName.Location = new Point(20, 105); lblLastName.Text = "Last Name";
            lblPhone.AutoSize = true; lblPhone.Location = new Point(31, 140); lblPhone.Text = "Phone";
            lblDept.AutoSize = true; lblDept.Location = new Point(10, 175); lblDept.Text = "Department";

            txtID.Location = new Point(107, 30); txtID.Size = new Size(224, 27);
            txtFirstName.Location = new Point(107, 65); txtFirstName.Size = new Size(224, 27);
            txtLastName.Location = new Point(107, 100); txtLastName.Size = new Size(224, 27);
            txtPhone.Location = new Point(107, 135); txtPhone.Size = new Size(224, 27);
            comboDept.Location = new Point(107, 170); comboDept.Size = new Size(224, 28);

            btnDelete.BackColor = Color.Salmon; btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(88, 215); btnDelete.Size = new Size(94, 29);
            btnDelete.Text = "Delete"; btnDelete.Click += DeleteInstructor;

            btnUpdate.BackColor = Color.DarkGoldenrod; btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(237, 215); btnUpdate.Size = new Size(94, 29);
            btnUpdate.Text = "Update"; btnUpdate.Click += UpdateInstructor;

            
            lblFirstName2.AutoSize = true; lblFirstName2.Location = new Point(13, 70); lblFirstName2.Text = "First Name";
            lblLastName2.AutoSize = true; lblLastName2.Location = new Point(13, 105); lblLastName2.Text = "Last Name";
            lblPhone2.AutoSize = true; lblPhone2.Location = new Point(13, 140); lblPhone2.Text = "Phone";
            lblDept2.AutoSize = true; lblDept2.Location = new Point(3, 175); lblDept2.Text = "Department";

            txtFirstName2.Location = new Point(94, 65); txtFirstName2.Size = new Size(224, 27);
            txtLastName2.Location = new Point(94, 100); txtLastName2.Size = new Size(224, 27);
            txtPhone2.Location = new Point(94, 135); txtPhone2.Size = new Size(224, 27);
            comboDept2.Location = new Point(94, 170); comboDept2.Size = new Size(224, 28);

            btnAdd.BackColor = Color.SeaGreen; btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(124, 215); btnAdd.Size = new Size(94, 29);
            btnAdd.Text = "Add"; btnAdd.Click += AddInstructor;

            dataGrid.Location = new Point(26, 410);
            dataGrid.Size = new Size(757, 188);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.ReadOnly = true;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 625);
            Controls.AddRange(new Control[] { lblTitle, dataGrid, splitContainer1, comboSearch, btnBack });
            Name = "InstructorForm";
            Text = "InstructorForm";

            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            splitContainer1.Panel1.ResumeLayout(false); splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false); splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false); PerformLayout();
        }

        private Button btnBack, btnDelete, btnUpdate, btnAdd;
        private Label lblTitle, lblID, lblFirstName, lblLastName, lblPhone, lblDept;
        private Label  lblFirstName2, lblLastName2, lblPhone2, lblDept2;
        private TextBox txtID, txtFirstName, txtLastName, txtPhone;
        private TextBox  txtFirstName2, txtLastName2, txtPhone2;
        private ComboBox comboDept, comboDept2, comboSearch;
        private DataGridView dataGrid;
        private SplitContainer splitContainer1;
    }
}