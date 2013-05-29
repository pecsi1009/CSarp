using System;

class NullValue
{
    static void Main()
    {
        int? i1 = null;
        double? d1 = null;

        Console.WriteLine(i1);
        Console.WriteLine(d1);
     
        int i2=8;
        int? i = i2;
        Console.WriteLine(i);

      
    }
}

