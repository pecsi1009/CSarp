using System;

class IntDoubleString
{
    static void Main()
    {

        Console.WriteLine("Enter your variable kind:\n For int-1 \n For double-2 \n For string-3");
        int variable = int.Parse(Console.ReadLine());

        Console.Write("Enter your variable here:");
             
        switch (variable)
        {
            case 1: int a1 = int.Parse(Console.ReadLine());
                Console.WriteLine(a1 + 1);
                break;
            case 2: double a2 = int.Parse(Console.ReadLine()); 
                Console.WriteLine(a2 + 1);
                break;
            case 3: string a3 = Console.ReadLine(); 
                Console.WriteLine(a3 + "*");
                break;
            default: Console.WriteLine("Error");
                break;
        }
    }
}

