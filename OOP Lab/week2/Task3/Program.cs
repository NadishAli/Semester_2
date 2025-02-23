using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you initial balance to continue: ");
            int cash = int.Parse(Console.ReadLine());
            ATM atm = new ATM(cash);
            while (true)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Check Transection History");
                Console.Write("Enter your option: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("Enter the amount to deposit: ");
                    int amount = int.Parse(Console.ReadLine());
                    atm.deposit(amount);
                }
                else if (option == 2)
                {
                    Console.Write("Enter the amount to withdraw: ");
                    int amount = int.Parse(Console.ReadLine());
                    atm.withdraw(amount);
                }
                else if (option == 3)
                {
                    atm.checkBalance();
                }
                else if (option == 4)
                {
                    atm.TransectionHistory();
                }
            }
        }
    }
}
