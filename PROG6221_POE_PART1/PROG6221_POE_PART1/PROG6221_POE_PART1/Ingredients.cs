    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_PART1
{
    public class Ingredients
    {
        public string Name;
        public double Quantity;
        public double OriginalQuantity;
        public string Unit;

        public Ingredients(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            OriginalQuantity = quantity;
            Unit = unit;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetQuantity()
        {
            return Quantity;
        }

        public string GetUnit()
        {
            return Unit;
        }

        public void SetQuantity(double quantity)
        {
            Quantity = quantity;
        }

        public void setOriginalQuantity()
        {
            Quantity = OriginalQuantity;
        }

       
    }
}
