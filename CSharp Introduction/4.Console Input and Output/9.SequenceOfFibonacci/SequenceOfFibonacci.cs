using System;


class SequenceOfFibonacci
{
    static void Main()
    {
        
        int n1 = 0;
        int n2 = 1;
        Console.WriteLine(n1);
        Console.WriteLine(n2);

        for (int i = 0; i <= 98; i++)
        {
            int number = (n1 + n2);
            n1 = n2;
            n2 = number;
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(number);
            
        }
        Console.WriteLine("The End");
    }
}

