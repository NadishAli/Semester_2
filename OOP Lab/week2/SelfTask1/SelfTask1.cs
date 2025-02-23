using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTask1
{
    internal class SelfTask1
    {
        static void Main(string[] args)
        {
            Transection transection1= new Transection();
            transection1.productName = "Milk";
            transection1.transectionID = "01";
            transection1.amount = "100";
            transection1.date = "12-01-2024";
            transection1.time = "12:30";
            Transection transection2= new Transection(transection1);
            transection2.productName = "Eggs";
            transection2.transectionID = "02";
            Console.WriteLine("Transection 1 details");
            Console.WriteLine("Transection ID :" + transection1.transectionID);
            Console.WriteLine("Product Name:"+transection1.productName);
            Console.WriteLine("Amount :" + transection1.amount);
            Console.WriteLine("Date :"+transection1.date);
            Console.WriteLine("Time :"+transection1.time);
            
            Console.WriteLine("Transection 2 Details");
            Console.WriteLine("Transection ID :" + transection2.transectionID);
            Console.WriteLine("Product Name :" + transection2.productName);
            Console.WriteLine("Amount :" + transection2.amount);
            Console.WriteLine("Date :" + transection2.date);
            Console.WriteLine("Time :" + transection2.time);
        }
    }
}
