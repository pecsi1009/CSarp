using System;


class TwoIntNumber
{
    static void Main()
    {
        int result = 0;
        Console.Write("Enter first number:");
        uint number1 = uint.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        uint number2 = uint.Parse(Console.ReadLine());

        while (number1 <= number2)
        {
            number1++;

            if (number1 % 5 == 0)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
 }


