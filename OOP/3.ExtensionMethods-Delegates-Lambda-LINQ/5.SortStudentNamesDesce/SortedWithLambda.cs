/*
    5.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first
name and last name in descending order. Rewrite the same with LINQ.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortStudentNamesDescending
{
    class SortedWithLambda
    { 
        static void Main()
        {
            Students[] studentsNames=
            {
                new Students("Marin","Tenev"),
                new Students("Boiko","Krastanov"),
                new Students("Ivet","Lalova"),
                new Students("Maria","Petrova"),
                new Students("Ani","Pencheva")
            };

            //Using the extension methods with lambda expressions
            var studentInfo = studentsNames.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.Lastname);

            foreach (var student in studentInfo)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.Lastname);
            }   
        }
    }
}
