using System;

class TwoCharArrays
{
    static void Main()
    {
        bool result = true;
        char [] array1 = { 'P', 'e', 't', 'y', 'a'};
        char [] array2 = {'P', 'e', 's', 'h', 'o'};

        int lenght1 = array1.Length;
        int length2 = array1.Length;

        if (lenght1 == length2)
        {

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("array1[{0}] = {1}", i, array1[i]);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("array2[{0}] = {1}", i, array2[i]);
            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    result = false;
                    break;
                }
            }
            Console.WriteLine("array1 = array2 ? -> {0}", result);
        }
        else if (lenght1 > length2)
        {
            Console.WriteLine("array1 is lexicographically longer than array2");
        }
        else
        {
            Console.WriteLine("array1 is lexicographically shorter than array2");
        }
    }
}

