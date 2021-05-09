using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class FormStudents : Form
    {
        private List<Student> students = new List<Student>();

        public FormStudents()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStudents_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var file = sfd.FileName;
            }

        }

        private void FormStudents_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            string name = tbFullName.Text;

            string studentID = tbStudentId.Text;

            int age = Convert.ToInt32(tbAge.Text);

            string course = tbCourse.Text;

            bool enrolled = cbEnrolled.Checked;


            Student newStudent = new Student(name, studentID, age, course, enrolled);
            students.Add(newStudent);


        }
    }
}
