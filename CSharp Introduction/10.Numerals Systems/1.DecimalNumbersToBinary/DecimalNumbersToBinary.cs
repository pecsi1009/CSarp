using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter your decimal number: ");
        int number = int.Parse(Console.ReadLine());
        List<int> binaryNum = new List<int>();
        
        while (number > 0)
        {
            binaryNum.Add(number % 2);
            number = (number / 2);
        }
        binaryNum.Reverse();

        for (int i = 0; i < binaryNum.Count; i++)
        {
            Console.Write(binaryNum[i]);
        }
        Console.WriteLine();
    }
}

