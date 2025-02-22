using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int min = 0;
            int max = 100;
            int randomNumber = rnd.Next(min,max);
            Console.WriteLine("The Random Number is: "+randomNumber);
        }
    }
}
