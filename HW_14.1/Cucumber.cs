using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_14._1
{
    class Cucumber : Product
    {
        public double Count { get; private set; }

        public Cucumber(double basePrice, double count) : base("Cucumber", basePrice)
        {
            Count = count;
        }

        public override double GetTotalPrice()
        {
            return BasePrice * Count;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {BasePrice}, Count: {Count}, Total price: {GetTotalPrice()}");
        }
    }
}
