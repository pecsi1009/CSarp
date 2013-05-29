using System;
using System.Linq;
using System.Text;
using System.IO;

namespace _2.ConcatenateTwoTextFiles
{
    class ConcatenateTwoTextFiles
    {
        static void Main(string[] args)
        {
            StreamReader text1 = new StreamReader("text1.txt");
            StreamReader text2 = new StreamReader("text2.txt");

            WriteFromFirstFile(text1);
            WriteFromSecondFile(text2);
        }

        private static void WriteFromSecondFile(StreamReader text2)
        {
            using (text2)
            {
                StreamWriter writer = new StreamWriter
                        ("concFiles.txt", true, Encoding.GetEncoding("windows-1251"));

                using (writer)
                {
                    string s;
                    while ((s = text2.ReadLine()) != null)
                    {
                        writer.WriteLine(s);
                    }
                }
            }
        }

        private static void WriteFromFirstFile(StreamReader text1)
        {
            using (text1)
            {
                StreamWriter writer = new StreamWriter
                        ("concFiles.txt", false, Encoding.GetEncoding("windows-1251"));

                using (writer)
                {
                    string s;
                    while ((s = text1.ReadLine()) != null)
                    {
                        writer.WriteLine(s);
                    }
                }
            }
        }
    }
}
