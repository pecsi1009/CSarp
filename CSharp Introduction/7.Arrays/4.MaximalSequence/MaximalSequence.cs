using System;

class MaximalSequence
{
    static void Main()
    {
        int count = 1;
        int bestCount = 0;
        int maxElement = 0;

        Console.Write("Enter the length of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter integer element for array:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        for (int i = 0; i < array.Length-1; i++)
			{
                if (array[i] == array[i+1])
                {
                    count++;
                }
                else 
                {
                    if (count > bestCount)
                    {
                        bestCount = count;
                        maxElement = array[i];
                    }
                    count = 1;   
                }
            }
        if (count > bestCount)
        {
            bestCount = count;
            maxElement = array[array.Length-1];
        }
        Console.WriteLine("The maximal sequence is {0} times of {1}",bestCount, maxElement);
    }
 }


