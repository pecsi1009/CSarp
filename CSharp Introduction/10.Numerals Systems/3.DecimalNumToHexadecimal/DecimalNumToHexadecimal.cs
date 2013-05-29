using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class DecimalNumToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter decimal number:");
        int decNum = int.Parse(Console.ReadLine());
        StringBuilder hexNum = new StringBuilder(); 

        while (decNum > 0)
        {
            int remind = (decNum % 16);
            decNum = decNum / 16;
            if (remind > 9)
            {
                switch (remind)
                {
                    case 10:
                        hexNum.Append('A');
                        break;
                    case 11:
                        hexNum.Append('B');
                        break;
                    case 12:
                        hexNum.Append('C');
                        break;
                    case 13:
                        hexNum.Append('D');
                        break;
                    case 14:
                        hexNum.Append('E');
                        break;
                    case 15:
                        hexNum.Append('F');
                        break;
                }
            }
            else 
            {
                hexNum.Append(decNum % 16);
            }
        }
        string endDec = hexNum.ToString();
        for (int i = endDec.Length - 1; i > -1; i--)
        {
            Console.Write(endDec[i]);
        }
        Console.WriteLine();
    }
}


    



