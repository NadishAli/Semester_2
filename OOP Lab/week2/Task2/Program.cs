using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            calculator calculate = new calculator(num1, num2);
            Console.Write("Select the operation (+,-,*,/) : ");
            char function = char.Parse(Console.ReadLine());
            if (function == '+')
            {
                calculate.sum();
            }
            else if (function == '-')
            {
                calculate.subtract();
            }
            else if (function == '*')
            {
                calculate.product();
            }
            else if (function == '/')
            {
                calculate.divide();
            }
        }
    }
}
