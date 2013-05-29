using System;


class SequenceOfMaximalSum
{
    static void Main()
    {
        int currentStart = 0;
        int currentValue = 0;
        int start = 0;
        int end = 0;
        int maxValue = int.MinValue;
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        
 
        for (int i = 0; i < array.Length; i++)
        {
            currentValue += array[i];
 
            if (array[i] > currentValue)
            {
                currentValue = array[i];
                currentStart = i;
            }
            if (currentValue > maxValue)
            {
                maxValue = currentValue;
                start = currentStart;
                end = i;
            }
        }
 
        Console.WriteLine("Maximal sum is: {0}", maxValue);
 
        for (int j = start; j <= end; j++)
        {
            Console.Write(array[j] + " ");
        }
    }
}

