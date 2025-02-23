using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    internal class Student
    {
        static List<Student> list = new List<Student>();
        public string name;
        public float matric;
        public float fsc;
        public float ecat;
        public float aggregate;
        public Student(string name, float matric, float fsc, float ecat)
        {
            this.name = name;
            this.matric = matric;
            this.fsc = fsc;
            this.ecat = ecat;
        }
        public static  void addStudent()
        {
            Console.Write("Enter the name of the Student: ");
            string name = Console.ReadLine();
            Console.Write("Enter the matric marks: ");
            float matric = float.Parse(Console.ReadLine());
            Console.Write("Enter the FSc marks: ");
            float fsc = float.Parse(Console.ReadLine());
            Console.Write("Enter the ecat marks: ");
            float ecat = float.Parse(Console.ReadLine());
            Student student = new Student(name,matric,fsc,ecat);
            list.Add(student);
        }
        public static void showStudent()
        {
            Console.WriteLine("Student Name");
            foreach (Student student in list)
            {
                Console.WriteLine(student.name);
            }
        }
        public static void calculateAggregate()
        {
            Console.WriteLine("Student Name" + "    " + "Student Aggregate");
            foreach (Student student in list)
            {
                student.aggregate = ((student.matric / 1100) * 10 + (student.fsc / 1200) * 40 + (student.ecat / 400) * 50);
                Console.WriteLine(student.name + "    " + student.aggregate);
            }
        }
        public static void topStudents()
        {
            List<float> aggre = new List<float>();
            foreach(Student student in list)
            {
                float aggregate = student.aggregate;
                aggre.Add(aggregate);
            }
            aggre.Sort();
            aggre.Reverse();
            for (int i = 0; i < 3; i++)
            {
                foreach (Student student in list)
                {
                    if(student.aggregate == aggre[i])
                    {
                        Console.WriteLine(student.name);
                    }
                }
            }
        }
    }
}
