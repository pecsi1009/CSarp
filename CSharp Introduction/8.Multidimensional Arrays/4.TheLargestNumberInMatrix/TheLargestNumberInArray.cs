using System;

class TheLargestNumberInArray
{
    static void Main()
    {
        Console.Write("Enter integer number for n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number for k= ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter elements of array:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        
        /*int[] array = { 0, 2, 1, 7, 3, 5, 10, 8, 3 };
        int k = 4;*/

        Array.Sort(array);
        int index = Array.BinarySearch(array, k);
        
        if (index > -1) 
        {
            Console.WriteLine("The largest number <= {0} is with index {1}->element {2}",
                k,index,array[index]);
        }
        else
        if(~index==0)
        {
            Console.WriteLine("There is no such number");
        }
        else
        {
            index = (~index) - 1;
            Console.WriteLine("The largest number <= {0} is with index {1}-> element {2}",
                k, index,array[index]);
        }
    }
}

