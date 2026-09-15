using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace Week4Assignment4._2
{
    public partial class TeacherForm : Form
    {
        private IStudentManager teacher;
        public TeacherForm()
        {
            InitializeComponent();
            teacher = new Teacher();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            StudentDataGrid.DataSource = Data.studentList;
            lblSID.Hide();
            lblName.Hide();
            lblGPA.Hide();
            txtSID.Hide();
            txtName.Hide();
            txtGPA.Hide();
            btnAddSubmit.Hide();
            btnDeleteSubmit.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblSID.Show();
            lblName.Show();
            lblGPA.Show();
            txtSID.Show();
            txtName.Show();
            txtGPA.Show();
            btnAddSubmit.Show();
            btnDeleteSubmit.Hide();
        }

        private void btnAddSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtSID.Text != string.Empty)
            {
                var newStudent = new Student();
                newStudent.SID = int.Parse(txtSID.Text);
                newStudent.Name = txtName.Text;
                newStudent.GPA = float.Parse(txtGPA.Text);
                Data.studentList.Add(newStudent);
                StudentDataGrid.DataSource = null;
                StudentDataGrid.DataSource = Data.studentList;
                var result = MessageBox.Show($"{newStudent.Name} added. Would you like to add another student?: ", "Information", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtSID.Clear();
                    txtName.Clear();
                    txtGPA.Clear();
                }
                else
                {
                    lblSID.Hide();
                    lblName.Hide();
                    lblGPA.Hide();
                    txtSID.Hide();
                    txtName.Hide();
                    txtGPA.Hide();
                    btnAddSubmit.Hide();
                }
            }
            else
            {
                if (txtName.Text == string.Empty)
                    MessageBox.Show("Please enter a name for the student.");
                else if (txtSID.Text == string.Empty)
                    MessageBox.Show("Please enter a Student ID for the student.");
            }
        }

        private void txtSID_Validating(object sender, CancelEventArgs e)
        {
            if (txtSID.TextLength != 0)
            {
                int val;
                if (!int.TryParse(txtSID.Text, out val))
                {
                    MessageBox.Show("Please enter numbers only.");
                    e.Cancel = true;
                    txtSID.Clear();
                }
                else if (int.Parse(txtSID.Text) <= 0)
                {
                    MessageBox.Show("Please enter only non-negative numbers.");
                    e.Cancel = true;
                    txtSID.Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblSID.Show();
            txtSID.Show();
            btnDeleteSubmit.Show();
            lblName.Hide();
            txtName.Hide();
            lblGPA.Hide();
            txtGPA.Hide();
            btnAddSubmit.Hide();
            txtSID.Clear();
        }

        private void btnDeleteSubmit_Click(object sender, EventArgs e)
        {
            int studentID;
            if (!int.TryParse(txtSID.Text, out studentID))
            {
                MessageBox.Show("Enter a valid Student ID.");
                return;
            }
            teacher.DeleteStudent(studentID);
            StudentDataGrid.DataSource = null;
            StudentDataGrid.DataSource = Data.studentList;

            var result = MessageBox.Show("Would you like to delete another Student?", "Information", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
            {
                lblSID.Hide();
                txtSID.Hide();
                btnDeleteSubmit.Hide();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Data.studentList.Sort(teacher);
            teacher.TopOfClass();
            StudentDataGrid.DataSource = null;
            StudentDataGrid.DataSource = Data.studentList;
        }
    }
}
