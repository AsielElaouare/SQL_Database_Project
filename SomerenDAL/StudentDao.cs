using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT StudentId, Name FROM [Student]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    voornaam = dr["Name"].ToString(),
                    achternaam = dr["Name"].ToString(),
                    telefoonnummer = (int)dr["PhoneNumber"],
                    studentnummer = (int)dr["StudentId"],
                    klas = dr["Class"].ToString(),
                };
                students.Add(student);
            }
            return students;
        }
    }
}