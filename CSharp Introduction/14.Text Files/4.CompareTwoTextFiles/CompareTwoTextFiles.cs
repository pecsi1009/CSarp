using System;
using System.Linq;
using System.Text;
using System.IO;

class CompareTwoTextFiles
{
    static void Main()
    {
        StreamReader text1 = new StreamReader("text1.txt", Encoding.GetEncoding("windows-1251"));
        StreamReader text2 = new StreamReader("text2.txt", Encoding.GetEncoding("windows-1251"));

        using (text1)
        {
            int lineNumber = 1;
            string lineFirstFile = text1.ReadLine();

            Console.WriteLine("The text line are:");
            Console.WriteLine();
            while (lineFirstFile != null)
            {
                string lineSecondFile = text2.ReadLine();

                int result = string.Compare(lineFirstFile, lineSecondFile, true);

                if (result==0)
                {
                    Console.Write("equal at: ");
                    Console.WriteLine(" {0} line ", lineNumber);
                }
                else
                {
                    Console.Write("not equal at:");
                    Console.WriteLine(" {0} line", lineNumber);
                }
                lineNumber++;
                lineFirstFile = text1.ReadLine();
            }
            
        }
    }    
}

