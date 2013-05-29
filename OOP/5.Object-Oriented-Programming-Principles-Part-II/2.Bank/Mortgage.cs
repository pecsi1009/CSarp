using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* -----------------------------------------------------------------------
A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
All accounts have customer, balance and interest rate (monthly based).All accounts can calculate their interest amount for a given
period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
 
-------------------------------------------------------------------------*/
namespace Bank
{
    public class Mortgage : Account, IDepositable
    {
        //field
        private int MortgagePeriod;
        //constructor
        public Mortgage(Customer kindOfCustomer, decimal balance, decimal interestRate, int mortgagePeriod)
            : base(kindOfCustomer, balance, interestRate)
        {
            this.MortgagePeriod = mortgagePeriod;
        }
        //overrite methods
        public override void Deposit(decimal money)
        {
            this.Balance += money;
        }
        //Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
        public override decimal CalculateInterest()
        {
            if (this.MortgagePeriod<=12 && this.KindOfCustomer is Companies)
            {
                return this.InterestRate / 2 * this.MortgagePeriod;
            }
            else if (this.MortgagePeriod<=6 && this.KindOfCustomer is Individuals)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * this.MortgagePeriod;
            }
        }
    }
}

