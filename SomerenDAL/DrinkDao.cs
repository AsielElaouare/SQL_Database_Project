using SomerenModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SomerenDAL
{
	public class DrinkDao : BaseDao
	{
		public List<Drink> GetAllDrinks()
		{
			string query = "SELECT Drink.drinkId, Drink.[name], Drink.price, Drink.alcoholic, Drink.stock, SUM([Order].quantity) AS Sold FROM Drink LEFT JOIN [Order] ON [Order].drinkId = Drink.drinkId GROUP BY Drink.drinkId, Drink.[name], Drink.price, Drink.alcoholic, Drink.stock ORDER BY [name]";
			SqlParameter[] sqlParameters = new SqlParameter[0];
			return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
		}

		private List<Drink> ReadDrinks(DataTable datatable)
		{
			List<Drink> drinks = new List<Drink>();

			foreach (DataRow dr in datatable.Rows)
			{
				Drink drink = new Drink()
				{
					Id = (int)dr["drinkId"],
					Name = dr["name"].ToString(),
					Price = (decimal)dr["price"],
					isAlcoholic = (bool)dr["alcoholic"],
					Stock = (int)dr["stock"]
				};

				drinks.Add(drink);
			}
			if (drinks.Count == 0)
				throw new Exception("There are no drinks left");

			return drinks;
		}

		private SqlConnection dbConnection;

		public DrinkDao()
		{
			string connString = ConfigurationManager.
				ConnectionStrings["SomerenDatabase"].ConnectionString;
			dbConnection = new SqlConnection(connString);
		}


		public void UpdateDrink(Drink drink)
		{
			try
			{
				dbConnection.Open();
				SqlCommand command = new SqlCommand("UPDATE Drink SET Name=@name, Stock=@stock, Price=@price, Alcoholic=@alcoholic Where drinkId=@drinkId", dbConnection);
				command.Parameters.AddWithValue("@drinkId", drink.Id);
				command.Parameters.AddWithValue("@name", drink.Name);
				command.Parameters.AddWithValue("@stock", drink.Stock);
				command.Parameters.AddWithValue("@price", drink.Price);
				command.Parameters.AddWithValue("@alcoholic", drink.isAlcoholic);

				command.ExecuteNonQuery();
			}
			catch
			{
				throw new Exception("Can not connect to the database");
			}
			finally
			{
				dbConnection.Close();
			}
		}


		public void AddDrink(Drink drink)
		{
			try
			{
				dbConnection.Open();
				SqlCommand command = new SqlCommand(
					"INSERT INTO Drink (name, alcoholic, price, stock) " +
					"VALUES (@name, @alcoholic, @price, @stock);", dbConnection);
				command.Parameters.AddWithValue("@drinkId", drink.Id);
				command.Parameters.AddWithValue("@name", drink.Name);
				command.Parameters.AddWithValue("@alcoholic", drink.isAlcoholic);
				command.Parameters.AddWithValue("@price", drink.Price);
				command.Parameters.AddWithValue("@stock", drink.Stock);
				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw new Exception("Can not connect to the database: " + ex.Message);
			}
			finally
			{
				dbConnection.Close();
			}
		}

		public void DeleteDrink(Drink drink)
		{
			try
			{
				dbConnection.Open();
				SqlCommand command = new SqlCommand("DELETE From Drink WHERE drinkId = @drinkId", dbConnection);
				command.Parameters.AddWithValue("@drinkId", drink.Id);
				command.ExecuteNonQuery();
			}
			catch
			{
				throw new Exception("Can not connect to the database");
			}
			finally
			{
				dbConnection.Close();
			}
		}
	}
}
