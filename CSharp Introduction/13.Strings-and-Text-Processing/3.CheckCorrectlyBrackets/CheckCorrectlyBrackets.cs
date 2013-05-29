using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CheckCorrectlyBrackets
{
    static void Main()
    {
        string text = "5(+a)*(b+4)-(7/2(";
        CheckBrackets(text);
    
        if (CheckBrackets(text) == 0) 
        {
            Console.WriteLine("The brackets are correctly");
        }
        else
        {
            Console.WriteLine("The brackets are not corectly");
        }
    }

    private static int CheckBrackets(string text)
    {
        int count = 0;
        foreach (var ch in text)
        {
            if (ch == '(')
            {
                count += 1;
            }
            else if (ch == ')')
            {
                count += -1;
            }
        }
        return count;
    }
}

