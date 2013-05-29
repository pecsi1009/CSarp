using System;
using System.Globalization;
using System.Threading;

class GreatestVariables
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter 5 numbers:");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        double num4 = double.Parse(Console.ReadLine());
        double num5 = double.Parse(Console.ReadLine());

        double greatestNum = num1;
        if (greatestNum < num2)
        {
            greatestNum = num2;
        }
        if (greatestNum < num3)
        {
            greatestNum = num3;
        }
        if (greatestNum < num4)
        {
            greatestNum = num4;
        }
        if (greatestNum < num5)
        {
            greatestNum = num5;
        }
        Console.WriteLine("The greatest variable is: {0}", greatestNum);
    }
}

