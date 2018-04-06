using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Britney's ATM. Please enter your first and last name to enter into your account. (Jane Doe is your name)");
            string input;
            input = Console.ReadLine();



            if (input == "Jane Doe")
            {
                Console.WriteLine("Thank you, please choose which account you would like to enter into?");
                Console.WriteLine("Checkings Account");
                Console.WriteLine("Savings Account");
                Console.WriteLine("Type Checking or Saving to see that account!");
                input = Console.ReadLine();
            }
            if (input == "Checking")
            {
                var checkings = new Checking("12345", "100");
                Console.WriteLine($"Your checking account number is: {checkings.CAccountNumber}");
                Console.WriteLine($"Your checking account balance is: {checkings.CAccountBalance}");
                Console.ReadLine();
                Console.WriteLine("Would you like to deposit, withdrawal or transfer (to savings) money? Please type deposit, withdrawal or transfer.");
                Console.ReadLine();
            }
            else if (input == "Saving")
            {
                var savings = new Saving("54321", "100");
                Console.WriteLine($"Your savings account number is: {savings.SAccountNumber}");
                Console.WriteLine($"Your savings account balance is: {savings.SAccountBalance}");
                Console.ReadLine();
                Console.WriteLine("Would you like to deposit, withdrawal or transfer (to checkings) money? Please type deposit, withdrawal or transfer.");
                Console.ReadLine();
            } 
        }
    }
}