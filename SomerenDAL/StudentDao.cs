using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;
using System.Data.Common;

namespace SomerenDAL
{
	public class StudentDao : BaseDao
	{
		public List<Student> GetAllStudents()
		{
			string query = "SELECT * FROM [Student]";
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
					studentId = (int)dr["studentId"],
					firstName = dr["firstName"].ToString(),
					lastName = dr["lastName"].ToString(),
                    studentNumber = (int)dr["studentNumber"],
                    phoneNumber = dr["phoneNumber"].ToString(),
					studentClass = dr["studentClass"].ToString(),
                    roomId = (int)dr["roomId"],
                };
				students.Add(student);
			}
			return students;
		}

        
        public void UpdateStudent(Student student)
        {
                string command = "UPDATE Student SET firstname=@firstname, lastname=@lastname, studentNumber=@studentNumber, phoneNumber=@phoneNumber," +
                    "studentClass=@studentClass, roomId=@roomId Where studentId=@studentId";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@studentId", student.studentId);
            sqlParameters[1] = new SqlParameter("@firstName", student.firstName);
            sqlParameters[2] = new SqlParameter("@lastName", student.lastName);
            sqlParameters[3] = new SqlParameter("@studentNumber", student.studentNumber);
            sqlParameters[4] = new SqlParameter("@phoneNumber", student.phoneNumber);
            sqlParameters[5] = new SqlParameter("@studentClass", student.studentClass);
            sqlParameters[6] = new SqlParameter("@roomId", student.roomId);
            ExecuteEditQuery(command, sqlParameters);
        }


        public void AddStudent(Student student)
        {
            string command = "INSERT INTO Student (firstName, lastName, studentNumber, phoneNumber, studentClass, roomId) " +
                    "VALUES (@firstName, @Lastname, @studentNumber, @phoneNumber, @studentClass, @roomId);";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@studentId", student.studentId);
            sqlParameters[1] = new SqlParameter("@firstName", student.firstName);
            sqlParameters[2] = new SqlParameter("@lastName", student.lastName);
            sqlParameters[3] = new SqlParameter("@studentNumber", student.studentNumber);
            sqlParameters[4] = new SqlParameter("@phoneNumber", student.phoneNumber);
            sqlParameters[5] = new SqlParameter("@studentClass", student.studentClass);
            sqlParameters[6] = new SqlParameter("@roomId", student.roomId);
            ExecuteEditQuery(command, sqlParameters);
          

            
        }

        public void DeleteStudent(Student student)
        {

            string command = "DELETE From Student WHERE studentId = @studentId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@studentId", student.studentId);
            ExecuteEditQuery(command, sqlParameters);
            
        }
    }
}