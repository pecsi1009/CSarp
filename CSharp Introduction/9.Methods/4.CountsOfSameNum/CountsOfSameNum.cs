using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.CountsOfSameNum
{
    public class CountsOfSameNum
    {
        static void Main()
        {
            //Input digit for legth of array
            Console.Write("Enter length of the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] myArray = new int[arrayLenght];

            //Input elements of array
            Console.WriteLine("Enter elements of array:");
            for (int i = 0; i < arrayLenght; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            //Input the element who will search

            Console.WriteLine("Enter the number that you search for:");
            int num = int.Parse(Console.ReadLine());

            //Print the result

            Console.WriteLine("The number appears {0} times", GetCount(myArray, arrayLenght, num));
        }
    

        public static int GetCount(int[] myArray, int arrayLenght, int num)
        {
            int count = 0;
            for (int i = 0; i < arrayLenght; i++)
            {
                if (myArray[i] == num)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
