using System;

namespace SomerenModel
{
    public class Student
    {
        public int student_id { get; set; }     // database id
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public int studentnummer { get; set; } // StudentNumber, e.g. 474791


        public int telefoonnummer { get; set; }
        public string klas { get; set; }
    }
}