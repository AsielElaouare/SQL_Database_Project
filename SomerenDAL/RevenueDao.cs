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
    public class RevenueDao : BaseDao
    {
        public Revenue GetRevenueByDate(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT SUM(o.quantity) AS sales, SUM(d.price * o.quantity) AS turnover, COUNT(Distinct o.studentId) AS NOC FROM drink as d INNER JOIN [order] as o ON d.drinkId = o.drinkId WHERE orderdate BETWEEN  @startdate AND @enddate";
            SqlParameter[] sqlParameters =
            {

            new SqlParameter("@startdate", startDate),
            new SqlParameter("@enddate", endDate)

            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private Revenue ReadTables(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0) 
                return new Revenue();
            
            DataRow dr = dataTable.Rows[0];

            return new Revenue()
            {
                Sales = Convert.IsDBNull(dr["sales"]) ? 0 : (int)dr["sales"],
                Turnover = Convert.IsDBNull(dr["turnover"]) ? 0 : (decimal)dr["turnover"],
                NumberOfCustomers = Convert.IsDBNull(dr["NOC"]) ? 0 : (int)dr["NOC"]
            };
        }
    }
}