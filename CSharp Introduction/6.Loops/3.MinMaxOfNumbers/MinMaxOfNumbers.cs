using System;

class MinMaxOfNumbers
{
    static void Main()
    {
        int n;
        int num;
        int min = int.MinValue;
        int max = int.MaxValue;

        Console.Write("Enter how many numbers you will write: ");
        n = int.Parse(Console.ReadLine());
      

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter ineger number here: ");
            num = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                min = num;
                max = num;
            }
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
 
            }
        }
        Console.WriteLine("The max number is {0}\nThe min number is {1}",max,min);
        
    }
}

