using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.RandomValues
{
    class RandomValues
    {
        static void Main()
        {
            Random number = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}" + " ", number.Next(100, 201));
            }
            Console.WriteLine();
        }
    }
}
