using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter N<20, N= ");
        int n = int.Parse(Console.ReadLine());
        int row = 0;
        

        for (row = 1; row <= n; row++)
        {
            Console.Write(row);
            for (int col = row; col < n+row; col++)
            {
                col++;
                Console.Write("{0,7}", col);
                col--;
            }
            Console.WriteLine();
        }
    }
}


