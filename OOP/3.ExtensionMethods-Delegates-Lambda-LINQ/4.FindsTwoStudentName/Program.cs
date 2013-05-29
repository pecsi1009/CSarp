/*
    4.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
 */
using System;
using System.Linq;

namespace FindsStudentNames
{
    class Program
    {
        static void Main()
        {
            Students[] studentInfo =
            {
                new Students("Petya", "Dimitrova", 19),
                new Students("Qnko", "Petrov", 16),
                new Students("Stanimir", "Ivanov", 35),
                new Students("Ivaylo", "Banev", 40),
                new Students("Marin", "Tenev", 23)
            };

            // This is LINQ query who sort names of students, which age is between 18 and 24
            var findNames =
                from student in studentInfo
                where student.Age >= 18 && student.Age <= 24
                select student;

            // Here I print only first and last name of students
            Console.WriteLine("Students which age is between 18 and 24 are:");
            foreach (var student in findNames)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            }
        }
    }
}
