using System;

class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        
        int repeatTime=0;
        int value = 0;
        int maxRepeat = 0;

        Console.WriteLine("Enter elements of array:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                repeatTime++;
            }
            else
            {
                if (maxRepeat < repeatTime)
                {
                    maxRepeat = repeatTime;
                    value = array[i];
                }
                repeatTime = 1;
            }
        }
        if (maxRepeat > 1)
        {
            Console.WriteLine("The most frequent number is {0} -> {1}times", value, maxRepeat);
        }
        else
        {
            Console.WriteLine("There is no same elements");
        }
    }
}

