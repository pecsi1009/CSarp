using System;

class BooleanExpression
{
    static void Main()
    {
        int v = 235;
        int p = 2;
        int mask = 1 << p;
        int vAndMask = v & mask;
        int result = vAndMask >> p;
        Console.WriteLine(result);
        Console.WriteLine(result==1?true:false);
        

    }
}

