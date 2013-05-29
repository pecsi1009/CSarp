using System;


class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c=");
        double c = double.Parse(Console.ReadLine());

        double D = (b * b) - (4 * a * c);

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
                Console.WriteLine("D="+D);
                Console.WriteLine("x1=" + x1);
                Console.WriteLine("x2=" + x2);
            }
        }
    }
}

