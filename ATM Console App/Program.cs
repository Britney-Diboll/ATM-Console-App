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
                Console.WriteLine("1.Checkings Account");
                Console.WriteLine("2.Savings Account");
                Console.WriteLine("Type 1 or 2 to see that account!");
                input = Console.ReadLine();
                if(input == "1")
                {

                } else if(input == "2")
                {

                }
            } 
            else if(input != "Jane Doe")
            {
                Console.WriteLine("Please enter the correct spelling of your first and last name.");
                input = Console.ReadLine();

                if (input == "Jane Doe")
                {
                    Console.WriteLine("Thank you, please choose which account you would like to enter into?");
                    Console.ReadLine();
                }
            }
            var checkings = new Checking("12345", "100");
            Console.WriteLine($"Your checking account number is: {checkings.CAccountNumber}");
            Console.WriteLine($"Your checking account balance is: {checkings.CAccountBalance}");
            Console.ReadLine();


        }
    }
}