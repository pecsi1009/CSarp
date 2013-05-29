 using System;

class CheckInt
{
    static void Main()
    {
        int[] array = { 1, 2, 5, 6, 7, 0, 3 };
        Console.Write("Enter number for position in array:");
        int position = int.Parse(Console.ReadLine());


        CheckNeighboursInArray(array, position);
        Console.WriteLine("Element with this position is bigger than his neighbours ->{0}",
                                                    CheckNeighboursInArray(array, position));
    }


    public static bool CheckNeighboursInArray(int[] array, int position)
    {
        bool isBigger = false;

        if (array[position] == 0)
        {
            if (array[position] > array[position + 1])
            {
                isBigger = true;
            }
        }
        if (array[position] == array.Length)
        {
            if (array[position] > array[position - 1])
            {
                isBigger = true;
            }
        }
        if ((array[position] > 0) && (array[position] < array.Length))
        {
            if ((array[position - 1] < array[position]) && (array[position] > array[position + 1]))
            {
                isBigger = true;
            }
        }
        return isBigger;
    }
}




