/*
    3.Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
Use LINQ query operators. 
 */
using System;
using System.Linq;
using System.Text;

namespace ComareStudentsNames
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Students(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        static void Main()
        {
            // here I make array of student's names
            Students[] studentsArr = 
            {
                new Students("Kiril", "Ivanov"),
                new Students("Petya","Petrova"),
                new Students("Ani", "Kirova"),
                new Students("Iva", "Stankova")
            };
            //LINQ query to compare students name

            var compareClass =
                from student in studentsArr
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            // here I print result of compare- only students whose first name is before its last name alphabetically
            foreach (var student in compareClass)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    } 
}
