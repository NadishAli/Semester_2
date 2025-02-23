using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Student Managment System");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Show Students");
                Console.WriteLine("3.Calculate Aggregate");
                Console.WriteLine("4.Top Students");
                Console.Write("Enter your option: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Student.addStudent();
                }
                else if (option == 2)
                {
                    Student.showStudent();
                }
                else if (option == 3)
                {
                    Student.calculateAggregate();
                }
                else if (option == 4)
                {
                    Student.topStudents();
                }
            }
        }
    }
}
