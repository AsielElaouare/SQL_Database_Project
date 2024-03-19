using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT * FROM [Lecturer]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    TeacherId = (int)dr["lecturerId"],
                    FirstName = (string)dr["firstName"],
                    LastName = (string)dr["lastName"],
                    PhoneNumber = (string)dr["phoneNumber"],
                    RoomId = (int)dr["roomId"],
                    BirthDate = (DateTime)dr["dateOfBirth"]
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}