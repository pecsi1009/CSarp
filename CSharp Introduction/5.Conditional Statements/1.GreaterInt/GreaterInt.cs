﻿using System;

class GreaterInt
{
    static void Main()
    {
        Console.WriteLine("Write two integer number:");
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        if (firstNum < secondNum)
        {
            firstNum = secondNum;
        }
        Console.WriteLine("The bigger number is {0}", firstNum);
    }
}


