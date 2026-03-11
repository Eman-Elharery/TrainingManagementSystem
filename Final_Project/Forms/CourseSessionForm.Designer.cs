namespace Final_Project
{
    partial class CourseSessionForm
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
            lblID = new Label(); lblTitle1 = new Label(); lblDate = new Label();
            lblCourse = new Label(); lblInstructor = new Label();
            txtID = new TextBox(); txtSessionTitle = new TextBox();
            dtpDate = new DateTimePicker();
            comboCourse = new ComboBox(); comboInstructor = new ComboBox();
            btnDelete = new Button(); btnUpdate = new Button();
            lblTitle2 = new Label(); lblDate2 = new Label();
            lblCourse2 = new Label(); lblInstructor2 = new Label();
             txtSessionTitle2 = new TextBox();
            dtpDate2 = new DateTimePicker();
            comboCourse2 = new ComboBox(); comboInstructor2 = new ComboBox();
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
            lblTitle.Location = new Point(230, 15); lblTitle.Text = "Course Session Form";

            splitContainer1.Location = new Point(45, 105);
            splitContainer1.Size = new Size(709, 320);
            splitContainer1.SplitterDistance = 362;

            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.Controls.AddRange(new Control[] {
                lblID, lblTitle1, lblDate, lblCourse, lblInstructor,
                txtID, txtSessionTitle, dtpDate, comboCourse, comboInstructor,
                btnDelete, btnUpdate
            });

            splitContainer1.Panel2.BackColor = Color.PeachPuff;
            splitContainer1.Panel2.Controls.AddRange(new Control[] {
                 lblTitle2, lblDate2, lblCourse2, lblInstructor2,
                 txtSessionTitle2, dtpDate2, comboCourse2, comboInstructor2,
                btnAdd
            });

            
            lblID.AutoSize = true; lblID.Location = new Point(54, 35); lblID.Text = "ID";
            lblTitle1.AutoSize = true; lblTitle1.Location = new Point(40, 70); lblTitle1.Text = "Title";
            lblDate.AutoSize = true; lblDate.Location = new Point(40, 105); lblDate.Text = "Date";
            lblCourse.AutoSize = true; lblCourse.Location = new Point(26, 145); lblCourse.Text = "Course";
            lblInstructor.AutoSize = true; lblInstructor.Location = new Point(13, 183); lblInstructor.Text = "Instructor";

            txtID.Location = new Point(107, 30); txtID.Size = new Size(224, 27);
            txtSessionTitle.Location = new Point(107, 65); txtSessionTitle.Size = new Size(224, 27);
            dtpDate.Location = new Point(107, 100); dtpDate.Size = new Size(224, 27); dtpDate.Format = DateTimePickerFormat.Short;
            comboCourse.Location = new Point(107, 140); comboCourse.Size = new Size(224, 28);
            comboInstructor.Location = new Point(107, 178); comboInstructor.Size = new Size(224, 28);

            btnDelete.BackColor = Color.Salmon; btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(88, 225); btnDelete.Size = new Size(94, 29);
            btnDelete.Text = "Delete"; btnDelete.Click += DeleteSession;

            btnUpdate.BackColor = Color.DarkGoldenrod; btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(237, 225); btnUpdate.Size = new Size(94, 29);
            btnUpdate.Text = "Update"; btnUpdate.Click += UpdateSession;

            
            lblTitle2.AutoSize = true; lblTitle2.Location = new Point(13, 70); lblTitle2.Text = "Title";
            lblDate2.AutoSize = true; lblDate2.Location = new Point(13, 105); lblDate2.Text = "Date";
            lblCourse2.AutoSize = true; lblCourse2.Location = new Point(3, 145); lblCourse2.Text = "Course";
            lblInstructor2.AutoSize = true; lblInstructor2.Location = new Point(3, 183); lblInstructor2.Text = "Instructor";

            txtSessionTitle2.Location = new Point(94, 65); txtSessionTitle2.Size = new Size(224, 27);
            dtpDate2.Location = new Point(94, 100); dtpDate2.Size = new Size(224, 27); dtpDate2.Format = DateTimePickerFormat.Short;
            comboCourse2.Location = new Point(94, 140); comboCourse2.Size = new Size(224, 28);
            comboInstructor2.Location = new Point(94, 178); comboInstructor2.Size = new Size(224, 28);

            btnAdd.BackColor = Color.SeaGreen; btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(124, 225); btnAdd.Size = new Size(94, 29);
            btnAdd.Text = "Add"; btnAdd.Click += AddSession;

            dataGrid.Location = new Point(26, 440);
            dataGrid.Size = new Size(757, 188);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.ReadOnly = true;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.AddRange(new Control[] { lblTitle, dataGrid, splitContainer1, comboSearch, btnBack });
            Name = "CourseSessionForm";
            Text = "CourseSessionForm";

            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            splitContainer1.Panel1.ResumeLayout(false); splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false); splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false); PerformLayout();
        }

        private Button btnBack, btnDelete, btnUpdate, btnAdd;
        private Label lblTitle, lblID, lblTitle1, lblDate, lblCourse, lblInstructor;
        private Label  lblTitle2, lblDate2, lblCourse2, lblInstructor2;
        private TextBox txtID, txtSessionTitle, txtSessionTitle2;
        private DateTimePicker dtpDate, dtpDate2;
        private ComboBox comboCourse, comboCourse2, comboInstructor, comboInstructor2, comboSearch;
        private DataGridView dataGrid;
        private SplitContainer splitContainer1;
    }
}