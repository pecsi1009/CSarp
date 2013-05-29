using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ReadsAndPrintsOddLine
{
    static void Main()
    {
        StreamReader reader = new StreamReader("text.txt",Encoding.GetEncoding("Windows-1251"));
        
        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            Console.WriteLine("Line {0}: {1}", lineNumber, line);
            while (line != null)
            {
                lineNumber +=2;
                Console.WriteLine("Line {0}: {1}",lineNumber,line);
                line = reader.ReadLine();
            }
        }
    }
}

