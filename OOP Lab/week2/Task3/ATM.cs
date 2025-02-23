using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class ATM
    {
        public int balance;
        List<string> TransectionDetails = new List<string>();
        public ATM(int Balance)
        {
            this.balance = Balance; 
        }
        public void deposit(int Balance)
        {
            balance += Balance;
            string record = "Deposit " + Balance;
            TransectionDetails.Add(record);
            Console.WriteLine("The balance is successfully deposited.");
        }
        public void withdraw(int Balance)
        {
            if (Balance < balance)
            {
                balance -= Balance;
                string record = "Withdraw " + Balance;
                TransectionDetails.Add(record);
                Console.WriteLine("The balace is withdraw successfully.");
            }
            else
            {
                Console.WriteLine("You do not have sufficient balance.");
            }
        }
        public void checkBalance()
        {
            Console.WriteLine("Your current balance is: "+balance);
        }
        public void TransectionHistory()
        {
            foreach (string record in TransectionDetails)
            {
                Console.WriteLine(record);
            }
        }
    }
}
