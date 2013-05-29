using System;
using System.Linq;

    class ReplacesForbiddenWords
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today." +
                " It is based on .NET Framework 4.0 and is implemented as a dynamic" +
                " language in CLR.";
            string words = "Microsoft,CLR,PHP";
            string[] split = words.Split(',');
            words.Split();

            for (int i = 0; i < split.Length; i++)
            {
                split[i] = split[i].Trim();
                text = text.Replace(split[i], new string('*', split[i].Length));
            }
            Console.WriteLine(text);
        }
    }

