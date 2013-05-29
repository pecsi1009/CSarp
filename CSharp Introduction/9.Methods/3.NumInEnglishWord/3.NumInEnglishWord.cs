using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your integer number:");
        int num = int.Parse(Console.ReadLine());

        int digit = (num % 10);
        GetEnglishWord(digit);
        Console.WriteLine("The last digit in {0} is {1}",num,GetEnglishWord(digit));
        
    }
    
    public static string GetEnglishWord(int digit)
    {
        string EnglishDigit;
        switch (digit)
        {
            case 1:
                EnglishDigit = "One";
                break;
            case 2:
                EnglishDigit = "Two";
                break;
            case 3:
                EnglishDigit = "Three";
                break;
            case 4:
                EnglishDigit = "Four";
                break;
            case 5:
                EnglishDigit = "Five";
                break;
            case 6:
                EnglishDigit = "Six";
                break;
            case 7:
                EnglishDigit = "Seven";
                break;
            case 8:
                EnglishDigit = "Eight";
                break;
            case 9:
                EnglishDigit = "Nine";
                break;
            default:
                Console.WriteLine("Invalid number");
                return null;
        }
        return EnglishDigit;
    }
}

