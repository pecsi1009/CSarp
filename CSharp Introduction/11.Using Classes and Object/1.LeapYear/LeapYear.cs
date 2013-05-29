using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter year:");
            int year = int.Parse(Console.ReadLine());

            if (year < 1 && year > 9999)
            {
                Console.WriteLine("The year mustn't be lower than 1 and highter than 9999");
            }
            else
            {
                Console.WriteLine("The {0} is leap -> {1}", year, DateTime.IsLeapYear(year));
            }
        }
    }
}