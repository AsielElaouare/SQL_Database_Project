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

		public List<Supervisor> GetParticipatingSupervisors(int activityId)
		{
			List<Supervisor> supervisor = supervisordb.GetParticipatingSupervisors(activityId);
			return supervisor;
		}

		public List<Supervisor> GetNotParticipatingSupervisors(int activityId)
		{
			List<Supervisor> supervisor = supervisordb.GetNotParticipatingSupervisors(activityId);
			return supervisor;
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
