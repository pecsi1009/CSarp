using System;
using System.Globalization;
using System.Threading;

class DescendingOrder
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Write first three real numbers: ");
        float num1 = float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());
        float num3 = float.Parse(Console.ReadLine());


        if ((num1 > num2) && (num1 > num3))
        {
            if (num2 > num3)
            {
                Console.WriteLine("The descending order of the numbers is:{0}{1}{2}", num1, num2, num3);
            }
            else
            {
                Console.WriteLine("The descending order of the numbers is:{0}{1}{2}", num1, num3, num2);
            }
        }
        else
        {
            if (num2 > num3)
            {
                Console.WriteLine("The descending order of the numbers is:{0}{1}{2}", num2, num3, num1);
            }
            else
            {
                Console.WriteLine("The descending order of the numbers is:{0}{1}{2}", num3, num2, num1);
            }
        }
    }
}