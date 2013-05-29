using System;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractsSentenceWithWord
{
    static void Main(string[] args)
    {
        string text = "We are living in a yellow submarine. We don't have anything else." +
        " Inside the submarine is very tight. So we are drinking all the day. We will move" +
        " out of it in 5 days.";
        string word = "in";
        string[] split = text.Split('.');

        for (int i = 0; i < split.Length; i++)
        {
            if (Regex.Matches(split[i], @"\b" + word + @"\b").Count > 0)
            {
                Console.WriteLine((split[i] + ".").Trim());
            }
        }
    }
}

