using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT * FROM Activiteit WHERE id = @ID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter() { ParameterName = "@ID", Value = 2 };
            return ReadActivities(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadActivities(DataTable datatable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in datatable.Rows)
            {
                Activity activity = new Activity()
                {

                    Id = (int)dr["activiteit_Id"],
                    Name = dr["naam"].ToString(),
                    Date = dr["dag"].ToString(),
                    StartTime = dr["begin_Tijd"].ToString(),
                    EndTime = dr["eind_Tijd"].ToString()
                };

                activities.Add(activity);
            }
            return activities;
        }
    }
}
