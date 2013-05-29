/* 
    2.Define abstract class Human with first name and last name. Define new class Student which is derived
from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary 
and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the 
proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by
grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort
them by money per hour in descending order. Merge the lists and sort them by first name and last name.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanClass
{
    class Program
    {
        static void Main()
        {
            // list with students
            List<Student> students = new List<Student>(10);
            Student firstStudent = new Student("Petya", "Dimitrova", 8);
            students.Add(firstStudent);
            Student secondStudent = new Student("Marin", "Tenev", 2);
            students.Add(secondStudent);
            Student thirdStudent = new Student("Ivaylo","Banev", 3);
            students.Add(thirdStudent);
            Student fourthStudent = new Student("Nevena", "Petrova", 3);
            students.Add(fourthStudent);
            Student fifthStudent = new Student("Elena", "Apostolova", 3);
            students.Add(fifthStudent);
            Student sixthStudent = new Student("Kiril", "Ivanov", 2);
            students.Add(sixthStudent);
            Student seventhStudent = new Student("Hristina", "Hristova", 5);
            students.Add(seventhStudent);
            Student eightStudent = new Student("Yanko", "Dimitrov", 5);
            students.Add(eightStudent);
            Student ninthStudent = new Student("Peter", "Vasilev", 8);
            students.Add(ninthStudent);
            Student tenthStudent = new Student("Boyan", "Ivanov", 12);
            students.Add(tenthStudent);

            // sorted student in ascending order
            var orderedStudents = students.OrderBy(x => x.Grade);
            Console.WriteLine("Ordered students:");
            foreach (Student student in orderedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.WriteLine();

            //list with workers
            List<Worker> workers = new List<Worker>(10);
            Worker firstWorker = new Worker("Petya", "Dimitrova", 200, 4);
            workers.Add(firstWorker);
            Worker secondWorker = new Worker("Marin", "Tenev", 400, 6);
            workers.Add(secondWorker);
            Worker thirdWorker = new Worker("Ivaylo", "Banev", 1200, 8);
            workers.Add(thirdWorker);
            Worker fourthWorker = new Worker("Nevena", "Petrova", 160, 2);
            workers.Add(fourthWorker);
            Worker fifthWorker = new Worker("Elena", "Apostolova", 560, 5);
            workers.Add(fifthWorker);
            Worker sixthWorker = new Worker("Kiril", "Ivanov", 329, 8);
            workers.Add(sixthWorker);
            Worker seventhWorker = new Worker("Hristina", "Hristova", 890, 10);
            workers.Add(seventhWorker);
            Worker eightWorker = new Worker("Yanko", "Dimitrov", 1358, 5);
            workers.Add(eightWorker);
            Worker ninthWorker = new Worker("Peter", "Vasilev", 738, 8);
            workers.Add(ninthWorker);
            Worker tenthWorker = new Worker("Boyan", "Ivanov", 500, 12);
            workers.Add(tenthWorker);

            // sorting workers by money per hour in descending order
            var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("Workers in descending order:");
            foreach (Worker worker in orderedWorkers)
            {
                Console.WriteLine(worker);
            }
        }
    }
}
