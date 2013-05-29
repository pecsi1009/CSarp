using System;
using System.Collections.Generic;

class FindMaxElement
{
    static void Main()
    {
        int[] numbers = new int[] { 0, 5, 7, 20, 3, 4, 2, 1, 26, 75 };
        Console.Write("Enter strating index:");
        int start = int.Parse(Console.ReadLine());

        SortArray(numbers);
        
    }

    private static int[] SortArray(int[] numbers)
    {
        for (int i = start; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        return numbers;
    }
}
    



