using System;

class IntervalsOfNumbers
{
    static void Main()
    {
        Console.Write("Enter integer number here:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(500);
            Console.Write("\r");
        }
        Console.WriteLine("This is the end");
    }
}

