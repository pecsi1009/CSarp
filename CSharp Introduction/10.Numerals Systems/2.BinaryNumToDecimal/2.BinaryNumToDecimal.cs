using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binaryNum = Convert.ToString(Console.ReadLine());

        int decimalNum=0;
        for (int i = 0; i < binaryNum.Length; i++)
		{
            if (binaryNum[binaryNum.Length - i - 1] == 0)
            {
                continue;
            }
            decimalNum += (int)Math.Pow(2, i);
	    }
        Console.WriteLine("{0} in decimal representation is {1}",binaryNum,decimalNum);
    }
}

