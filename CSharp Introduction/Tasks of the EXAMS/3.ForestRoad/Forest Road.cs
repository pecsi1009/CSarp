using System;


class Program
{
    static void Main()
    {
        int i = 1;
        char geeko = '*';
        char road = '.';
        Console.Write("");
        sbyte N = sbyte.Parse(Console.ReadLine());

        if ((N >= 2) && (N <= 79))
        {
            for (int i = 1; i < ((2 * N) - 1); i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (j == i)
                    {
                        Console.Write(geeko);
                    }
                    else
                    {
                        Console.Write(road);
                    }

                }
                Console.WriteLine();
            }   
        }
        else
        {
            Console.WriteLine("Invalid format !!!");
        }
    }
}

