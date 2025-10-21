using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_14._1
{
    class Carrot : Product
    {
        public Carrot(double basePrice) : base("Carrot", basePrice) { }

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
