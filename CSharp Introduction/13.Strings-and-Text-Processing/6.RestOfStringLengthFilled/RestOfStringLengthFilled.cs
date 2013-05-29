using System;
using System.Linq;
using System.Text;

class RestOfStringLengthFilled
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder(20);
        Console.Write("Enter string with length less than 20 incl: ");
        string text = Console.ReadLine();


        if (text.Length < 20)
        {
            sb.Append(text);
            while (sb.Length < 20)
            {
                sb.Append('*');
            }
            sb.ToString();
            Console.WriteLine(sb);
        }
        else 
        {
            Console.WriteLine("The word contain more than 20 characters");
        }
    }
}
