using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Managment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Product Managment System");
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.Show Products");
                Console.WriteLine("3.Total worth");
                Console.Write("Enter your option: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Product.addProduct();
                }
                else if (option == 2)
                {
                    Product.showProducts();
                }
                else if (option == 3)
                {
                    Product.totalWorth();
                }
            }
        }
    }
}
