namespace SortStudentNamesDescending
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Students
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public Students(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.Lastname = lastName;
        }
    }
}