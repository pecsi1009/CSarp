using System;
using System.Linq;
using System.Numerics;

class MartoTubes
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        BigInteger M = BigInteger.Parse(Console.ReadLine());
        BigInteger[] arr = new BigInteger[(int)N];
        BigInteger sum = 0;

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }
        if (sum < M)
        {
            Console.WriteLine(-1);
            return;
        }
        Array.Sort(arr);

        BigInteger min = 0;
        BigInteger max = 200000000;
        BigInteger possibleAnswer = (max + min) / 2;
        BigInteger numberOfTubes = 0;

        while (min <= max)
        {
            numberOfTubes = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                numberOfTubes += arr[i] / possibleAnswer;
            }

            if (numberOfTubes < M)
            {
                max = possibleAnswer - 1;
            }
            else
            {
                min = possibleAnswer + 1;
            }

            possibleAnswer = (min + max) / 2;
        }

        Console.WriteLine(possibleAnswer);
    }
}

