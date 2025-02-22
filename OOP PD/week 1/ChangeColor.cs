using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Name is Nadish.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("My Name is Nadish.");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("My Name is Nadish.");
            Console.ForegroundColor= ConsoleColor.White;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("My Name is Nadish.");
            Console.BackgroundColor= ConsoleColor.Green;
            Console.WriteLine("My Name is Nadish.");
            Console.BackgroundColor=ConsoleColor.Black;
        }
    }
}
