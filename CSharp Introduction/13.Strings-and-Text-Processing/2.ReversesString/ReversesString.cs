using System;
using System.Linq;
using System.Text;

class ReversesString
{
    static void Main()
    {
        string text = "example";
        StringBuilder sb = new StringBuilder();

        for (int i = text.Length-1; i >= 0; i--)
        {
            sb.Append(text[i]);
        }
        Console.WriteLine(sb.ToString());
    }
}

