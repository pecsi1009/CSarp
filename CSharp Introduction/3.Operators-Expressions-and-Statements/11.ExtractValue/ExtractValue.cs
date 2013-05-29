
using System;

class ExtractValue
{
    static void Main(string[] args)
    {
        int i = 325;
        int b= 4;
        int mask=1<<b;
        int iAndMask=i&mask;
        int result=iAndMask>>b;
        Console.WriteLine(result);
    }
}

