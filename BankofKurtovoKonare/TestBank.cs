
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofKurtovoKonare
{
    class TestBank
    {
        static void Main(string[] args)
        {
            Loan loanDepOne = new Loan(Customers.company, 50000, 24);
            Loan loanDepTwo = new Loan(Customers.individial, 2500, 6);
            Loan loanDepThree = new Loan(Customers.company, 23000, 36);
            Loan loanDepFour = new Loan(Customers.individial, 500, 6);

            Mortgage morDepOne = new Mortgage(Customers.company, 50000, 24);
            Mortgage morDepTwo = new Mortgage(Customers.individial, 2500, 6);
            Mortgage morDepThree = new Mortgage(Customers.company, 23000, 36);
            Mortgage morDepFour = new Mortgage(Customers.individial, 500, 6);

            Deposit depDepOne = new Deposit(Customers.company, 50000, 24);
            Deposit depDepTwo = new Deposit(Customers.individial, 2500, 6);
            Deposit depDepThree = new Deposit(Customers.company, 23000, 36);
            Deposit depDepFour = new Deposit(Customers.individial, 500, 6);

            IList<Acount> acounts = new List<Acount>()
            {
                loanDepOne,
                loanDepTwo,
                loanDepThree,
                loanDepFour,
                morDepOne,
                morDepTwo,
                morDepThree,
                morDepFour,
                depDepOne,
                depDepTwo,
                depDepThree,
                depDepFour};

            foreach (var acount in acounts)
            {
                Console.WriteLine(acount.GetType().Name+" --> Interests:{0} ", acount.CalculateInterest(12));
            }


        }
    }
}

