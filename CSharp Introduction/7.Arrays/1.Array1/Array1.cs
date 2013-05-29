using System;

class Array1
{
    static void Main()
    {
        int[] myArray = new int[20];
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine("myArray[{0}]={1};",i,(i*5));
        }
    }
}

