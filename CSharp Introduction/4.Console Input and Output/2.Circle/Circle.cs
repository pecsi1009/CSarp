using System;


class Circle
{
    static void Main()
    {
        Console.Write("Write r fot the circle: ");
        int r = Int16.Parse(Console.ReadLine());
        double pi = 3.14d;
        double P =2*pi*r;
        double S = pi*(r*r);

        
        Console.WriteLine("P=2*pi*r= "+P);
        Console.WriteLine("S=pi*(r*r)=" + S);

    }
}

