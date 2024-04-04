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
        public List<Teacher> GetAllSupervisors()
        {
            string query = "SELECT  lecturerId, activityId, firstname, lastname, activityId FROM lecturer AS L JOIN LecturerParticipant AS LP ON LP.lecturertId = L.lecturerID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTableSupervisors(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Teacher> GetRemovedSupervisors(int activityId)
        {
            string query = "SELECT L.lecturerId, L.firstname, L.lastname, LP.activityId FROM lecturer AS L LEFT JOIN LecturerParticipant AS LP ON L.lecturerId = LP.lecturertId WHERE activityId is null OR activityId != @ActivityId;";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ActivityId", activityId)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTableSupervisors(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    FirstName = (string)dr["firstName"],
                    LastName = (string)dr["lastName"],
                    ActivityId = (int)dr["activityId"],
                    TeacherId = (int)dr["lecturerId"]
                };
                teachers.Add(teacher);
            }
            return teachers;
        }


        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> supervisors = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher supervisor = new Teacher()
                {
                    FirstName = (string)dr["firstname"],
                    LastName = (string)dr["lastname"],
                    TeacherId = (int)dr["lecturerId"]
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
        public void RemoveSupervisorToTable(int supervisorId, int activityId)
        {
            string query = "DELETE FROM LecturerParticipant WHERE LecturertId = @Id AND activityId = @ActivityId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Id", supervisorId),
                new SqlParameter("@ActivityId", activityId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
