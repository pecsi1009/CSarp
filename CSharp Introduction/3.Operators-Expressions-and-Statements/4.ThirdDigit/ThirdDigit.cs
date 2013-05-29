using System;

class ThirdDigit
{
    static void Main()
    {
        int a = 1734;
        int b = 3;

        int mask = 7 << b;
        if (mask == 7)
        {
            Console.WriteLine("The third digit in the" + " " + a + " " + "is 7!");
        }
        else
        {
            Console.WriteLine("The third digit in the" + " " + a + " " + "is not 7!");
        }
    }
}

