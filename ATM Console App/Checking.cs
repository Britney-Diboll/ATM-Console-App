using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console_App
{

    /* in this account set account balance to starting amount
     * be able to access current amount and add to it (deposit) 
     * save new current amount
     * be able to access current amount and subtract from it (withdraw)
     * save new current amount 
    */

    class Checking
    {
        public double CheckingAccountBalance { get; set; } = 0.00;

        public double Deposit(double checkingAccountBalance, double amount)
        {
            CheckingAccountBalance = checkingAccountBalance + amount;

            return CheckingAccountBalance;
        }


        public double Withdrawl(double checkingAccountBalance, double amount)
        {
            if (amount > checkingAccountBalance)
            {
                Console.WriteLine("Insufficient Funds. Please try again.");
                return CheckingAccountBalance;
            }
            else
            {
                CheckingAccountBalance = checkingAccountBalance - amount;
                return CheckingAccountBalance;
            }
        }

 
    }


}
