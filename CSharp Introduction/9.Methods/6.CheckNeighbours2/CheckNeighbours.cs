using System;

class CheckNeighbours
{
    static void Main()
    {
        int[] array = new int[] { 0, 5, 7, 1, 6, 2, 5, 12, 20, 16, 6 };

        int arrayLenght = array.Length;
        if (GetPosition(array, arrayLenght) != -1)
        {
            Console.WriteLine("Position of the biiger than neighbours is {0}", GetPosition(array, arrayLenght));
        }
        else 
        {
            Console.WriteLine("No such element in array");
        }
    }

    private static int GetPosition(int[] array, int arrayLenght)
    {
        int position = -1;
        for (int i = 1; i < arrayLenght - 1; i++)
        {
            if ((array[i] > array[i + 1]) && (array[i] > array[i - 1]))
            {
                position = i;
            }
        }
        return position;
    }
}

