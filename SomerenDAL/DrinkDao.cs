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

			return drinks;
		}




		public void UpdateDrink(Drink drink)
		{
			string command = "UPDATE Drink SET Name=@name, Stock=@stock, Price=@price, Alcoholic=@alcoholic Where drinkId=@drinkId";
			SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@drinkId", drink.Id);
            sqlParameters[1] = new SqlParameter("@name", drink.Name);
			sqlParameters[2] = new SqlParameter("@stock", drink.Stock);
			sqlParameters[3] = new SqlParameter("@price", drink.Price);
			sqlParameters[4] = new SqlParameter("@alcoholic", drink.isAlcoholic);
			ExecuteEditQuery(command, sqlParameters);
		}



		public void AddDrink(Drink drink)
		{
			string command = "INSERT INTO Drink (name, alcoholic, price, stock) VALUES (@name, @alcoholic, @price, @stock);";
			SqlParameter[] sqlParameters = new SqlParameter[5];
			sqlParameters[0] = new SqlParameter("@drinkId", drink.Id);
			sqlParameters[1] = new SqlParameter("@name", drink.Name);
			sqlParameters[2] = new SqlParameter("@alcoholic", drink.isAlcoholic);
			sqlParameters[3] = new SqlParameter("@price", drink.Price);
			sqlParameters[4] = new SqlParameter("@stock", drink.Stock);
			ExecuteEditQuery(command, sqlParameters);
		}



		public void DeleteDrink(Drink drink)
		{
			string command = "DELETE From Drink WHERE drinkId = @drinkId";
			SqlParameter[] sqlParameters = new SqlParameter[1];
			sqlParameters[0] = new SqlParameter("@drinkId", drink.Id);
			ExecuteEditQuery(command, sqlParameters);
		}
	}
}
