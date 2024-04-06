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

		public void AddParticipant(int activityId, int studentId)
		{
			studentdb.AddParticipant(activityId, studentId);
		}

		public void RemoveParticipant(int activityId, int studentId)
		{
			studentdb.RemoveParticipant(activityId, studentId);
		}

        public void UpdateStudent(Student student)
        {
            studentdb.UpdateStudent(student);
        }

        public void DeleteStudent(Student student)
        {
            studentdb.DeleteStudent(student);
        }

        public void AddStudent(Student student)
        {
            studentdb.AddStudent(student);
        }
    }
}