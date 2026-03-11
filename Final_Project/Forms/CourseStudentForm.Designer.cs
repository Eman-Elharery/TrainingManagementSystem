namespace Final_Project
{
    partial class CourseStudentForm
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
            pnlAdd = new Panel();
            lblCourse2 = new Label(); lblStudent2 = new Label();
            comboCourse2 = new ComboBox(); comboStudent2 = new ComboBox();
            btnAdd = new Button();
            pnlDelete = new Panel();
            lblCourse = new Label(); lblStudent = new Label();
            comboCourse = new ComboBox(); comboStudent = new ComboBox();
            btnDelete = new Button();

            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            pnlAdd.SuspendLayout();
            pnlDelete.SuspendLayout();
            SuspendLayout();

            btnBack.Location = new Point(26, 32); btnBack.Size = new Size(39, 29);
            btnBack.Text = "<"; btnBack.Click += btnBack_Click;

            lblTitle.AutoSize = true; lblTitle.Font = new Font("Segoe UI", 25F);
            lblTitle.Location = new Point(230, 15); lblTitle.Text = "Course Student Form";

            pnlDelete.BackColor = SystemColors.ActiveCaption;
            pnlDelete.Location = new Point(45, 105);
            pnlDelete.Size = new Size(362, 180);

            lblCourse.AutoSize = true; lblCourse.Location = new Point(26, 35); lblCourse.Text = "Course";
            lblStudent.AutoSize = true; lblStudent.Location = new Point(18, 80); lblStudent.Text = "Student";

            comboCourse.Location = new Point(107, 30); comboCourse.Size = new Size(224, 28);
            comboStudent.Location = new Point(107, 75); comboStudent.Size = new Size(224, 28);

            btnDelete.BackColor = Color.Salmon; btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(88, 125); btnDelete.Size = new Size(94, 29);
            btnDelete.Text = "Delete"; btnDelete.Click += DeleteCourseStudent;

            pnlDelete.Controls.AddRange(new Control[] { lblCourse, lblStudent, comboCourse, comboStudent, btnDelete });

            pnlAdd.BackColor = Color.PeachPuff;
            pnlAdd.Location = new Point(418, 105);
            pnlAdd.Size = new Size(340, 180);

            lblCourse2.AutoSize = true; lblCourse2.Location = new Point(13, 35); lblCourse2.Text = "Course";
            lblStudent2.AutoSize = true; lblStudent2.Location = new Point(3, 80); lblStudent2.Text = "Student";

            comboCourse2.Location = new Point(94, 30); comboCourse2.Size = new Size(210, 28);
            comboStudent2.Location = new Point(94, 75); comboStudent2.Size = new Size(210, 28);

            btnAdd.BackColor = Color.SeaGreen; btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(110, 125); btnAdd.Size = new Size(94, 29);
            btnAdd.Text = "Add"; btnAdd.Click += AddCourseStudent;

            pnlAdd.Controls.AddRange(new Control[] { lblCourse2, lblStudent2, comboCourse2, comboStudent2, btnAdd });

            dataGrid.Location = new Point(26, 310);
            dataGrid.Size = new Size(757, 250);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.ReadOnly = true;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 590);
            Controls.AddRange(new Control[] { lblTitle, dataGrid, pnlDelete, pnlAdd, btnBack });
            Name = "CourseStudentForm";
            Text = "CourseStudentForm";

            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            pnlAdd.ResumeLayout(false); pnlAdd.PerformLayout();
            pnlDelete.ResumeLayout(false); pnlDelete.PerformLayout();
            ResumeLayout(false); PerformLayout();
        }

        private Button btnBack, btnDelete, btnAdd;
        private Label lblTitle, lblCourse, lblStudent, lblCourse2, lblStudent2;
        private ComboBox comboCourse, comboCourse2, comboStudent, comboStudent2;
        private DataGridView dataGrid;
        private Panel pnlAdd, pnlDelete;
    }
}