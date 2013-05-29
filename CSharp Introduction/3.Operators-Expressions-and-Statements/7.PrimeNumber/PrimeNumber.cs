using System;

class PrimeNumber
{
    static void Main()
    {
        double a = 58.3d;
        double result1 = ((a % 1) + (a / a));
        bool result = (result1 == 1);

        if (result)
        {
            Console.WriteLine("The nmuber is prime");
        }
        else
        {
            Console.WriteLine("The number is not prime.");
        }
    }
}