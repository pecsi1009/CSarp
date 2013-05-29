using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class HexadecimalNumToDecimal
{
    static void Main()
    {
        Console.Write("Enter heximal number: ");
        string number = Console.ReadLine();
        StringBuilder hexNum = new StringBuilder();
        hexNum.Append(number);

        BigInteger decNum = 0;
        int digit = 0;

        for (int i = 0; i < hexNum.Length; i++)
        {
            switch (hexNum[i])
            {
                case 'A':
                case 'a':
                    digit = 10;
                    break;
                case 'B':
                case 'b':
                    digit = 11;
                    break;
                case 'C':
                case 'c':
                    digit = 12;
                    break;
                case 'D':
                case 'd':
                    digit = 13;
                    break;
                case 'E':
                case 'e':
                    digit = 14;
                    break;
                case 'F':
                case 'f':
                    digit = 15;
                    break;
                default:
                    digit=int.Parse(Convert.ToString(hexNum[i]));
                    break;
            }
            decNum += digit * (int)Math.Pow(16,i);
        }
        Console.WriteLine(decNum);
    }
}


