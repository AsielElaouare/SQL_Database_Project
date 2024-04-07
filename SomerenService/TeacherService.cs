using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class TeacherService
    {

        private TeacherDao teacherdb;

        public TeacherService()
        {
            teacherdb = new TeacherDao();
        }
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = teacherdb.GetAllTeachers();
            return teachers;
        }
        public Teacher GetTeacherById(int id)
        {
            return teacherdb.GetTeacherById(id);
        }
        public Teacher AddTeacher(Teacher teacher)
        {
            return teacherdb.AddTeacher(teacher);
        }

        public Teacher UpdateTeacher(Teacher teacher)
        {
            return teacherdb.UpdateTeacher(teacher);
        }
    }
}
