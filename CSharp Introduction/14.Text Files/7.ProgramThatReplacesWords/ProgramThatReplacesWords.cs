using System;
using System.Linq;
using System.IO;


class ProgramThatReplacesWords
{
    static void Main()
    {
        StreamReader file = new StreamReader("text.txt");
        StreamWriter newFile = new StreamWriter("newFile.txt",false);
        

        using (file)
        {
            using (newFile)
            {
                for (string line = file.ReadLine(); line != null; line = file.ReadLine())
                {
                    string newLine = line.Replace("start", "finish");
                    newFile.WriteLine(newLine);
                }
                
            }
        }
    }
}

