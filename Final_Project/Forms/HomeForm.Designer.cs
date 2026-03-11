namespace Final_Project
{
    partial class Form1
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 64);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(261, 127);
            button1.Name = "button1";
            button1.Size = new Size(297, 74);
            button1.TabIndex = 0;
            button1.Text = "Student Table";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 64, 64);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(122, 236);
            button2.Name = "button2";
            button2.Size = new Size(176, 50);
            button2.TabIndex = 1;
            button2.Text = "Instructor Table";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 64);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(322, 236);
            button3.Name = "button3";
            button3.Size = new Size(176, 50);
            button3.TabIndex = 2;
            button3.Text = "Department Table";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 64, 64);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(322, 309);
            button4.Name = "button4";
            button4.Size = new Size(176, 50);
            button4.TabIndex = 3;
            button4.Text = "Course Student Table";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 64, 64);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(122, 309);
            button5.Name = "button5";
            button5.Size = new Size(176, 50);
            button5.TabIndex = 4;
            button5.Text = "Course Session Table";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 64, 64);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(526, 236);
            button6.Name = "button6";
            button6.Size = new Size(176, 50);
            button6.TabIndex = 5;
            button6.Text = "Course Table";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 64, 64);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(526, 309);
            button7.Name = "button7";
            button7.Size = new Size(176, 50);
            button7.TabIndex = 6;
            button7.Text = "Course Session Attendance Table";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 65);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(522, 35);
            textBox1.TabIndex = 7;
            textBox1.Text = "Please select the table you want to perform operations on";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox textBox1;
    }
}
