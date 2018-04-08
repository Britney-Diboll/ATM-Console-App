using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console_App
{
    class Saving
    {
        public double SavingAccountBalance { get; set; } = 0.00;

        public double Deposit(double savingAccountBalance, double amount)
        {
            SavingAccountBalance = savingAccountBalance + amount;

            return SavingAccountBalance;
        }
        public double Withdrawl(double savingAccountBalance, double amount)
        {
            if (amount > savingAccountBalance)
            {
                Console.WriteLine("Insufficient Funds. Please try again.");
                return SavingAccountBalance;
            }
            else
            {
                SavingAccountBalance = savingAccountBalance - amount;
                return SavingAccountBalance;
            }
        }

        public Saving()
        {

        }
    }
}
