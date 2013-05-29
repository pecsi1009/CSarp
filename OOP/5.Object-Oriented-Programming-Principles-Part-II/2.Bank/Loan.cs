using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* -----------------------------------------------------------------------
A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
All accounts have customer, balance and interest rate (monthly based).Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows:
number_of_months * interest_rate.Loan accounts have no interest for the first 3 months if are held by individuals and for the first
2 months if are held by a company.


-------------------------------------------------------------------------*/
namespace Bank
{
    public class Loan : Account, IDepositable
    {
        //field
        private int loanPeriod;

        //constructor
        public Loan(Customer kindOfCustomer, decimal balance, decimal interestRate, int loanPeriod)
            : base(kindOfCustomer, balance, interestRate)
        {
            this.loanPeriod = loanPeriod;
        }
        //methods
        public override void Deposit(decimal money)
        {
             this.Balance += money;
        }
        //Loan accounts have no interest for the first 3 months if are held by individuals and for the first
        //2 months if are held by a company.
        public override decimal CalculateInterest()
        {
            if (this.loanPeriod<=3 && SomeCustomer is Individuals)
            {
                return 0;
            }
            else if (this.loanPeriod<=2 && SomeCustomer is Companies)
            {
                return 0;
            }
            else
            {
                return this.loanPeriod * this.InterestRate;
            }   
        }
    }
}
