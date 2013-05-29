using System;

class SequenceWithFirst10Members
{
    static void Main()
    {
        int i;
        for (i = 2; i < 12; i++)
        {
            int res = i % 2;
            if (res != 0)
            {
                Console.Write(i * (-1)+",");
            }
            else
            {
                Console.Write(i+",");
            }

        }
    }
}

