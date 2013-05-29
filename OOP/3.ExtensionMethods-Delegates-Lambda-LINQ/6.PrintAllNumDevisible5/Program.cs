/*
    6.Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 */
using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] numbers = new int[300];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }

        //Number divide 7 and 3 when divide to 21 with lambda expressions
        var Nums = numbers.Where(x => x % 21 == 0);

        Console.WriteLine("Number divide 7 and 3 when divide to 21 with lambda expressions");
        foreach (var num in Nums)
        {
            Console.WriteLine(num);
        }

        //Number divide 7 and 3 when divide to 21 with LINQ
        var selectedNums =
        from num in numbers
        where num % 21 == 0
        select num;

        Console.WriteLine("Number divide 7 and 3 when divide to 21 with LINQ");
        foreach (var num in selectedNums)
        {
            Console.WriteLine(num);
        }
    }
}