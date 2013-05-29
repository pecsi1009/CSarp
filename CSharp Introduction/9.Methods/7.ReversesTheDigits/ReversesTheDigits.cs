using System;

class ReversesTheDigits
{
    static void Main()
    {
        Console.Write("Enter digit:");
        int digit = int.Parse(Console.ReadLine());

        if (digit > 0)
        {
            Console.WriteLine(ReverseDigit(digit));
        }
        else
        {
            digit = digit * (-1);
            Console.WriteLine("-{0}", ReverseDigit(digit));
        }
    }

    private static int ReverseDigit(int digit)
    {
        int reversedDigit = 0;
        while (digit > 0)
        {
            reversedDigit = (reversedDigit * 10) + (digit % 10);
            digit /= 10;
        }
        return reversedDigit;
    }
}


