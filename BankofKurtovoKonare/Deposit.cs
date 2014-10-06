using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofKurtovoKonare
{
    class Deposit : Acount
    {
        public Deposit(Customers customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(decimal  months)
        {
          
            if (this.Balance < 1000 && this.Balance > 0)
            {
                return this.Balance;
            }
            else
            {
                return  this.Balance * (1+ this.InterestRate * months);
                
            }
        }
        public void  WithdrawMoney(decimal money)
        {
            this.Balance -= money;
        }
    }
}