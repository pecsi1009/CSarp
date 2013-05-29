using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        Console.Write("Enter n= ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter k= ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());    

        BigInteger factN=1;
        BigInteger factK=1;
        BigInteger factResult = 1;
        BigInteger result = (k - n);
        BigInteger result2;
        
        if ((1 < n) && (n < k))
        {
            do
            {
                factN *= n;
                n--;
            }
            while (n > 0);

            do
            {
                factK *=k;
                k--;
            }
            while(k > 0);

            do
            {
                factResult *= result;
                result--;
            }
            while (result > 0);

            result2 = (factN * factK) / (factResult);
            Console.WriteLine("(N!*K!)/(K-N)! = {0}",result2);
        }
        else
        Console.WriteLine("Error:The value of 'k' must be bigger than 'n'!Try again!!!");
    }
}

