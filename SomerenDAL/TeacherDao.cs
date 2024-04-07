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
            string query = "SELECT lecturerId, firstName, lastName, phoneNumber, roomId, dateOfBirth FROM [Lecturer]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Teacher GetTeacherById(int teacherId)
        {
            string query = "SELECT lecturerId, firstName, lastName, phoneNumber, roomId, dateOfBirth FROM [Lecturer] WHERE lecturerId = @lecturerId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@lecturerId", teacherId)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
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
                    BirthDate = (DateTime)dr["dateOfBirth"],
                };
                teachers.Add(teacher);
            }
            return teachers;
        }

        private Teacher ReadTable(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0) return null;

            DataRow dr = dataTable.Rows[0];

            Teacher teacher = new Teacher()
            {
                TeacherId = (int)dr["lecturerId"],
                FirstName = (string)dr["firstName"],
                LastName = (string)dr["lastName"],
                PhoneNumber = (string)dr["phoneNumber"],
                RoomId = (int)dr["roomId"],
                BirthDate = (DateTime)dr["dateOfBirth"],
            };

            return teacher;
        }
        public Teacher AddTeacher(Teacher teacher)
        {
            string query = "INSERT INTO Lecturer (firstName, lastName, phoneNumber, dateOfBirth, roomId) VALUES (@firstName, @lastName, @phoneNumber, @dateOfBirth, @roomId)";
            SqlParameter[] sqlParameters =
            {
                    new SqlParameter("@firstName", teacher.FirstName),
                    new SqlParameter("@lastName", teacher.LastName),
                    new SqlParameter("@phoneNumber", teacher.PhoneNumber),
                    new SqlParameter("@dateOfBirth", teacher.BirthDate),
                    new SqlParameter("@roomId", teacher.RoomId)
            };

            ExecuteEditQuery(query, sqlParameters);
            return teacher;
        }

        public Teacher UpdateTeacher(Teacher teacher)
        {
            string query = "UPDATE Lecturer SET firstName = @firstName, lastName = @lastName, phoneNumber = @phoneNumber, dateOfBirth = @dateOfBirth, roomId = @roomId WHERE lecturerId = @lecturerId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@firstName", teacher.FirstName),
                new SqlParameter("@lastName", teacher.LastName),
                new SqlParameter("@phoneNumber", teacher.PhoneNumber),
                new SqlParameter("@dateOfBirth", teacher.BirthDate),
                new SqlParameter("@roomId", teacher.RoomId),
                new SqlParameter("@lecturerId", teacher.TeacherId)
            };

            ExecuteEditQuery(query, sqlParameters);
            return teacher;
        }
    }
}