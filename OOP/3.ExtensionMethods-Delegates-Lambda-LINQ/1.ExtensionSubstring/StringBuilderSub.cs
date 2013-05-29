/*
    1.Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the
same functionality as Substring in the class String.
 
 */
using System;
using System.Text;

namespace ExtensionMethodsDelegatesLambdaLINQHome
{
    public static class StringBuilderSub
    {
        public static StringBuilder SubString(this StringBuilder str, int startIndex, int length)
        {
            StringBuilder substringBuilder = new StringBuilder();
            int endIndex = startIndex + length;

            if ((endIndex >= str.Length - 1) || (startIndex < 0) || (length < 0))
            {
                throw new ArgumentOutOfRangeException("The startIndex and length must be bigger than 0 and smaller than string length");
            }
            else
            {
                for (int i = startIndex; i < endIndex; i++)
                {
                    substringBuilder.Append(str[i]);
                }
                return substringBuilder;
            }
        }
        static void Main()
        {
            StringBuilder test = new StringBuilder();
            test.AppendLine("This is testing string");
            string result = test.SubString(2, 3).ToString();
            Console.WriteLine(result);

        }
    }
}
