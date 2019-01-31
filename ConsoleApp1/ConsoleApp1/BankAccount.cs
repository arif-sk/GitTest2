using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BankAccount
    {
        public string AccountNo { get; set; }
        public string AccountsName { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }

        public virtual double CalculateInterest()
        {
            
        }
    }
}
