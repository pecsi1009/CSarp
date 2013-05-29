using System;
using System.Threading;
using System.Globalization;


class SumOfNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
        CultureInfo.InvariantCulture;

        Console.Write("Enter number:");
       double n1 = double.Parse(Console.ReadLine());
        Console.Write("Enter number:");
        double n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("{0}+{1}={2}",n1,n2,(n1+n2));

        Console.Write("Enter number:");
        double n3 = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}+{1}+{2}={3}",n1,n2,n3,(n1+n2+n3));

        Console.Write("Enter number:");
        double n4 = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}+{1}+{2}+{3}={4}",n1,n2,n3,n4,(n1+n2+n3+n4));
    }
}

