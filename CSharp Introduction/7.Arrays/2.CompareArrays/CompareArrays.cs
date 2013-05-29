using System;

class CompareArrays
{
    static void Main()
    {
        bool result = true;
        Console.Write("Enter array1 lenght=");
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];

        Console.Write("Enter array2 lenght=");
        int m = int.Parse(Console.ReadLine());
        int[] array2 = new int[m];

        if (m == n)
        {
            for (int index = 0; index < array1.Length; index++)
            {
                Console.WriteLine("Enter number for array1");
                array1[index] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Enter number for array2");
                array2[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array1);
            Array.Sort(array2);

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    result=false;
                    break;
                }
            }
            Console.WriteLine("array1=array2 ? - {0}",result);
        }
        else
        {
            Console.WriteLine("array1 is not = array2.They must be with same lenght!!!");
        }
    }
}



