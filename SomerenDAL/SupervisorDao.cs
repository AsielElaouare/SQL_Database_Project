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
    public  class SupervisorDao : BaseDao
    {
        public List<Supervisor> GetAllSupervisors()
        {
            string query = "SELECT lecturertId, activityId FROM [lecturerparticipant]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> supervisors = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisor supervisor = new Supervisor()
                {
                    SupervisorId = (int)dr["lecturertId"],
                    ActivityId = (int)dr["activityId"],
                };
                supervisors.Add(supervisor);
            }
            return supervisors;
        }

        public void AddSupervisorToTable(int activityId, int supervisorId)
        {
            string query = "INSERT INTO LecturerParticipant(LecturertId, ActivityId) VALUES (@LecturerId, @ActivityId)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ActivityId", activityId),
                new SqlParameter("@LecturerId", supervisorId),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void RemoveSupervisorToTable(int supervisorId)
        {
            string query = "DELETE FROM LecturerParticipant WHERE LecturertId = @Id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Id", supervisorId),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
