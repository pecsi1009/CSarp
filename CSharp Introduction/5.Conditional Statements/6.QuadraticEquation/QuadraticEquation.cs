using System;
using System.Globalization;
using System.Threading;


class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter a=");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter b=");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter c=");
        float c = float.Parse(Console.ReadLine());

        float D = (b * b) - (4 * a * c);

        if (D < 0)
        {
            Console.WriteLine("The equation has no real roots");
        }
        else
        {
            if (D == 0)
            {
                double x12 = (-b / (2 * a));
            }
            else
            {
                double x1 = (((-b) + Math.Sqrt(D)) / (2 * a));
                double x2 = (((-b) - Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("D=" + D);
                Console.WriteLine("x1=" + x1);
                Console.WriteLine("x2=" + x2);
            }
        }
    }
}

