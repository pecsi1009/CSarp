using System;

class NestedLoop
{
    static void Main()
    {
        Console.Write("Enter integer number here: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if ((i % 5 == 0) && (i % 7 == 0))
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }
}

