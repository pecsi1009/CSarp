using System;

class ТheCatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n= ");
        int n = int.Parse(Console.ReadLine());

        decimal factN = 1;
        decimal fact2N = 1;
        decimal c;

        if (n >= 0)
        {
            for (int i = 1,j=(n+1); i < n; i++, j++)
            {
                factN *= i;
                fact2N *= j;
            }

            c = (2*factN) / ((fact2N) * factN);
            Console.WriteLine("C({0})=2n!/(n+1)!n!={1}", n, c);
        }
        else
        {
            Console.WriteLine("Error: n>=0");
        }
    }
}
