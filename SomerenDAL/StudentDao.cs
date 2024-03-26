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
        private SqlConnection dbConnection;

        public void UpdateStudent(Student student)
        {
            try
            {
                dbConnection.Open();
                SqlCommand command = new SqlCommand("UPDATE Student SET firstname=@firstname, lastname=@lastname, studentNumber=@studentNumber, phoneNumber=@phoneNumber," +
                    "studentClass=@studentClass, roomId=@roomId Where studentId=@studentId", dbConnection);
                command.Parameters.AddWithValue("@studentId", student.studentId);
                command.Parameters.AddWithValue("@firstName", student.firstName);
                command.Parameters.AddWithValue("@lastName", student.lastName);
                command.Parameters.AddWithValue("@studentNumber", student.studentNumber);
                command.Parameters.AddWithValue("@phoneNumber", student.phoneNumber);
                command.Parameters.AddWithValue("@studentClass", student.studentClass);
                command.Parameters.AddWithValue("@roomId", student.roomId);


                command.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Can not connect to the database");
            }
            finally
            {
                dbConnection.Close();
            }
        }


        public void AddStudent(Student student)
        {
            try
            {
                dbConnection.Open();
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Student (firstName, lastName, studentNumber, phoneNumber, studentClass, roomId) " +
                    "VALUES (@firstName, @Lastname, @studentNumber, @phoneNumber, @studentClass, @roomId);", dbConnection);
                command.Parameters.AddWithValue("@studentId", student.studentId);
                command.Parameters.AddWithValue("@firstName", student.firstName);
                command.Parameters.AddWithValue("@lastName", student.lastName);
                command.Parameters.AddWithValue("@studentNumber", student.studentNumber);
                command.Parameters.AddWithValue("@phoneNumber", student.phoneNumber);
                command.Parameters.AddWithValue("@studentClass", student.studentClass);
                command.Parameters.AddWithValue("@roomId", student.roomId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Can not connect to the database: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void DeleteStudent(Student student)
        {
            try
            {
                dbConnection.Open();
                SqlCommand command = new SqlCommand("DELETE From Student WHERE studentId = @studentId", dbConnection);
                command.Parameters.AddWithValue("@studentId", student.studentId);
                command.ExecuteNonQuery();
            }


            catch
            {
                throw new Exception("Can not connect to the database");
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}