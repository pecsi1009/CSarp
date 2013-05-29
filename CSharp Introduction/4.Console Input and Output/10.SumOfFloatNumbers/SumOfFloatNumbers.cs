using System;

class SumOfFloatNumbers
{
    static void Main()
    {
        float a = 1.0f;
        for (float i = 2; 1 / i >= 0.001; i++)
        {
            if (i % 2 == 0)
            {
                a = a +( 1 / i);
            }
            else
            {
                a = a - (1 / i);
            }
        }
        Console.WriteLine("The sum of the numbers is={0:0.000}", a);  
    }
 }

