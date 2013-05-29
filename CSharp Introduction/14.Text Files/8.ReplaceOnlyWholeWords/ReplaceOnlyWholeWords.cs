using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;


class ProgramThatReplacesWords
{
    static void Main()
    {
        StreamReader file = new StreamReader("text.txt");
        StreamWriter newFile = new StreamWriter("newFile.txt", false);


        using (file)
        {
            using (newFile)
            {
                string pattern = @"\b(start)\b";
                Regex rgx = new Regex(pattern);

                for (string line = file.ReadLine(); line != null; line = file.ReadLine())
                {
                    string replaced = rgx.Replace(line, "finish");
                    newFile.WriteLine(replaced);
                }

            }
        }
    }
}

