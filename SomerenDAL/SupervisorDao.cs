using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
	public class SupervisorDao : BaseDao
	{
		public List<Teacher> GetParticipatingSupervisors(int activityId)
		{
			string query = "SELECT l.lecturerId, l.firstName, l.lastName, lp.activityId FROM [lecturer] AS l JOIN [lecturerparticipant] AS lp ON l.lecturerId = lp.lecturerId WHERE activityId = @activityId";
			SqlParameter[] sqlParameters = new SqlParameter[1];
			sqlParameters[0] = new SqlParameter("@activityId", activityId);
			return ReadTables(ExecuteSelectQuery(query, sqlParameters));
		}

		public List<Teacher> GetNotParticipatingSupervisors(int activityId)
		{
			string query = "SELECT l.lecturerId, l.firstName, l.lastName FROM [lecturer] AS l WHERE l.lecturerId NOT IN (SELECT lp.lecturerId FROM LecturerParticipant AS lp WHERE lp.activityId = @activityId)";
			SqlParameter[] sqlParameters = new SqlParameter[1];
			sqlParameters[0] = new SqlParameter("@activityId", activityId);
			return ReadTables(ExecuteSelectQuery(query, sqlParameters));
		}

		public void AddSupervisorToTable(int LecturerId, int activityId)
		{
			string query = "INSERT INTO LecturerParticipant(LecturerId, ActivityId) VALUES (@LecturerId, @ActivityId)";
			SqlParameter[] sqlParameters =
			{
				new SqlParameter("@LecturerId", LecturerId),
				new SqlParameter("@ActivityId", activityId),
			};
			ExecuteEditQuery(query, sqlParameters);
		}

		public void RemoveSupervisorToTable(int LecturerId, int ActivityId)
		{
			string query = "DELETE FROM LecturerParticipant WHERE LecturerId = @LecturerId AND ActivityId = @ActivityId";
			SqlParameter[] sqlParameters =
			{
				new SqlParameter("@LecturerId", LecturerId),
				new SqlParameter("@ActivityId", ActivityId)
			};
			ExecuteEditQuery(query, sqlParameters);
		}

		private List<Teacher> ReadTables(DataTable dataTable)
		{
			List<Teacher> supervisors = new List<Teacher>();

			foreach (DataRow dr in dataTable.Rows)
			{
				Teacher supervisor = new Teacher()
				{
					TeacherId = (int)dr["lecturerId"],
					FirstName = dr["firstName"].ToString(),
					LastName = dr["lastName"].ToString(),
				};
				supervisors.Add(supervisor);
			}
			return supervisors;
		}
	}
}
