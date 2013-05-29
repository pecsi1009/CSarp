using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class HexadecimalNumToBinary
{
    static void Main()
    {
        Console.Write("Enter heximal number: ");
        string hexNum = Console.ReadLine();
        List<int> binaryNum = new List<int>();
        int digit = 0;

        for (int i = 0; i < hexNum.Length; i++)
        {
            switch (hexNum[i])
            {
                case 'a':
                case 'A':
                    digit = 10;
                    break;
                case 'b':
                case 'B':
                    digit = 11;
                    break;
                case 'c':
                case 'C':
                    digit = 12;
                    break;
                case 'd':
                case 'D':
                    digit = 13;
                    break;
                case 'e':
                case 'E':
                    digit = 14;
                    break;
                case 'f':
                case 'F':
                    digit = 15;
                    break;
                default:
                    digit = int.Parse(Convert.ToString(hexNum[i]));
                    break;
            }
            while (digit > 0)
            {
                binaryNum.Add(digit % 2);
                digit = (digit / 2);
            }
            binaryNum.Reverse();
        }
        for (int i = 0; i < binaryNum.Count; i++)
        {
            Console.Write(binaryNum[i]);
        }
        Console.WriteLine();

    }
}

