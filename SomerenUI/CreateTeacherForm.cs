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
    public partial class CreateTeacherForm : Form
    {
        TeacherService TeacherService;
        public CreateTeacherForm()
        {
            InitializeComponent();

            TeacherService = new TeacherService();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTxt.Text;
            string lastName = LastNameTxt.Text;
            string phoneNumber = PhonenumberTxt.Text;
            DateTime birthDate = BirthDatePicker.Value;
            Room room = new Room();
            room.roomId = int.Parse(Roomtxt.Text);

            Teacher newTeacher = new Teacher
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                BirthDate = birthDate,
                RoomId = room.roomId
            };

            TeacherService.AddTeacher(newTeacher);

            FirstNameTxt.Text = "";
            LastNameTxt.Text = "";
            PhonenumberTxt.Text = "";
            BirthDatePicker.Value = DateTime.Today;
            Roomtxt.Text = "";

            MessageBox.Show("Teacher added!");
        }
    }
}
