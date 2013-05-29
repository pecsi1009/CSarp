using System;
using System.Linq;
using System.IO;

class FindCountOfSubstringInText
{
    static void Main()
    {
        StreamReader text = new StreamReader("text.txt");
        string keyword = "try";
        using (text)
        {
            int count = 0;
            string line = text.ReadLine();
            while (line != null)
            {
                string newLine = line.ToLower();
                newLine.Trim();
                int index = newLine.IndexOf(keyword);
                
                while (index != -1)
                {
                    count++;
                    index = newLine.IndexOf(keyword, index + 1);
                }
                line = text.ReadLine();
            }
            Console.WriteLine(count);
        }
        
    }
}

