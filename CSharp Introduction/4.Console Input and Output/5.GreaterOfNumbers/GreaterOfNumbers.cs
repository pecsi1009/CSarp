using System;

class GreaterOfNumbers
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number:");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is:{0}",Math.Max(number1,number2));
    }
}

