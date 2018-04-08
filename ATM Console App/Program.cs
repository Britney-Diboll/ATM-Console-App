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
            
            var input = Console.ReadLine();
            Checking account1 = new Checking();
            account1.CheckingAccountBalance = 50.00;

            Saving account2 = new Saving();
            account2.SavingAccountBalance = 20.00;

            if (input == "Jane Doe")
            {
                Console.WriteLine("Thank you, please choose one of the following number options: (type 1 or 2)");
                Console.WriteLine("1 See Checking Account Balance");
                Console.WriteLine("2 See Savings Account Balance");
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                Console.WriteLine($"Your current Checking account balance is: ${account1.CheckingAccountBalance}");
                Console.WriteLine("Would you like to make a deposit? Type deposit");
                Console.WriteLine("Would you like to make a withdrawl? Type withdrawl");
                Console.WriteLine("Would you like to transfer money to your savings account? Type transfer");
                input = Console.ReadLine();
            }
            switch (input)
            {
                case "deposit":
                    Console.WriteLine("How much money would you like to deposit?");
                    input = Console.ReadLine();
                    var amount = Int32.Parse(input);
                    account1.Deposit(account1.CheckingAccountBalance, amount);
                    Console.WriteLine($"You have successfully deposited! The new balance is ${account1.CheckingAccountBalance}");
                    Console.ReadLine();
                    break;

                case "withdrawl":
                    Console.WriteLine("How much money would you like to withdrawl?");
                    input = Console.ReadLine();
                    amount = Int32.Parse(input);
                    account1.Withdrawl(account1.CheckingAccountBalance, amount);
                    Console.WriteLine($"You have successfully withdrawn! The new balance is ${account1.CheckingAccountBalance}");
                    Console.ReadLine();
                    break;

                case "transfer":
                    Console.WriteLine("How much money would you like to transfer to your csaving account?");
                    input = Console.ReadLine();
                    amount = Int32.Parse(input);
                    if (amount > account1.CheckingAccountBalance)
                    {
                        Console.WriteLine("You have insufficient funds.");
                    }
                    else
                    {
                        account1.Withdrawl(account1.CheckingAccountBalance, amount);
                        account2.Deposit(account2.SavingAccountBalance, amount);
                        Console.WriteLine($"You have made a successful transfer. Your saving account balance is now ${account2.SavingAccountBalance}");
                        Console.WriteLine($"Your new checking account balance is ${account1.CheckingAccountBalance}");
                        Console.ReadLine();
                    }
                    break;
            }
            if (input == "2")
            {
                Console.WriteLine($"Your current Saving account balance is: ${account2.SavingAccountBalance}");
                Console.WriteLine("Would you like to make a deposit? Type deposit");
                Console.WriteLine("Would you like to make a withdrawl? Type withdrawl");
                Console.WriteLine("Would you like to transfer money to your checking account? Type transfer");
                input = Console.ReadLine();
            }
            switch (input)
            {
                case "deposit":
                    Console.WriteLine("How much money would you like to deposit?");
                    input = Console.ReadLine();
                    var amount = Int32.Parse(input);
                    account2.Deposit(account2.SavingAccountBalance, amount);
                    Console.WriteLine($"You have successfully deposited! The new balance is ${account2.SavingAccountBalance}");
                    Console.ReadLine();
                    break;

                case "withdrawl":
                    Console.WriteLine("How much money would you like to withdrawl?");
                    input = Console.ReadLine();
                    amount = Int32.Parse(input);
                    account2.Withdrawl(account2.SavingAccountBalance, amount);
                    Console.WriteLine($"You have successfully withdrawn! The new balance is ${account2.SavingAccountBalance}");
                    Console.ReadLine();
                    break;

                case "transfer":
                    Console.WriteLine("How much money would you like to transfer to your checking account?");
                    input = Console.ReadLine();
                    amount = Int32.Parse(input);
                    if (amount > account2.SavingAccountBalance)
                    {
                        Console.WriteLine("You have insufficient funds.");
                    } else
                    {
                        account2.Withdrawl(account2.SavingAccountBalance, amount);
                        account1.Deposit(account1.CheckingAccountBalance, amount);
                        Console.WriteLine($"You have made a successful transfer. Your checking account balance is now ${account1.CheckingAccountBalance}");
                        Console.WriteLine($"Your new saving account balance is ${account2.SavingAccountBalance}");
                        Console.ReadLine();
                    }
                    break;
            }
        }

    }
}