using System;


class MaximalIncreasingSequence
{
    static void Main()
    {
        int count = 1;
        int bestCount = 0;
        int end = 0;
        int[] array = { 0, 1, 1, 2, 4,20};

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] < array[i + 1])
            {
                count++;
            }
            else
            {
                if (bestCount< count)
                {
                    end = i;
                    bestCount = count;
                    
                }
                count = 1;
            }
        }
        if (count > bestCount)
        {
            end = array[array.Length - 1];
            bestCount = count;
        }
        count = 1;

        Console.Write("The maximal increasing sequence of numbers is: ");

        for (int i = end - bestCount + 1; i < end + 1; i++)
        {
            Console.Write("{0},", array[i]);
        }
        Console.WriteLine();
     }
 }


