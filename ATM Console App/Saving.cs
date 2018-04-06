using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console_App
{
    class Saving
    {
        public string SAccountNumber { get; }
        public string SAccountBalance { get; }

        public Saving(string saccountnumber, string saccountbalance)
        {
            SAccountNumber = saccountnumber;
            SAccountBalance = saccountbalance;
        }
    }
}
