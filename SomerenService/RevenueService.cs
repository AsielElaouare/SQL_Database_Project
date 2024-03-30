using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class RevenueService
    {
        private RevenueDao revenuedb;

        public RevenueService()
        {
            revenuedb = new RevenueDao();
        }

        public Revenue GetRevenue(DateTime startDate, DateTime endDate)
        {
            Revenue revenue = revenuedb.GetRevenueByDate(startDate, endDate);

            if (revenue == null)
            {
                return new Revenue();
            }

            return revenue;
        }  
    }
}
