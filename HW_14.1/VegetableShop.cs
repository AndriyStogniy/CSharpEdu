using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_14._1
{
    class VegetableShop
    {
        private List<Product> products = new List<Product>();

        public void AddProducts(List<Product> newProducts)
        {
            products.AddRange(newProducts);
        }

        public void PrintProductsInfo()
        {
            double total = 0;
            foreach (var product in products)
            {
                product.PrintInfo();
                total += product.GetTotalPrice();
            }
            Console.WriteLine($"Total products price: {total}");
        }
    }
}
