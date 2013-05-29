using System;
using System.Text;

namespace Bank
{
    public class Individual : Customer
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int EGN { get; set; }

        public Individual(string firstName, string lastName, string egn)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EGN = egn;
        }
    }
}
