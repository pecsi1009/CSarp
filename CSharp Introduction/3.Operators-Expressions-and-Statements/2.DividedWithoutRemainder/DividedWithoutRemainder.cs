using System;

class DividedWithoutRemainder
{
    static void Main()
    {
        int a = 35;
        int result1 = (a % 5);
        int result2 = (a % 7);

        bool result = (result1 == result2);
        if (result)
        {

            Console.WriteLine(a + " " + "is devided to 5 and 7");
        }
        else
        {
            Console.WriteLine(a + " " + "isn't devided to 5 and 7");
        }
        Console.WriteLine(result);
    }
}