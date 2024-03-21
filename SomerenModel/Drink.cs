﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Vat {  get; set; }
        public  bool isAlcoholic { get; set; }
        public int Stock { get; set; }
        public int Sold { get; set; }   
        public int SelectedQuantity { get; set; }



        
    }
}
