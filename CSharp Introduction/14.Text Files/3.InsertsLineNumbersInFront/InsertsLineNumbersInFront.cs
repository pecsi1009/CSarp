using System;
using System.Linq;
using System.Text;
using System.IO;

class InsertsLineNumbersInFront
{
    static void Main()
    {
        StreamReader file = new StreamReader("text.txt", Encoding.GetEncoding("windows-1251"));
        
        using(file)
        {
            StreamWriter newFile = new StreamWriter("newFile.txt", false, Encoding.GetEncoding("windows-1251"));
            using (newFile)
            {
                int lineNumber = 0;
                string line = file.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    newFile.Write("{0}. ",lineNumber);
                    newFile.WriteLine(line);
                    line = file.ReadLine();
                }
            }

        }
    }
}

