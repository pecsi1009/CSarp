// Define new class Student which is derived from Human and has new field – grade

namespace HumanClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : Human
    {
        private int grade; // field 

        public Student(string fName, string lName, int grade)
            :base(fName,lName)
        {
            this.Grade = grade;
        }
        public int Grade //property
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
        public override string ToString()
        {
            string result = string.Format("Student Name: {0} {1}", this.firstName, this.lastName) + Environment.NewLine;
            result = result + string.Format("   Grade: {0}", this.grade);
            return result;
        }
    }
}
