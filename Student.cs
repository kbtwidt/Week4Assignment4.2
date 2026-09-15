using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Week4Assignment4._2
{
    
    interface IStudentManager:IComparer<Student>
    {
        void AddStudent(Student student);
        void DeleteStudent(int studentID);

        void TopOfClass();
    }

     class Teacher:IStudentManager
    {
        public void AddStudent(Student student)
        {
            Data.studentList.Add(student);
        }

        public int Compare(Student? x, Student? y)
        {
            return y.GPA.CompareTo(x.GPA);
        }

        public void DeleteStudent(int studentID)
        {
            Student studentToDelete = null;

            foreach (Student student in Data.studentList)
            {
                if (student.SID == studentID)
                {
                    studentToDelete = student;
                    break;
                }
            }

            if (studentToDelete == null)
            {
                MessageBox.Show($"No student found with ID {studentID}.");
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete Student with ID {studentID}?",
                "Warning",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Data.studentList.Remove(studentToDelete);
            }
        }

        public void TopOfClass()
        {
            const string file = @"C:\MSSA\Files\TopStudent.txt";
            Student topStudent = Data.studentList[0];
            try
            {
                if (!File.Exists(file))
                {
                    using (StreamWriter writer = File.CreateText(file))
                    {
                        writer.WriteLine($"Student ID: {topStudent.SID}");
                        writer.WriteLine($"Name: {topStudent.Name}");
                        writer.WriteLine($"GPA: {topStudent.GPA}");
                    }
                }
                else
                {
                    MessageBox.Show("File already exists. Adding current Top of Class.");
                    using (StreamWriter writer = File.AppendText(file))
                    {
                        writer.WriteLine($"Student ID: {topStudent.SID}");
                        writer.WriteLine($"Name: {topStudent.Name}");
                        writer.WriteLine($"GPA: {topStudent.GPA}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Top student exported successfully.");
        }
    }
    internal class Student
    {
        public int SID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

    }
}
