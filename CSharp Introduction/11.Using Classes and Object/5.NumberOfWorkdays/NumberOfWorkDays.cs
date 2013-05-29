using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.NumberOfWorkdays
{
    class NumberOfWorkDays
    {
        static void Main()
        {
            DateTime day = DateTime.Today;
            Console.Write("Enter final date <YYYY-MM-DD>:");
            DateTime givenDay = DateTime.Parse(Console.ReadLine());

            DateTime[] holidays =
            {
                new DateTime(2013, 1, 1),
                new DateTime(2013, 3, 3),
                new DateTime(2013, 5, 1),
                new DateTime(2013, 5, 3),
                new DateTime(2013, 5, 4),
                new DateTime(2013, 5, 5),
                new DateTime(2013, 5, 6),
                new DateTime(2013, 5, 24),
                new DateTime(2013, 9, 6),
                new DateTime(2013, 9, 22),
                new DateTime(2013, 11, 1),
                new DateTime(2013, 12, 24),
                new DateTime(2013, 12, 25),
                new DateTime(2013, 12, 26),
            };

            int countDay = Math.Abs((day - givenDay).Days);

            for (int i = 0; i < countDay; i++)
            {
                DateTime currentDate = DateTime.Now.AddDays(i);

                for (int days = 0; days < holidays.Length; days++)
                {
                    int compare = currentDate.CompareTo(holidays[days]);
                    if (compare == 0)
                    {
                        countDay--;
                    }
                }
                if ((currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday))
                {
                    countDay--;
                }
            }

            PrintDays(day, givenDay, countDay);
        }

        private static void PrintDays(DateTime day, DateTime givenDay, int countDay)
        {
            Console.WriteLine("Today is: {0}", day);
            Console.WriteLine("Final Date is: {0}", givenDay);
            Console.WriteLine();
            Console.WriteLine("Working days: {0}", countDay);
        }
    }
}
