namespace Final_Project
{
    partial class CourseSessionAttendanceForm
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
            lblGrade = new Label();
            lblNotes = new Label();
            lblSession = new Label();
            lblStudent = new Label();
            txtID = new TextBox();
            txtGrade = new TextBox();
            txtNotes = new TextBox();
            comboSession = new ComboBox();
            comboStudent = new ComboBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            lblGrade2 = new Label();
            lblNotes2 = new Label();
            lblSession2 = new Label();
            lblStudent2 = new Label();
            txtGrade2 = new TextBox();
            txtNotes2 = new TextBox();
            comboSession2 = new ComboBox();
            comboStudent2 = new ComboBox();
            btnAdd = new Button();
            comboSearch = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            
            btnBack.Location = new Point(26, 32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(39, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "<";
            btnBack.Click += btnBack_Click;
            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(252, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(426, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Course Session Attendance";
            
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(26, 440);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(757, 188);
            dataGrid.TabIndex = 1;
           
            splitContainer1.Location = new Point(45, 105);
            splitContainer1.Name = "splitContainer1";
            
            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.Controls.Add(lblID);
            splitContainer1.Panel1.Controls.Add(lblGrade);
            splitContainer1.Panel1.Controls.Add(lblNotes);
            splitContainer1.Panel1.Controls.Add(lblSession);
            splitContainer1.Panel1.Controls.Add(lblStudent);
            splitContainer1.Panel1.Controls.Add(txtID);
            splitContainer1.Panel1.Controls.Add(txtGrade);
            splitContainer1.Panel1.Controls.Add(txtNotes);
            splitContainer1.Panel1.Controls.Add(comboSession);
            splitContainer1.Panel1.Controls.Add(comboStudent);
            splitContainer1.Panel1.Controls.Add(btnDelete);
            splitContainer1.Panel1.Controls.Add(btnUpdate);
           
            splitContainer1.Panel2.BackColor = Color.PeachPuff;
            splitContainer1.Panel2.Controls.Add(lblGrade2);
            splitContainer1.Panel2.Controls.Add(lblNotes2);
            splitContainer1.Panel2.Controls.Add(lblSession2);
            splitContainer1.Panel2.Controls.Add(lblStudent2);
            splitContainer1.Panel2.Controls.Add(txtGrade2);
            splitContainer1.Panel2.Controls.Add(txtNotes2);
            splitContainer1.Panel2.Controls.Add(comboSession2);
            splitContainer1.Panel2.Controls.Add(comboStudent2);
            splitContainer1.Panel2.Controls.Add(btnAdd);
            splitContainer1.Size = new Size(709, 310);
            splitContainer1.SplitterDistance = 362;
            splitContainer1.TabIndex = 2;
             
            lblID.AutoSize = true;
            lblID.Location = new Point(54, 35);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
             
            
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(37, 70);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(49, 20);
            lblGrade.TabIndex = 1;
            lblGrade.Text = "Grade";
           
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(37, 105);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(48, 20);
            lblNotes.TabIndex = 2;
            lblNotes.Text = "Notes";
            
            lblSession.AutoSize = true;
            lblSession.Location = new Point(18, 143);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(58, 20);
            lblSession.TabIndex = 3;
            lblSession.Text = "Session";
            
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(18, 183);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(60, 20);
            lblStudent.TabIndex = 4;
            lblStudent.Text = "Student";
            
            txtID.Location = new Point(107, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(224, 27);
            txtID.TabIndex = 5;
            
            txtGrade.Location = new Point(107, 65);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(224, 27);
            txtGrade.TabIndex = 6;
            
            txtNotes.Location = new Point(107, 100);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(224, 27);
            txtNotes.TabIndex = 7;
            
            comboSession.Location = new Point(107, 138);
            comboSession.Name = "comboSession";
            comboSession.Size = new Size(224, 28);
            comboSession.TabIndex = 8;
           
            comboStudent.Location = new Point(107, 178);
            comboStudent.Name = "comboStudent";
            comboStudent.Size = new Size(224, 28);
            comboStudent.TabIndex = 9;
            
            btnDelete.BackColor = Color.Salmon;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(88, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += DeleteAttendance;
             
            btnUpdate.BackColor = Color.DarkGoldenrod;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(237, 225);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += UpdateAttendance;
            
            lblGrade2.AutoSize = true;
            lblGrade2.Location = new Point(13, 70);
            lblGrade2.Name = "lblGrade2";
            lblGrade2.Size = new Size(49, 20);
            lblGrade2.TabIndex = 0;
            lblGrade2.Text = "Grade";
            
            lblNotes2.AutoSize = true;
            lblNotes2.Location = new Point(13, 105);
            lblNotes2.Name = "lblNotes2";
            lblNotes2.Size = new Size(48, 20);
            lblNotes2.TabIndex = 1;
            lblNotes2.Text = "Notes";
             
            lblSession2.AutoSize = true;
            lblSession2.Location = new Point(3, 143);
            lblSession2.Name = "lblSession2";
            lblSession2.Size = new Size(58, 20);
            lblSession2.TabIndex = 2;
            lblSession2.Text = "Session";
             
            lblStudent2.AutoSize = true;
            lblStudent2.Location = new Point(3, 183);
            lblStudent2.Name = "lblStudent2";
            lblStudent2.Size = new Size(60, 20);
            lblStudent2.TabIndex = 3;
            lblStudent2.Text = "Student";
            
            txtGrade2.Location = new Point(94, 65);
            txtGrade2.Name = "txtGrade2";
            txtGrade2.Size = new Size(224, 27);
            txtGrade2.TabIndex = 4;
            
            txtNotes2.Location = new Point(94, 100);
            txtNotes2.Name = "txtNotes2";
            txtNotes2.Size = new Size(224, 27);
            txtNotes2.TabIndex = 5;
             
            comboSession2.Location = new Point(94, 138);
            comboSession2.Name = "comboSession2";
            comboSession2.Size = new Size(224, 28);
            comboSession2.TabIndex = 6;
             
            comboStudent2.Location = new Point(94, 178);
            comboStudent2.Name = "comboStudent2";
            comboStudent2.Size = new Size(224, 28);
            comboStudent2.TabIndex = 7;
            
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(124, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += AddAttendance;
             
            comboSearch.Location = new Point(83, 33);
            comboSearch.Name = "comboSearch";
            comboSearch.Size = new Size(151, 28);
            comboSearch.TabIndex = 3;
            comboSearch.SelectedIndexChanged += comboSearch_SelectedIndexChanged;
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.Add(lblTitle);
            Controls.Add(dataGrid);
            Controls.Add(splitContainer1);
            Controls.Add(comboSearch);
            Controls.Add(btnBack);
            Name = "CourseSessionAttendanceForm";
            Text = "CourseSessionAttendanceForm";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnBack, btnDelete, btnUpdate, btnAdd;
        private Label lblTitle, lblID, lblGrade, lblNotes, lblSession, lblStudent;
        private Label  lblGrade2, lblNotes2, lblSession2, lblStudent2;
        private TextBox txtID, txtGrade, txtNotes, txtGrade2, txtNotes2;
        private ComboBox comboSession, comboSession2, comboStudent, comboStudent2, comboSearch;
        private DataGridView dataGrid;
        private SplitContainer splitContainer1;
    }
}