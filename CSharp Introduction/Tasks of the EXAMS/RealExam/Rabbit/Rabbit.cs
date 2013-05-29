using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class Rabbit
{
    static void Main()
    {

        string terein = "1, -2, -3, 4";     //Console.ReadLine();
        char[] separator = new char[] { ',' };
        string[] numbers = terein.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int n = numbers.Length * numbers.Length;
        StringBuilder sb = new StringBuilder(n);
        StringBuilder end = new StringBuilder(n);
        bool jump = false;
    
        int bestResult = 0;

        
        while (sb.Length < n)
        {
            foreach (var num in numbers)
            {
                sb.Append(num);

            }
        }
       
        for (int i = 0 ; i <numbers.Length-1; i++)
        {
            for (int j = i+1; j < numbers.Length; j++)
            {
                if (sb[i] < sb[j])
                {
                    jump = true;
                }
                if (jump)
                {
                    sb.CopyTo(i,)
                    int p = j + j + 1;
                    if (sb[j] < sb[p])
                    {
                       
                    }
                    jump = false;
                }
            }
        }
        Console.WriteLine();
    }
}
        

