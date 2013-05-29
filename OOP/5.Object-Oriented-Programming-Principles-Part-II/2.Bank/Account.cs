using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* -----------------------------------------------------------------------
A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
All accounts have customer, balance and interest rate (monthly based).All accounts can calculate their interest amount for a given
period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
 
-------------------------------------------------------------------------*/
namespace Bank
{
    public class Account : IDepositable
    {
        //fiels with properties
        private Customer KindOfCustomer; //this is object from class Customer
        private decimal Balance{get; set;}
        private decimal InterestRate{get; set;}
        private int NumberOfMounths{get; set;}

        //constructor
        public Account()
        {
            this.KindOfCustomer = kindOfCustomer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.NumberOfMounths = numberOfMounts;
        }

        // virtual methods ready to be override from other Acount classes
        public virtual void DepositMoney(decimal money)
        { 
        }

        public virtual void DrowMoney(decimal money)
        {   
        }

        public virtual decimal CalculateInterestRate(decimal money)
        {
            return NumberOfMonths * this.InterestRate;
        }
    }
}
