/* 
    Define abstract class Human with first name and last name. 
 */

namespace HumanClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Human
    {
        public string firstName;
        public string lastName;  //fields

        public Human(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
        //properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
         public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
    }
}
