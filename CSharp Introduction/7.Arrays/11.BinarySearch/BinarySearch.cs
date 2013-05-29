using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter length of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.Write("Enter the number: ");
        int searchNumber=int.Parse(Console.ReadLine());
        int middle = 0;
        int result = 0;

        Console.WriteLine("Enter elements of array:");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());   
        }
        Array.Sort(array);

        if (n % 2 == 0)
        {
            middle = (n / 2)-1;
        }
        else 
        {
            middle = n / 2;
        }

        if (array[middle] == searchNumber)
        {
            result = middle;
        }

        if (array[middle] > searchNumber)
        {
            for (int i = 0; i < middle+1; i++)
            {
                if (array[i] == n)
                {
                    result = array[i];
                }
            }
        }
        else
        {
            for (int i = middle; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    result = i;
                }
            }
        }
        Console.WriteLine("Position of number {0} in array is : {1}",searchNumber,result);
    }
}

