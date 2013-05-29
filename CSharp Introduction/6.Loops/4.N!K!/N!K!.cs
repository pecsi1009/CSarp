using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        BigInteger n, k;
        Console.Write("Enter value for n= ");
        n = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter value for k= ");
        k = BigInteger.Parse(Console.ReadLine());

        BigInteger factK = 1;
        BigInteger factN = 1;
        BigInteger result;

        if ((1 < k) && (k < n))
        {
            do
            {
                factN *= n;
                n--;
            }
            while (n > 0);

            do
            {
                factK *= k;
                k--;
            }
            while (k > 0);

            result = (factN / factK);
            Console.WriteLine("N!/K!= {0}", result);
        }
        else
        Console.WriteLine("Eror:The value of 'n' must be bigger than 'k'" );
    }
}

