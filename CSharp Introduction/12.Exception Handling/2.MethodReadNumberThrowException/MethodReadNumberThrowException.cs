using System;

class MethodReadNumberThrowException
{

    static void Main(string[] args)
    {
        int start = 1;
        int end = 100;

        
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            try
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
                ReadNumber(start, end, number);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Enter number, not text or space !!!");
            }
        }
        PrintArray(arr);
    }

    private static void PrintArray(int[] arr)
    {
        foreach (int number in arr)
        {
            Console.Write(number + " ");
        }
    }

    private static int ReadNumber(int start,int end,int number)
    {
        if (number < start || number > end)
        {
            throw new System.ArgumentOutOfRangeException("Enter number>start and number<end");
        }
        return number;
    }
}
        
        