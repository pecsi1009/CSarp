using System;
using System.Numerics;

class SequenceOfFibonacci
{
    static void Main()
    {
        Console.Write("Enter length of sequence of Fibonacci N= ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger n1 = 0;
        BigInteger n2 = 1;

        Console.WriteLine(n1);
        Console.WriteLine(n2);

        for (int i = 0; i < n-2 ; i++)
        {
            BigInteger number = (n1 + n2);
            n1 = n2;
            n2 = number;
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("{0}", number);
            
        }
        Console.WriteLine("The End");
    }
}


