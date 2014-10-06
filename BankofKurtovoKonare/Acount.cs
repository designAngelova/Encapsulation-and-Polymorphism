using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofKurtovoKonare
{
   abstract class Acount : IAcount
    {
        private Customers customer;
        private decimal balance;
        private decimal interestRate;

        public Acount(Customers customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customers Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }
        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }


         public abstract decimal CalculateInterest(decimal months);
       

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }
    }
}
