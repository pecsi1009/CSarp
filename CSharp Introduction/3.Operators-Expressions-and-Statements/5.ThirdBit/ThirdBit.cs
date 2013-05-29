using System;

class ThirdBit
{
    static void Main()
    {
        int a = 256;
        int b = 2;
        int mask = 1 << b;

        int aAndMask = a & mask;
        int result = aAndMask >> b;
        Console.WriteLine(result);

    }
}