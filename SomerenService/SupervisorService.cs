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
        private SupervisorDao supervisorDb;
        public SupervisorService()
        {
            supervisorDb = new SupervisorDao();
        }
        public List<Teacher> GetSupervisors(int activityId)
        {
            List<Teacher> supervisors = supervisorDb.GetAllSupervisors(activityId);
            return supervisors;
        }

        public List<Teacher> GetNotParticipatingSupervisor(int activityId)
        {
            List<Teacher> supervisors = supervisorDb.GetNotParticipatingSupervisors(activityId);
            return supervisors;
        }

        public void AddSupervisor(int activityId, int supervisorId)
        {
            supervisorDb.AddSupervisorToTable(activityId, supervisorId);
        }
        public void RemoveSupervisor(int supervisorId, int activityId)
        {
            supervisorDb.RemoveSupervisoFromTable(supervisorId, activityId);
        }
    }
}
