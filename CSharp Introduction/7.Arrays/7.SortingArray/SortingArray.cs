using System;

class SortingArray
{
    static void Main()
    {
        int[] array = { 0, 3, 2, 5, 1, 4 };
        int min = 0;
        int container;

        for (int i = 0; i < array.Length; i++)
        {
            min = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            container = array[i];
            array[i] = array[min];
            array[min] = container;

            Console.Write("{0} ",array[i]);
            Console.WriteLine();
        } 
    }
}

