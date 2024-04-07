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
        List<Teacher> Teachers;
        public UpdateTeacherForm()
        {
            InitializeComponent();
            TeacherService = new TeacherService();

            Teachers = TeacherService.GetTeachers();
            foreach(Teacher teacher in Teachers)
            {
                IdComboBox.Items.Add(teacher.TeacherId);
            }
        }

        private void IdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int teacherId = (int)IdComboBox.SelectedItem;

            Teacher teacher = TeacherService.GetTeacherById(teacherId);

            FirstNameTxt.Text = teacher.FirstName;
            LastNameTxt.Text = teacher.LastName;
            PhonenumberTxt.Text = teacher.PhoneNumber;
            BirthDatePicker.Value = teacher.BirthDate;
            Roomtxt.Text = teacher.RoomId.ToString();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int teacherId = (int)IdComboBox.SelectedItem;
            string firstName = FirstNameTxt.Text;
            string lastName = LastNameTxt.Text;
            string phoneNumber = PhonenumberTxt.Text;
            DateTime birthDate = BirthDatePicker.Value;
            Room room = new Room();
            room.roomId = int.Parse(Roomtxt.Text);

            Teacher UpdatedTeacher = new Teacher
            {
                TeacherId = teacherId,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                BirthDate = birthDate,
                RoomId = room.roomId
            };
                
            
            TeacherService.UpdateTeacher(UpdatedTeacher);

            MessageBox.Show("Teacher updated!");
        }
    }
}
