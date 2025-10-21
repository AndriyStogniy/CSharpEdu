using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_14._1
{
    abstract class Product
    {
        public string Name { get; protected set; }
        protected double BasePrice;

        public Product(string name, double basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }

        public abstract double GetTotalPrice();

        public abstract void PrintInfo();
    }
}
