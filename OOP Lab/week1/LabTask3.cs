using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the first num: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second num: ");
            num2 = int.Parse(Console.ReadLine());
            int result= add(num1, num2);
            Console.WriteLine(result);
        }
        static int add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
