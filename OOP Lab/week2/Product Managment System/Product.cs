using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Managment_System
{
    internal class Product
    {
        static List<Product> products = new List<Product>();
        public int ID;
        public string Name;
        public int price;
        public string category;
        public string brand;
        public string country;
        public Product(int ID,string Name,int price,string category,string brand,string country)
        {
            this.ID = ID;
            this.Name = Name;
            this.price = price;
            this.category = category;
            this.brand = brand;
            this.country = country;
        }
        public static void addProduct()
        {
            Console.Write("Enter the Product ID: ");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("Enter the Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the Product Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter the Product Category: ");
            string category = Console.ReadLine();
            Console.Write("Enter the Product Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Enter the Product Country: ");
            string country = Console.ReadLine();
            Product product = new Product(ID,name, price, category,brand,country);
            products.Add(product);
        }
        public static void showProducts()
        {
            Console.WriteLine("These are the following Products:");
            Console.WriteLine("Names");
            foreach(Product product in products)
            {
                Console.WriteLine(product.Name);
            }
        }
        public static void totalWorth()
        {
            int sum = 0;
            foreach(Product product in products)
            {
                sum += product.price;
            }
            Console.WriteLine("The total worth of the store is "+sum);
        }
    }
}
