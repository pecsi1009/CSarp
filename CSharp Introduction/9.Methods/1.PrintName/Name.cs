using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.PrintName
{
    public class Name
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name :");
            string name = Console.ReadLine();

            Console.WriteLine();
            PrintName(name);
        }

        public static string PrintName(string name)
        {
            Console.WriteLine("Hello {0} !!!", name);
            return name;
        }
    }
}
