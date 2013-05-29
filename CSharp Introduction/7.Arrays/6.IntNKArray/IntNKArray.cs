using System;

class IntNKArray
{
    static void Main()
    {
        Console.Write("Enter integer number for N= ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number for K= ");
        int K = int.Parse(Console.ReadLine());

        int sum = 0;
        int minElement = 0;
        int[] array = new int[N];

        if ((K < N) && (K >= 2))
        {
            Console.WriteLine("Enter element of array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                minElement = array[i];

                if (minElement > array[i + 1])
                {
                    minElement = array[i + 1];
                }

            }
            for (int i = (N - K); i < N; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(" The sum of the biggest element in array = {0}",sum);
        }
        else
        {
            Console.WriteLine("Enter K<N and K must be >= 2!!!");
        }
    }
}

