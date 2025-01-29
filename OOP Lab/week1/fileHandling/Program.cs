using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Semester_2\\OOP Lab\\task.txt";
            if (File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                string record;
                while ((record = filevariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                filevariable.Close();
            }
            else
            {
                Console.WriteLine("File not Exist");
            }
        }
    }
}
