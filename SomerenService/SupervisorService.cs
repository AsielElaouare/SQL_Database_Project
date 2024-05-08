using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
	public class SupervisorService
	{
		private SupervisorDao supervisordb;
		public SupervisorService()
		{
			supervisordb = new SupervisorDao();
		}

		public List<Teacher> GetParticipatingSupervisors(int activityId)
		{
			List<Teacher> teachers = supervisordb.GetParticipatingSupervisors(activityId);
			return teachers;
		}

		public List<Teacher> GetNotParticipatingSupervisors(int activityId)
		{
			List<Teacher> teachers = supervisordb.GetNotParticipatingSupervisors(activityId);
			return teachers;
		}

		public void AddSupervisor(int supervisorId, int activityId)
		{
			supervisordb.AddSupervisorToTable(supervisorId, activityId);
		}
		public void RemoveSupervisor(int supervisorId, int ActivityId)
		{
			supervisordb.RemoveSupervisorToTable(supervisorId, ActivityId);
		}
	}
}
