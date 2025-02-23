using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class calculator
    {
        public int num1;
        public int num2;
        public calculator(int x,int y) 
        {
            num1 = x;
            num2 = y;
        }
        public void sum()
        {
            int sum = num1 + num2;
            Console.WriteLine("The Sum of the numbers is: "+sum);
        }
        public void subtract()
        {
            int difference = num1 - num2; 
            Console.WriteLine("The difference of the numbers is: "+ difference);
        }
        public void product()
        {
            int product = num1 * num2;
            Console.WriteLine("The product of the numbers is: "+ product);
        }
        public void divide()
        {
            int divide = num1 / num2;
            Console.WriteLine("The division of the numbers is: " + divide);
        }
    }
}
