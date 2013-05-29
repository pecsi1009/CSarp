using System;

class BonusScore

{
    static void Main()
    {
        Console.WriteLine("Enter integer number between [1...9]");
        int num1;
        bool num=int.TryParse(Console.ReadLine(), out num1);
        
        if (num)
        {
            switch (num1)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("The result is:" + (num1 * 10));
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("The result is:" + (num1 * 100));
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("The result is:" + (num1 * 1000));
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
             }
         }
         Console.WriteLine("Errorrrrrr");
     }
  }


