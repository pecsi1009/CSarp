using System;


class CatalanNumbers2
{
    static void Main()
    {
        Console.Write("Enter n= ");
        double n = double.Parse(Console.ReadLine());
        double factN = 1, fact2N = 1, fact3N = 1;
        double a=(2*n), b=(n+1), c;

        if (n >= 0)
        {
            do
            {
                factN *= n;
                n--;
            }
            while (n > 0);
            do
            {
                fact2N *= a;
                a--;
            }
            while (a > 0);
            do
            {
                fact3N *= b;
                b--;
            }
            while (b > 0);

            c = fact2N / (fact3N * factN);
            Console.WriteLine("c=(2n)!/(n+1)!n!={0}",c);
        }
    }
}

