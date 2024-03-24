using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        

        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public int DrinkId { get; set; }

        public int StudentId { get; set; }

        public int TeacherId { get; set; }

        public DateTime OrderDate { get; set; }




    }
}
