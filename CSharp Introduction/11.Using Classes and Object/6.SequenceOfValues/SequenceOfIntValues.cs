using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.SequenceOfValues
{
    class SequenceOfIntValues
    {
        static void Main()
        {
            string sequence= "0 25 30 17 20 18 32";
            sequence = sequence.Trim();

            int result = 0;
            string[] strNums = sequence.Split(' ');
            for (int i = 0; i < strNums.Length; i++)
            {
                result =result + int.Parse(strNums[i].Trim());
            }
            Console.WriteLine("The sum of {0} = {1}",sequence,result);
        }
    }
}

          
 
 