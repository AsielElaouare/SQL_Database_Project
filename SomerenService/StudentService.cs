using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
	public class StudentService
	{
		private StudentDao studentdb;

		public StudentService()
		{
			studentdb = new StudentDao();
		}

		public List<Student> GetStudents()
		{
			List<Student> students = studentdb.GetAllStudents();
			return students;
		}

		public List<Student> GetParticipatingStudents(int activityId)
		{
			List<Student> students = studentdb.GetParticipatingStudents(activityId);
			return students;
		}

		public List<Student> GetNotParticipatingStudents(int activityId)
		{
			List<Student> students = studentdb.GetNotParticipatingStudents(activityId);
			return students;
		}
	}
}