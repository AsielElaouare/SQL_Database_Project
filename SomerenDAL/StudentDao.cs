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
	}
}