using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class DeletesOddLines
{
    static void Main(string[] args)
    {
        StreamReader file = new StreamReader("text.txt", Encoding.GetEncoding("Windows-1251"));
        StreamWriter newFile = new StreamWriter("newText.txt", false, Encoding.GetEncoding("Windows-1251"));
 
        int lineNumber = 1;
        using (file)
        {
            using (newFile)
            {
                for (string line = file.ReadLine(); line != null; line = file.ReadLine(), lineNumber ++)
                {
                    if (lineNumber % 2 == 0)
                    {
                        newFile.WriteLine(line);
                    }
                }
            }
        }
        File.Delete("text.txt");
        File.Move("newText.txt","text.txt");
    }
}

