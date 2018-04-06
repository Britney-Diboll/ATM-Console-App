using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console_App
{
    class Checking
    {
        public string CAccountNumber { get; }
        public string CAccountBalance { get; }

        public Checking(string caccountnumber, string caccountbalance)
        {
            CAccountNumber = caccountnumber;
            CAccountBalance = caccountbalance;
        }
    }


}
