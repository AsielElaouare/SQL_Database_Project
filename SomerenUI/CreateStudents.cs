using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class CreateStudents : Form
    {
        StudentService StudentService;
        public CreateStudents(Student student = null)
        {
            InitializeComponent();
            StudentService = new StudentService();

            if (student != null)
            {
                updateBtn.Visible = true;
                addStudentBtn.Visible = false;

                firstNameBox.Text = student.firstName;
                lastNameBox.Text = student.lastName;
                studentNumberBox.Text = student.studentNumber.ToString();
                phoneNumberBox.Text = student.phoneNumber.ToString();
                studentClassBox.Text = student.studentClass.ToString();
                roomBox.Text = student.roomId.ToString();
            }
            else
            {
                updateBtn.Visible = false;
                addStudentBtn.Visible = true;
            }
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();
                StudentService studentService = new StudentService();
                student.firstName = firstNameBox.Text;
                student.lastName = lastNameBox.Text;
                student.studentNumber = int.Parse(studentNumberBox.Text);
                student.phoneNumber = phoneNumberBox.Text;
                student.studentClass = studentClassBox.Text;
                student.roomId = int.Parse(roomBox.Text);
                studentService.AddStudent(student);
                MessageBox.Show($"Succesfully added: {student.firstName}");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Cannot add student: {ex.Message} ");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            StudentService studentservice = new StudentService();
            Student student = new Student()
            {
                firstName = firstNameBox.Text,
                lastName = lastNameBox.Text,
                studentNumber = int.Parse(studentNumberBox.Text),
                phoneNumber = phoneNumberBox.Text,
                studentClass = studentClassBox.Text,
                roomId = int.Parse(roomBox.Text)
            };
            studentservice.UpdateStudent(student);
        }
    }
}
