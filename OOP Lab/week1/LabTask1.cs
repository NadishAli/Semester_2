using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasklab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age, Toyprice, price, total=0, cash=10;
            int toys=0;
            Console.Write("Enter Lilly's age: ");
            age=int.Parse(Console.ReadLine());
            Console.Write("Enter the price of Washing machine: ");
            price=int.Parse(Console.ReadLine());
            Console.Write("Enter the price of the Toy: ");
            Toyprice=int.Parse(Console.ReadLine());
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    total += cash;
                    cash += 10;
                }
                else
                {
                    toys++;
                }
            }
            total += (toys * Toyprice);
            if(total>price)
            {
                Console.WriteLine("Yes you Can Buy");
            }
            else
            {
                Console.WriteLine("No You Need more money");
            }
        }
    }
}
