using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofKurtovoKonare
{
    class Mortgage:Acount
    {
        public Mortgage(Customers customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
 
        }

        public override decimal CalculateInterest(decimal months)
        {
            if ((months >= 12 && this.Customer == Customers.company) ||
            (months >= 6) && this.Customer == Customers.individial)
            {
                return (this.Balance * (1 + this.InterestRate * months)) / 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
