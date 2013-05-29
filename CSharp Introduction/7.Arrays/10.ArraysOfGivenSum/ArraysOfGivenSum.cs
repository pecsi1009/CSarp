using System;


class ArraysOfGivenSum
{
    static void Main()
    {
        Console.WriteLine("Enter length of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = { 0, 2, 5, 10, 2, 3, 6 };
        Console.Write("Enter sum S= ");
        int sum = int.Parse(Console.ReadLine());
        int tempSum=0;
        int count = 0;
        int start = 0;
        int end = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            tempSum += array[i];
            if (tempSum == sum)
            {
                start = count;
                end = i;
            }
            while (tempSum > sum)
            {
                tempSum = tempSum - array[count];
                count++;
            }
        }
        Console.Write("Sum ={0}= ",sum);
        for (int i = start; i <= end; i++)
        {
            Console.Write("{0}"+" ", array[i]);
        }
    }
}

