using System;

class Loop1toN
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

