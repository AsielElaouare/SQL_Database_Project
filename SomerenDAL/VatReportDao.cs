using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
	public class VatReportDao : BaseDao
	{

		public VatReport GetVatReport(DateOnly startDate, DateOnly endDate)
		{
			string query = "SELECT " +
								"SUM(CASE WHEN d.alcoholic = 0 THEN o.quantity * d.price ELSE 0 END) AS VatLow, " +
								"SUM(CASE WHEN d.alcoholic = 1 THEN o.quantity * d.price ELSE 0 END) AS VatHigh " +
							"FROM " +
								"[drink] AS d " +
							"INNER JOIN " +
								"[order] AS o ON d.drinkId = o.drinkId " +
							"Where " +
								"o.orderDate >= @1 AND o.orderDate <= @2;";
			SqlParameter[] sqlParameters = new SqlParameter[2];
			sqlParameters[0] = new SqlParameter("@1", startDate.ToString("yyyy-MM-dd"));
			sqlParameters[1] = new SqlParameter("@2", endDate.ToString("yyyy-MM-dd"));
			return ReadTables(ExecuteSelectQuery(query, sqlParameters));
		}

		public List<int> GetAvailableYears()
		{
			string query = "SELECT DISTINCT YEAR(orderDate) AS years FROM [order] ORDER BY years ASC";

			return ReadYears(ExecuteSelectQuery(query, new SqlParameter[0]));
		}

		private List<int> ReadYears(DataTable dataTable)
		{
			List<int> years = new List<int>();

			if (dataTable.Rows.Count == 0) return years;

			foreach (DataRow dr in dataTable.Rows)
			{
				years.Add((int)dr["years"]);
			}

			return years;
		}

		private VatReport ReadTables(DataTable dataTable)
		{
			if (dataTable.Rows.Count == 0) return null;

			DataRow dr = dataTable.Rows[0];

			VatReport vatReport = new VatReport()
			{
				VatLow = Convert.IsDBNull(dr["VatLow"]) ? 0.00m : (decimal)dr["VatLow"] * 0.06m,
				VatHigh = Convert.IsDBNull(dr["VatHigh"]) ? 0.00m : (decimal)dr["VatHigh"] * 0.21m
			};

			return vatReport;
		}
	}
}
