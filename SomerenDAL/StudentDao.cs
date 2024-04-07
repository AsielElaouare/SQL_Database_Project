using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
	public class StudentDao : BaseDao
	{
		public List<Student> GetAllStudents()
		{
			string query = "SELECT studentId, firstName, lastName, phoneNumber, studentNumber, studentClass FROM [Student]";
			return ReadTables(ExecuteSelectQuery(query));
		}

		public List<Student> GetParticipatingStudents(int activityId)
		{
			string query = "SELECT s.studentId, s.studentNumber, s.firstName, s.lastName FROM [Student] s JOIN [studentParticipant] p ON s.studentId = p.studentId WHERE p.activityId = @activityId";
			SqlParameter[] sqlParameters = new SqlParameter[1];
			sqlParameters[0] = new SqlParameter("@activityId", activityId);
			return ReadParticipantTables(ExecuteSelectQuery(query, sqlParameters));
		}

		public List<Student> GetNotParticipatingStudents(int activityId)
		{
			string query = "SELECT s.studentId, s.studentNumber, s.firstName, s.lastName FROM [Student] s WHERE s.studentId NOT IN (SELECT p.studentId FROM [studentParticipant] p WHERE p.activityId = @activityId)";
			SqlParameter[] sqlParameters = new SqlParameter[1];
			sqlParameters[0] = new SqlParameter("@activityId", activityId);
			return ReadParticipantTables(ExecuteSelectQuery(query, sqlParameters));
		}

		private List<Student> ReadTables(DataTable dataTable)
		{
			List<Student> students = new List<Student>();

			foreach (DataRow dr in dataTable.Rows)
			{
				Student student = new Student()
				{
					studentNumber = (int)dr["studentNumber"],
                    firstName = dr["firstName"].ToString(),
					lastName = dr["lastName"].ToString(),
					phoneNumber = dr["phoneNumber"].ToString(),
					studentClass = dr["studentClass"].ToString(),
				};
				students.Add(student);
			}
			return students;
		}

		private List<Student> ReadParticipantTables(DataTable dataTable)
		{
			List<Student> students = new List<Student>();

			foreach (DataRow dr in dataTable.Rows)
			{
				Student student = new Student()
				{
					studentId = (int)dr["studentId"],
					studentNumber = (int)dr["studentNumber"],
					firstName = dr["firstName"].ToString(),
					lastName = dr["lastName"].ToString()
				};
				students.Add(student);
			}
			return students;
		}

		public void AddParticipant(int activityId, int studentId)
		{
			string query = "INSERT INTO [studentParticipant] (activityId, studentId) VALUES (@activityId, @studentId)";
			SqlParameter[] sqlParameters = new SqlParameter[2];
			sqlParameters[0] = new SqlParameter("@activityId", activityId);
			sqlParameters[1] = new SqlParameter("@studentId", studentId);
			ExecuteEditQuery(query, sqlParameters);
		}

		public void RemoveParticipant(int activityId, int studentId)
		{
			string query = "DELETE FROM [studentParticipant] WHERE activityId = @activityId AND studentId = @studentId";
			SqlParameter[] sqlParameters = new SqlParameter[2];
			sqlParameters[0] = new SqlParameter("@activityId", activityId);
			sqlParameters[1] = new SqlParameter("@studentId", studentId);
			ExecuteEditQuery(query, sqlParameters);
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