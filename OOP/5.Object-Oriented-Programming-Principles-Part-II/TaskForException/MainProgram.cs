﻿/*
 Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers
in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskForException
{
    class MainProgram
    {
        static void Main()
        {
            DateTime t = DateTime.Now;
            Console.WriteLine(t);
            InvalidRangeException<int> someIntExeption =
                new InvalidRangeException<int>("The have to enter a number in the range from 0 do 100!", 1, 100);
            Console.WriteLine("Enter 5 numbers from 0 do 100:");
            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < someIntExeption.Start || number > someIntExeption.End)
                {
                    throw someIntExeption;
                }
                else
                {
                    Console.WriteLine("The number is correct!");
                }
            }
            string startDate = "1/1/1980";
            string endDate = "1/1/2013";

            InvalidRangeException<DateTime> someDateExpection =
                new InvalidRangeException<DateTime>("The date isn't in the correct range from 1980 to 2013!"
                    , DateTime.Parse(startDate), DateTime.Parse(endDate));
            Console.WriteLine("Enter 5 dates in the specified format: dd.mm.yyyy!(from 1980 to 2013)");
            for (int i = 0; i < 5; i++)
            {
                string date = Console.ReadLine();
                DateTime someDate = DateTime.Parse(date);
                if (someDate.Year < someDateExpection.Start.Year || someDate.Year > someDateExpection.End.Year)
                {
                    throw someDateExpection;
                }
                else
                {
                    Console.WriteLine("The date is correct!");
                }
            }

        }
    }
}