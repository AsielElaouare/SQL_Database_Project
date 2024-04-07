using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class UpdateTeacherForm : Form
    {
        TeacherService TeacherService;
        Teacher Teacher;
        public UpdateTeacherForm(Teacher teacher)
        {
            InitializeComponent();
            TeacherService = new TeacherService();

            Teacher = teacher;

            FirstNameTxt.Text = teacher.FirstName;
            LastNameTxt.Text = teacher.LastName;
            PhonenumberTxt.Text = teacher.PhoneNumber;
            BirthDatePicker.Value = teacher.BirthDate;
            Roomtxt.Text = teacher.RoomId.ToString();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Teacher UpdatedTeacher = new Teacher
            {
                TeacherId = Teacher.TeacherId,
                FirstName = FirstNameTxt.Text,
                LastName = LastNameTxt.Text,
                PhoneNumber = PhonenumberTxt.Text,
                BirthDate = BirthDatePicker.Value,
                RoomId = int.Parse(Roomtxt.Text)
            };
                
            
            TeacherService.UpdateTeacher(UpdatedTeacher);

            MessageBox.Show("Teacher updated!");
        }
    }
}
