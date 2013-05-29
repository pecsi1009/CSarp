using System;
using System.Linq;

class ParsesAnURLAddress
{
    static void Main()
    {
        string uRL = @"http://www.devbg.org/forum/index.php";

        int index1 = 0;
        int index2 = 0;
        int index3 = 0;

        for (int i = 0; i < uRL.Length - 2; i++)
        {
            if (uRL.Substring(i, 1) == ":")
            {
                index1 = i;
            }
            else if ((uRL.Substring(i, 2) == "//"))
            {
                index2 = i;
                for (int k = i + 2; k < uRL.Length; k++)
                {
                    if (uRL.Substring(k, 1) == "/")
                    {
                        index3 = k;
                        break;
                    }
                }
            }
        }
        int protokolLength = index1;
        int serverLength = index3 - index2;
        int resourceLength = uRL.Length - 1 - index3;

        string protokolStr = uRL.Substring(0, protokolLength);
        string serverStr = uRL.Substring(index2 + 1, serverLength);
        string resourceStr = uRL.Substring(index3 + 1, resourceLength);

        Console.WriteLine(@"[protokol] = ""{0}""", protokolStr);
        Console.WriteLine(@"[server] = ""{0}""", serverStr);
        Console.WriteLine(@"[resource] = ""{0}""", resourceStr);
    }
}

