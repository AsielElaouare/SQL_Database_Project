using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinksService : DrinkDao
    {
        private DrinkDao drinksdb;
        DrinkDao drinksDao = new DrinkDao();

        public DrinksService()
        {
            drinksdb = new DrinkDao();
        }

        public List<Drink> GetDrink()
        {
            return drinksdb.GetAllDrinks();
        }

        public void UpdateDrink(Drink drink)
        {
            drinksDao.UpdateDrink(drink);
        }

        public void AddDrink(Drink drink)
        {
            drinksDao.AddDrink(drink);
        }
        public void DeleteDrink(Drink drink)
        {
            drinksDao.DeleteDrink(drink);
        }
    }
}
