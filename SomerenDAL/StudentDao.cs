﻿using System.Collections.Generic;
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
	}
}