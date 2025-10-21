using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_14._1
{
    class Tomato : Product
    {
        public Tomato(double basePrice) : base("Tomato", basePrice) { }

        public override double GetTotalPrice()
        {
            return BasePrice;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {BasePrice}");
        }
    }
}
