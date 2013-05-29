using System;

class StringAndObject
{
    static void Main()
    {
        string word1 = "Hello, ";
        string word2 = "World!!!";
        Object result = string.Concat(word1,word2);
        object third = (string)result;

        Console.WriteLine(result);
        Console.WriteLine(third);
        
    }
}

