using System;

class RectangularMatrix 
{
    static void Main()
    {
        Console.Write("Enter for matrix N = ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter for matrix M = ");
        int n = int.Parse(Console.ReadLine());

        int bestSum=int.MinValue;
        int bestRow=0;
        int bestCol=0;
        int sum=0;

        int[,] matrix = new int[n, m];


        for (int row = 0; row < n; row++)
        {

            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[m, n] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
        
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, (col + 1)] + matrix[row, (col + 2)] +
                    matrix[(row + 1), col] + matrix[(row + 1), (col + 1)] + matrix[(row + 1), (col + 2)] +
                    matrix[(row + 2), col] + matrix[(row + 2), (col + 1)] + matrix[(row + 2), (col + 2)];

                if (bestSum < sum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("The best sum 3x3 = {0}",bestSum);
        Console.WriteLine("  {0} {1} {2}",
                             matrix[bestRow, bestCol],
                             matrix[bestRow, bestCol + 1],
                             matrix[bestRow, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}",
                             matrix[bestRow+1, bestCol],
                             matrix[bestRow+1, bestCol + 1],
                             matrix[bestRow+1, bestCol + 2]);

        Console.WriteLine("  {0} {1} {2}",
                             matrix[bestRow + 2, bestCol],
                             matrix[bestRow + 2, bestCol + 1],
                             matrix[bestRow + 2, bestCol + 2]);
    }
}

