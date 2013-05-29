using System;
using System.Linq;


class FormatingNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Decimal = {0,15:G}",number);
        Console.WriteLine("Heximal = {0,15:X}",number);
        Console.WriteLine("Percent = {0,15:P}", number);
        Console.WriteLine("Scientific notation = {0,15:\\0.#####E0}", number);
      
    }
}

