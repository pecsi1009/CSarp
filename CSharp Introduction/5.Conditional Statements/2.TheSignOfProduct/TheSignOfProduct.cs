using System;
using System.Globalization;
using System.Threading;

class TheSignOfProduct
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Write three real number:");
        float first = float.Parse(Console.ReadLine());
        float second = float.Parse(Console.ReadLine());
        float third = float.Parse(Console.ReadLine());

        float product = (first) * (second) * (third);

        if ((first == 0) || (second == 0) || (third == 0))
        {
            Console.WriteLine("The product of the numbers is 0");
        }
        else
        {
            if (product < 0)
            {
                Console.WriteLine("The product of the numbers is negative");
            }
            else
            {
                Console.WriteLine("The product ot the number is possitive");
            }
        }
    }
}
