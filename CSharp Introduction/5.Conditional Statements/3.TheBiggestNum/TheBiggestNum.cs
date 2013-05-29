using System;

class TheBiggestNum
{
    static void Main()
    {
        Console.WriteLine("Write three integer number");
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum= int.Parse(Console.ReadLine());
        

        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                Console.WriteLine("The biggest number is:{0}",firstNum);
            }
            else
            {
                Console.WriteLine("The biggest number is:"+thirdNum);
            }
        }
        else if (secondNum > thirdNum)
        {
            Console.WriteLine("The biggest number is:"+ secondNum);
        }
        else 
        {
            Console.WriteLine("The biggest number is:"+thirdNum);
        }
    }
 }


