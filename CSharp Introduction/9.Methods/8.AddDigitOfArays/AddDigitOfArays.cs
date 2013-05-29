using System;
using System.Collections.Generic;

class AddDigitOfArays
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        string first = Console.ReadLine();
        Console.Write("Please enter second number: ");
        string second = Console.ReadLine();

        int[] firstArray;
        int[] secondArray;
        GetArray(first, second, out firstArray, out secondArray);
        GetSum(firstArray, secondArray);

         foreach (int digit in GetSum(firstArray, secondArray))                     
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }

    private static void GetArray(string first, string second, out int[] firstArray, out int[] secondArray)
    {
        firstArray = new int[Math.Max(first.Length, second.Length) + 1];
        secondArray = new int[Math.Max(first.Length, second.Length) + 1];

        for (int i = first.Length - 1; i >= 0; i--)
        {
            firstArray[first.Length - i - 1] = int.Parse(first[i].ToString());
        }
        for (int i = second.Length - 1; i >= 0; i--)
        {
            secondArray[second.Length - i - 1] = int.Parse(second[i].ToString());
        }
    }
   
    public static List<int> GetSum(int[] firstArray, int[] secondArray)
    {
        int carry = 0;
        List<int> sum = new List<int>();
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] + secondArray[i] + carry > 9)
            {
                sum.Add(((firstArray[i] + secondArray[i] + carry) % 10));
                carry = 1;
            }
            else
            {
                sum.Add(firstArray[i] + secondArray[i] + carry);
                carry = 0;
            }
        }
        sum.Reverse();
        if (sum[0] == 0)
        {
            sum.Remove(0);
            return sum;
        }
        else
        {
            return sum;
        }
    }
}


