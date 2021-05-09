namespace StudentManagementSystem
{
    partial class FormStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudents));
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewAllStudents = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbStudentId = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSudentID = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbCourse = new System.Windows.Forms.Label();
            this.cbEnrolled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStudent.Location = new System.Drawing.Point(516, 91);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(260, 51);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add record";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnViewAllStudents
            // 
            this.btnViewAllStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewAllStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewAllStudents.Location = new System.Drawing.Point(516, 277);
            this.btnViewAllStudents.Name = "btnViewAllStudents";
            this.btnViewAllStudents.Size = new System.Drawing.Size(260, 51);
            this.btnViewAllStudents.TabIndex = 12;
            this.btnViewAllStudents.Text = "View All";
            this.btnViewAllStudents.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteStudent.Location = new System.Drawing.Point(516, 182);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(260, 51);
            this.btnDeleteStudent.TabIndex = 11;
            this.btnDeleteStudent.Text = "Delete record";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(516, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(283, 56);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Save and Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(114, 182);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(282, 31);
            this.tbFullName.TabIndex = 1;
            // 
            // tbStudentId
            // 
            this.tbStudentId.Location = new System.Drawing.Point(114, 221);
            this.tbStudentId.Name = "tbStudentId";
            this.tbStudentId.Size = new System.Drawing.Size(282, 31);
            this.tbStudentId.TabIndex = 2;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(114, 277);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(282, 31);
            this.tbAge.TabIndex = 3;
            // 
            // tbCourse
            // 
            this.tbCourse.Location = new System.Drawing.Point(114, 320);
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.Size = new System.Drawing.Size(282, 31);
            this.tbCourse.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(1, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Full Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSudentID
            // 
            this.lbSudentID.AutoSize = true;
            this.lbSudentID.BackColor = System.Drawing.Color.MistyRose;
            this.lbSudentID.Location = new System.Drawing.Point(1, 227);
            this.lbSudentID.Name = "lbSudentID";
            this.lbSudentID.Size = new System.Drawing.Size(100, 25);
            this.lbSudentID.TabIndex = 3;
            this.lbSudentID.Text = "Student ID:";
            this.lbSudentID.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.BackColor = System.Drawing.Color.MistyRose;
            this.lbAge.Location = new System.Drawing.Point(1, 277);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(48, 25);
            this.lbAge.TabIndex = 3;
            this.lbAge.Text = "Age:";
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.BackColor = System.Drawing.Color.MistyRose;
            this.lbCourse.Location = new System.Drawing.Point(1, 323);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(71, 25);
            this.lbCourse.TabIndex = 3;
            this.lbCourse.Text = "Course:";
            this.lbCourse.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbEnrolled
            // 
            this.cbEnrolled.AutoSize = true;
            this.cbEnrolled.BackColor = System.Drawing.Color.MistyRose;
            this.cbEnrolled.Location = new System.Drawing.Point(143, 371);
            this.cbEnrolled.Name = "cbEnrolled";
            this.cbEnrolled.Size = new System.Drawing.Size(102, 29);
            this.cbEnrolled.TabIndex = 14;
            this.cbEnrolled.Text = "Enrolled";
            this.cbEnrolled.UseVisualStyleBackColor = false;
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbEnrolled);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbSudentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCourse);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbStudentId);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnViewAllStudents);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddStudent);
            this.DoubleBuffered = true;
            this.Name = "FormStudents";
            this.Text = "Student Maintenance System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStudents_FormClosing);
            this.Load += new System.EventHandler(this.FormStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewAllStudents;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbStudentId;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbCourse;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSudentID;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.CheckBox cbEnrolled;
    }
}

