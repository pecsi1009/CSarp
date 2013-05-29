using System;
using System.Linq;
using System.IO;

class UppercaseSubstringInText
{
    static void Main()
    {
        StreamReader text = new StreamReader("text.txt");
        StreamWriter newFile = new StreamWriter("newFile.txt", false);

        using (text)
        {
            using (newFile)
            {
                 for (string line = text.ReadLine(); line != null; line = text.ReadLine())
                {
                    string newLine = line;
                    int index = line.IndexOf("<upcase>");
                    int index2 = line.IndexOf("</upcase>");
                    if ((index != -1) && (index2 != -1))
                    {
                        int stringLength = Math.Abs((index + 8) - index2);
                        string subText = line.Substring(index + 8, stringLength);
                        string upper = subText.ToUpper();
                        newLine = line.Replace(subText, upper);
                    }
                    newFile.WriteLine(newLine);
                 
                }
            }
        }
    }
}

