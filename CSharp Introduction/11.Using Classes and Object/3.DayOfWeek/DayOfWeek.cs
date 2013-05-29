using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("{0} is {1}", today, today.DayOfWeek);

        }
    }
}