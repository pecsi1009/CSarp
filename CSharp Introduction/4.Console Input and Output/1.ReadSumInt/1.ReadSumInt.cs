using System;

class Program
{
    static void Main()
    {
        Console.Write("a=");
        int a = Int16.Parse(Console.ReadLine());

        Console.Write("b=");
        int b = Int16.Parse(Console.ReadLine());

        Console.Write("c=");
        int c = Int16.Parse(Console.ReadLine());

        Console.WriteLine("{0}+{1}+{2}={3}",a,b,c,(a+b+c));
    }
}

