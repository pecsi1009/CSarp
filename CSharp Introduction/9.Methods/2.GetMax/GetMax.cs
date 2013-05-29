using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.GetMax
{
    class MaxNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 integer number:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            GetMax(num1, num2);
            int biggestNum = GetMax(num1, num2);
            biggestNum = GetMax(biggestNum, num3);
            Console.WriteLine("The biggest number is: {0}",biggestNum);
        }

        public static int GetMax(int num1, int num2)
        {
            int maxNum = 0;

            if (num1 > num2)
            {
                maxNum = num1;
                return maxNum;
            }
            else
            {
                maxNum = num2;
                return maxNum;
            }
        }
    }
}
