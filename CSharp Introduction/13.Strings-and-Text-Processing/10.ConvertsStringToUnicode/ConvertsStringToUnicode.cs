using System;
using System.Linq;

class ConvertsStringToUnicode
{
    static void Main()
    {
        string text = "Hello";

        foreach (var ch in text)
        {
            int unicode = (int)ch; 
            Console.Write("\\u"+unicode.ToString("D4"));
        }
        Console.WriteLine();
    }
}

