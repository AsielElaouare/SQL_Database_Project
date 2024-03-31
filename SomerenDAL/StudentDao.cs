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
			string query = "SELECT firstName, lastName, phoneNumber, studentNumber, studentClass FROM [Student]";
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
	}
}