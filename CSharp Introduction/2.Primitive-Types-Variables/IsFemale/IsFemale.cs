using System;

class IsFemale
{
    static void Main()
    {
        Console.WriteLine("What is your gender? \n Note: write \t\'1'- Female \n \t\t \'2'- Male");
        int a = int.Parse(Console.ReadLine());
        int b = 1;
        int c = 2;
        bool Sex2 = (a == b);
        bool Sex = (a == c);
        if (Sex2)
        {
            Console.WriteLine("You are female");
        }
        else
        {
            Console.WriteLine("You are male");
        }
        
    }
}
