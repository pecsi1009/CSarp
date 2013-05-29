using System;


class CompareFloatNimbers
{
    static void Main()
    {
        double a = 2.254;
        double b = 3.012;
        Boolean Compare = (a == b);
        Console.WriteLine("Comapare is: {0}", Compare);

        float c = 1.12345678f;
        float d = 1.12345679f;
        Boolean Compare2 = (c == d);
        Console.WriteLine("Compare2 is: {0}", Compare2);

    }
}

