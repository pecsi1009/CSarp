using System;

class GCD
{
    static void Main()
    {
        Console.Write("Enter first number a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter first number b= ");
        int b = int.Parse(Console.ReadLine());
        int GCD;

        Console.Write("GCD ({0},{1})= ", a, b);
        if (a == 0)
        {
            Console.WriteLine("{0}", b);
        }
        else if (b == 0)
        {
            Console.WriteLine("{0}", a);
        }
        else if (a == b)
        {
            Console.WriteLine("{0}", b);
        }
        else
        {
            do
            {
                GCD = (a % b);
                a = b;
                b = GCD;
            }
            while (a % b != 0);
            Console.WriteLine("{0}", b);
        }
    }
}