using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int TeacherId { get; set; }     // database id
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; } // LecturerNumber, e.g. 47198
        public int RoomId { get; set; }

        public DateTime BirthDate { get; set; }
        public byte IsDeleted { get; set; }


        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - BirthDate.Year;
                if (BirthDate.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}