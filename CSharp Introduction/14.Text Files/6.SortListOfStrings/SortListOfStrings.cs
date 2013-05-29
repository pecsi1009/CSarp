using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Generic;

class SortListOfStrings
{
    static void Main()
    {
        StreamReader unorderList = new StreamReader("listOfSomething.txt",
                                    Encoding.GetEncoding("Windows-1251"));
        string line = unorderList.ReadLine();
        List<string> array = new List<string>();

        using (unorderList)
        {
            while (line != null)
            {
                if (line != null)
                {
                    array.Add(line);
                }
                line = unorderList.ReadLine();
            }
            array.Sort();

            StreamWriter sortedList = new StreamWriter("sortedFile.txt");
            using (sortedList)
            {
                for (int i = 0; i < array.Count; i++)
                {
                    sortedList.WriteLine(array[i]);
                }
            }
        }
    }
}

