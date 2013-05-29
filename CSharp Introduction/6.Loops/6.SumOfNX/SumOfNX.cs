using System;
using System.Numerics;

class SumOfNX
{
    static void Main()
    {
        Console.Write("Enter n= ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter x= ");
        BigInteger x = BigInteger.Parse(Console.ReadLine());

        decimal S;
        BigInteger s = 1;
        BigInteger factN = 1;
        BigInteger X = 1;
        
        if((n > 0)||(x > 0))
        {
            for (int i = 1; i <= n; i++)
            {
         
               factN *=(factN * i);
               X *= x;   
               s += factN / X;
              
            }

            S =(decimal)(1 + s);
            Console.WriteLine("S=N!/(X^n)={0}",S);
        }
        else
            Console.WriteLine("Enter positiv integer number!!!");
    }
}

