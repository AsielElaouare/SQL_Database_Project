using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
	public class OrderDao : BaseDao
	{
		public List<Order> GetAllOrders()
		{
			string query = "SELECT orderId, quantity, drinkId, studentId FROM [Order] ORDER BY orderDate";
			SqlParameter[] sqlParameters = new SqlParameter[0];
			return ReadTables(ExecuteSelectQuery(query, sqlParameters));
		}

		private List<Order> ReadTables(DataTable dataTable)
		{
			List<Order> orders = new List<Order>();

			foreach (DataRow dr in dataTable.Rows)
			{
				Order order = new Order()
				{
					OrderId = (int)dr["orderId"],
					Quantity = (int)dr["quantity"],
					DrinkId = (int)dr["drinkId"],
					StudentId = (int)dr["studentId"],
				};
				orders.Add(order);
			}
			return orders;
		}

		public void AddOrder(Order order)
		{
			// Construct the SQL query to insert an order into the database
			string query = "INSERT INTO [order] (quantity, drinkId, StudentId, OrderDate) VALUES ( @quantity, @drinkId, @StudentId, @OrderDate)";

			// Define the SQL parameters
			SqlParameter[] sqlParameters =
			{
				new SqlParameter("@StudentId", order.StudentId),
				new SqlParameter("@drinkId", order.DrinkId),
				new SqlParameter("@quantity", order.Quantity),
				new SqlParameter("@OrderDate", order.OrderDate)
			};

			ExecuteEditQuery(query, sqlParameters);
		}
	}
}
