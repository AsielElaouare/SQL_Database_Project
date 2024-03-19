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
            string query = "SELECT * FROM Drink;";
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
                    Vat = (int)dr["vat"],
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
                SqlCommand command = new SqlCommand("UPDATE Drink SET Name=@name, Stock=@stock, Price=@price Where drinkId=@drinkId", dbConnection);
                command.Parameters.AddWithValue("@drinkId", drink.Id);
                command.Parameters.AddWithValue("@name", drink.Name);
                command.Parameters.AddWithValue("@stock", drink.Stock);
                command.Parameters.AddWithValue("@price", drink.Price);

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
                "INSERT INTO Drink (drinkId, name, alcoholic, vat, price, stock)" +
                "VALUES (@drinkId, @name, @alcoholic, @vat, @price, @stock);" +
                "SELECT SCOPE_IDENTITY();", dbConnection);
                command.Parameters.AddWithValue("@DrinksId", drink.Id);
                command.Parameters.AddWithValue("@Name", drink.Name);
                command.Parameters.AddWithValue("@Type", drink.isAlcoholic);
                command.Parameters.AddWithValue("@Vat", drink.Vat);
                command.Parameters.AddWithValue("@Price", drink.Price);
                command.Parameters.AddWithValue("@Stock", drink.Stock);
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
