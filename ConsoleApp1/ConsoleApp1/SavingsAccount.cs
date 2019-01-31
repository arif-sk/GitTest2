using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SavingsAccount:BankAccount
    {
        public double InterestAmount { get; set; }
        public override double CalculateInterest()
        {
            return base.CalculateInterest();
        }
    }
}
