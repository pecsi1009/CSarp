using System;

class MissCat2001
{
    static void Main()
    {
        Console.Write("");
        uint n = uint.Parse(Console.ReadLine());
        int[] votes = new int[11];
        int winner = 0;
        int Max = 0;
        int i = 0;

        if ((n >= 1) && (n <= 100000))
        {
            while (i < n)
            {
                Console.Write("");
                uint numberOfCat = uint.Parse(Console.ReadLine());

                votes[numberOfCat]++;
                i++;
            }
            for (i = 1; i <= 10; i++)
            {
                if (winner < votes[i])
                {
                    winner = votes[i];
                    Max = i;
                }
            }
            Console.WriteLine(Max);
        }
        else 
        {
            Console.WriteLine("Invalid format !!!");
        }
    }
}




