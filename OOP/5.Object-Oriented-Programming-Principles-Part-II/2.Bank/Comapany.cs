using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class Comapany : Customer
    {
        private string ComapnyName { get; set; }
        private int Bulstat { get; set; }

        public Comapany(string companyName, int bulstat)
        {
            this.ComapnyName = companyName;
            this.Bulstat = bulstat;
        }
    }
}
