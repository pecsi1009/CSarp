/*
    5.1.Sort the students by first name and last name in descending order with LINQ.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortStudentNamesDescending
{
    class SortedWithLINQ
    {
        static void Main()
        {
            Students[] studentsNames =
            {
                new Students("Marin","Tenev"),
                new Students("Boiko","Krastanov"),
                new Students("Ivet","Lalova"),
                new Students("Maria","Petrova"),
                new Students("Ani","Pencheva")
            };

            //sort the students by firstname and last name in descending order with LINQ.
            var StudentList =
                from student in studentsNames
                orderby student.FirstName descending, student.Lastname descending
                select student;

            foreach (var student in StudentList)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.Lastname);
            }
        }
    }
}

