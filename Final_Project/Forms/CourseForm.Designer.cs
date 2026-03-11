namespace Final_Project
{
    partial class CourseForm
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
            lblDuration = new Label();
            lblDept = new Label();
            lblInstructor = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtDuration = new TextBox();
            comboDept = new ComboBox();
            comboInstructor = new ComboBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            lblName2 = new Label();
            lblDuration2 = new Label();
            lblDept2 = new Label();
            lblInstructor2 = new Label();
            txtName2 = new TextBox();
            txtDuration2 = new TextBox();
            comboDept2 = new ComboBox();
            comboInstructor2 = new ComboBox();
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
            lblTitle.Font = new Font("Segoe UI", 25F);
            lblTitle.Location = new Point(270, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(264, 57);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Course Form";
           
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(26, 430);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(757, 188);
            dataGrid.TabIndex = 1;
           
            splitContainer1.Location = new Point(45, 105);
            splitContainer1.Name = "splitContainer1";
            
            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.Controls.Add(lblID);
            splitContainer1.Panel1.Controls.Add(lblName);
            splitContainer1.Panel1.Controls.Add(lblDuration);
            splitContainer1.Panel1.Controls.Add(lblDept);
            splitContainer1.Panel1.Controls.Add(lblInstructor);
            splitContainer1.Panel1.Controls.Add(txtID);
            splitContainer1.Panel1.Controls.Add(txtName);
            splitContainer1.Panel1.Controls.Add(txtDuration);
            splitContainer1.Panel1.Controls.Add(comboDept);
            splitContainer1.Panel1.Controls.Add(comboInstructor);
            splitContainer1.Panel1.Controls.Add(btnDelete);
            splitContainer1.Panel1.Controls.Add(btnUpdate);
           
            splitContainer1.Panel2.BackColor = Color.PeachPuff;
            splitContainer1.Panel2.Controls.Add(lblName2);
            splitContainer1.Panel2.Controls.Add(lblDuration2);
            splitContainer1.Panel2.Controls.Add(lblDept2);
            splitContainer1.Panel2.Controls.Add(lblInstructor2);
            splitContainer1.Panel2.Controls.Add(txtName2);
            splitContainer1.Panel2.Controls.Add(txtDuration2);
            splitContainer1.Panel2.Controls.Add(comboDept2);
            splitContainer1.Panel2.Controls.Add(comboInstructor2);
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
            
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
           
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(23, 105);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(67, 20);
            lblDuration.TabIndex = 2;
            lblDuration.Text = "Duration";
           
            lblDept.AutoSize = true;
            lblDept.Location = new Point(10, 140);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(89, 20);
            lblDept.TabIndex = 3;
            lblDept.Text = "Department";
          
            lblInstructor.AutoSize = true;
            lblInstructor.Location = new Point(13, 178);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(71, 20);
            lblInstructor.TabIndex = 4;
            lblInstructor.Text = "Instructor";
            
         
            txtID.Location = new Point(107, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(224, 27);
            txtID.TabIndex = 5;
            
            txtName.Location = new Point(107, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 27);
            txtName.TabIndex = 6;
            
            txtDuration.Location = new Point(107, 100);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(224, 27);
            txtDuration.TabIndex = 7;
            
            comboDept.Location = new Point(107, 135);
            comboDept.Name = "comboDept";
            comboDept.Size = new Size(224, 28);
            comboDept.TabIndex = 8;
            
            comboInstructor.Location = new Point(107, 170);
            comboInstructor.Name = "comboInstructor";
            comboInstructor.Size = new Size(224, 28);
            comboInstructor.TabIndex = 9;
           
            btnDelete.BackColor = Color.Salmon;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(88, 218);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += DeleteCourse;
            
            btnUpdate.BackColor = Color.DarkGoldenrod;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(237, 218);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += UpdateCourse;
            
            lblName2.AutoSize = true;
            lblName2.Location = new Point(13, 70);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(49, 20);
            lblName2.TabIndex = 0;
            lblName2.Text = "Name";
             
            lblDuration2.AutoSize = true;
            lblDuration2.Location = new Point(3, 105);
            lblDuration2.Name = "lblDuration2";
            lblDuration2.Size = new Size(67, 20);
            lblDuration2.TabIndex = 1;
            lblDuration2.Text = "Duration";
            
            lblDept2.AutoSize = true;
            lblDept2.Location = new Point(3, 140);
            lblDept2.Name = "lblDept2";
            lblDept2.Size = new Size(89, 20);
            lblDept2.TabIndex = 2;
            lblDept2.Text = "Department";
            
            lblInstructor2.AutoSize = true;
            lblInstructor2.Location = new Point(3, 178);
            lblInstructor2.Name = "lblInstructor2";
            lblInstructor2.Size = new Size(71, 20);
            lblInstructor2.TabIndex = 3;
            lblInstructor2.Text = "Instructor";
           
            txtName2.Location = new Point(94, 65);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(224, 27);
            txtName2.TabIndex = 4;
           
            txtDuration2.Location = new Point(94, 100);
            txtDuration2.Name = "txtDuration2";
            txtDuration2.Size = new Size(224, 27);
            txtDuration2.TabIndex = 5;
            
            comboDept2.Location = new Point(94, 135);
            comboDept2.Name = "comboDept2";
            comboDept2.Size = new Size(224, 28);
            comboDept2.TabIndex = 6;
            
            comboInstructor2.Location = new Point(94, 170);
            comboInstructor2.Name = "comboInstructor2";
            comboInstructor2.Size = new Size(224, 28);
            comboInstructor2.TabIndex = 7;
            
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(124, 218);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += AddCourse;
           
            comboSearch.Location = new Point(83, 33);
            comboSearch.Name = "comboSearch";
            comboSearch.Size = new Size(151, 28);
            comboSearch.TabIndex = 3;
            comboSearch.SelectedIndexChanged += comboSearch_SelectedIndexChanged;
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 645);
            Controls.Add(lblTitle);
            Controls.Add(dataGrid);
            Controls.Add(splitContainer1);
            Controls.Add(comboSearch);
            Controls.Add(btnBack);
            Name = "CourseForm";
            Text = "CourseForm";
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
        private Label lblTitle, lblID, lblName, lblDuration, lblDept, lblInstructor;
        private Label  lblName2, lblDuration2, lblDept2, lblInstructor2;
        private TextBox txtID, txtName, txtDuration;
        private TextBox  txtName2, txtDuration2;
        private ComboBox comboDept, comboDept2, comboInstructor, comboInstructor2, comboSearch;
        private DataGridView dataGrid;
        private SplitContainer splitContainer1;
    }
}