using System;


class TrpezoidArea
{
    static void Main(string[] args)
    {
        double a = 2.5d;
        double b = 3.8d;
        double h = 4.2d;
        double S = ((a + b) / (2 * h));

        Console.WriteLine("The trapezoid's area is:"+S);
    }
}

