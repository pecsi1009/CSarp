/*
    2.Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */
using System;
using System.Collections.Generic;

namespace ExtensionMethodsForIEnumerableT
{
    public static class ExtensionsMethods
    {
        // this is methods for Sum of numbers of List in Main
        public static T Sum<T>(this IEnumerable<T> list)
        {
            dynamic sum = 0; //no type dinamic we can't collect numbers of type T.That's why we use it for sum. 
            foreach (var item in list)
            {
                sum += item;
            }
            return sum;
        }
        // this is methods for Sum of numbers of List in Main
        public static T Product<T>(this IEnumerable<T> list)
        {
            dynamic product = 1;
            foreach (var item in list)
            {
                product *= item;
            }
            return product;
        }
        // this is methods for Max numbers in List in Main
        public static T Max<T>(this IEnumerable<T> list) where T : IComparable
        {
            dynamic max = decimal.MinValue;
            foreach (var item in list)
            {
                if (item > max)
                {
                    max = item;
                }
               continue;
            }
            return max;
        }
        // This methods is for finding min number in list on Main method.
        public static T Min<T>(this IEnumerable<T> list) where T : IComparable
        {
            dynamic min = decimal.MaxValue;
            foreach (var item in list)
            {
                if (item < min)
                {
                    min = item;
                }
                continue;
            }
            return min;
        }
        // this is methods for Average of numbers in List in Main method
        public static T Average<T>(this IEnumerable<T> list)
        {
            dynamic sum = 0;
            dynamic divisor = 0;
            foreach (var item in list)
            {
                sum += item;
                divisor ++;
            }
            T average = sum/divisor; 
            return average;
        }

        static void Main()
        {
            List<decimal> numList = new List<decimal> { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("sum ={0} ",numList.Sum<decimal>());
            Console.WriteLine("product = {0}",numList.Product<decimal>());
            Console.WriteLine("max number = {0}", numList.Max<decimal>());
            Console.WriteLine("min number = {0}", numList.Min<decimal>());
            Console.WriteLine("average = {0}", numList.Average<decimal>());
        }
    }
}