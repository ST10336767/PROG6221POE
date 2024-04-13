    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_PART1
{
    public class Ingredients
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double OriginalQuantity { get; set; }
        public string Unit { get; set; }

        public Ingredients(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            OriginalQuantity = quantity;
            Unit = unit;
        }

       
    }
}
