namespace Final_Project
{
    partial class DepartmentForm
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
            lblID = new Label();
            lblName = new Label();
            lblLocation = new Label();
            lblManager = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtLocation = new TextBox();
            comboManager = new ComboBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            
            lblName2 = new Label();
            lblLocation2 = new Label();
            lblManager2 = new Label();
            
            txtName2 = new TextBox();
            txtLocation2 = new TextBox();
            comboManager2 = new ComboBox();
            btnAdd = new Button();
            comboSearch = new ComboBox();

            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();

            btnBack.Location = new Point(26, 32);
            btnBack.Size = new Size(39, 29);
            btnBack.Text = "<";
            btnBack.Click += btnBack_Click;

            comboSearch.Location = new Point(83, 33);
            comboSearch.Size = new Size(151, 28);
            comboSearch.SelectedIndexChanged += comboSearch_SelectedIndexChanged;

            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 25F);
            lblTitle.Location = new Point(250, 15);
            lblTitle.Text = "Department Form";

            splitContainer1.Location = new Point(45, 105);
            splitContainer1.Size = new Size(709, 264);
            splitContainer1.SplitterDistance = 362;

            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.Controls.AddRange(new Control[] {
                lblID, lblName, lblLocation, lblManager,
                txtID, txtName, txtLocation, comboManager,
                btnDelete, btnUpdate
            });

            splitContainer1.Panel2.BackColor = Color.PeachPuff;
            splitContainer1.Panel2.Controls.AddRange(new Control[] {
               lblName2, lblLocation2, lblManager2,
                txtName2, txtLocation2, comboManager2,
                btnAdd
            });

            
            lblID.AutoSize = true; lblID.Location = new Point(54, 39); lblID.Text = "ID";
            lblName.AutoSize = true; lblName.Location = new Point(40, 74); lblName.Text = "Name";
            lblLocation.AutoSize = true; lblLocation.Location = new Point(31, 109); lblLocation.Text = "Location";
            lblManager.AutoSize = true; lblManager.Location = new Point(10, 145); lblManager.Text = "Manager ID";

            txtID.Location = new Point(107, 32); txtID.Size = new Size(224, 27);
            txtName.Location = new Point(107, 67); txtName.Size = new Size(224, 27);
            txtLocation.Location = new Point(107, 104); txtLocation.Size = new Size(224, 27);
            comboManager.Location = new Point(107, 137); comboManager.Size = new Size(224, 28);

            btnDelete.BackColor = Color.Salmon; btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(88, 185); btnDelete.Size = new Size(94, 29);
            btnDelete.Text = "Delete"; btnDelete.Click += DeleteDepartment;

            btnUpdate.BackColor = Color.DarkGoldenrod; btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(237, 185); btnUpdate.Size = new Size(94, 29);
            btnUpdate.Text = "Update"; btnUpdate.Click += UpdateDepartment;

            
            lblName2.AutoSize = true; lblName2.Location = new Point(13, 70); lblName2.Text = "Name";
            lblLocation2.AutoSize = true; lblLocation2.Location = new Point(3, 106); lblLocation2.Text = "Location";
            lblManager2.AutoSize = true; lblManager2.Location = new Point(3, 145); lblManager2.Text = "Manager ID";

            txtName2.Location = new Point(94, 66); txtName2.Size = new Size(224, 27);
            txtLocation2.Location = new Point(94, 102); txtLocation2.Size = new Size(224, 27);
            comboManager2.Location = new Point(94, 137); comboManager2.Size = new Size(224, 28);

            btnAdd.BackColor = Color.SeaGreen; btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(124, 185); btnAdd.Size = new Size(94, 29);
            btnAdd.Text = "Add"; btnAdd.Click += AddDepartment;

          
            dataGrid.Location = new Point(26, 390);
            dataGrid.Size = new Size(757, 188);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.ReadOnly = true;

            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.AddRange(new Control[] { lblTitle, dataGrid, splitContainer1, comboSearch, btnBack });
            Name = "DepartmentForm";
            Text = "DepartmentForm";

            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            splitContainer1.Panel1.ResumeLayout(false); splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false); splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnBack, btnDelete, btnUpdate, btnAdd;
        private Label lblTitle, lblID, lblName, lblLocation, lblManager;
        private Label  lblName2, lblLocation2, lblManager2;
        private TextBox txtID, txtName, txtLocation;
        private TextBox  txtName2, txtLocation2;
        private ComboBox comboManager, comboManager2, comboSearch;
        private DataGridView dataGrid;
        private SplitContainer splitContainer1;
    }
}