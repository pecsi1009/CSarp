using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* -----------------------------------------------------------------------
A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
All accounts have customer, balance and interest rate (monthly based).Deposit accounts are allowed to deposit and with draw money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows:
number_of_months * interest_rate.Deposit accounts have no interest if their balance is positive and less than 1000.


-------------------------------------------------------------------------*/
namespace Bank
{
    public class Deposit : Account, IDrowable
    {
        //field
        private int DepositPeriod{get; set;};

        //constructor
        public Deposit(Customer kindOfCustomer, decimal balance, decimal interestRate)
            :base(kindOfCustomer, balance, interestRate)
        {
            this.DepositPeriod = depositPeriod;
 
        }
        //methods
        //Deposit accounts have no interest if their balance is positive and less than 1000.
        public override void Deposit(decimal money)
        {
            this.Balance += money;
        }
        public override void Drow(decimal money)
        {
            if (this.Balance > money)
            {
                this.Balance -= money;
            }
            else
            {
                throw new Exception("You don't have enought money in the account");
            }
        }
        public override decimal CalculateInterest()
        {
            if (this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return this.DepositPeriod * this.InterestRate;
            }
        }
    }
}
