using SomerenModel;
using System;
using System.Collections;
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
            string query = "SELECT * FROM [Activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadActivities(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadActivities(DataTable datatable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in datatable.Rows)
            {
                Activity activity = new Activity()
                {

                    Id = (int)dr["activityId"],
                    Name = dr["name"].ToString(),
                    StartTime = (DateTime)dr["beginTime"],
                    EndTime = (DateTime)dr["endTime"]
                };

                activities.Add(activity);
            }
            return activities;
        }
    }
}
