using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofKurtovoKonare
{
    class Loan:Acount
    {
        public Loan(Customers customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { 
        }

        public override decimal CalculateInterest(decimal months)
        {
            if (this.Customer == Customers.individial)
            {
                if (months >= 3)
                {
                    months -= 3;
                }
                else
                {
                    return this.Balance;
                }
            }

            if (this.Customer == Customers.company)
            {
                if (months >= 2)
                {
                    months -= 2;
                }
                else
                {
                    return this.Balance;
                }
            }

            return (this.Balance * (1 + this.InterestRate * months));
        }
    }
}
