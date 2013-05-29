using System;
using System.Linq;
using System.IO;

class ReadsFileWithMatrixAndFoundMaxSum
{
    static void Main()
    {
        StreamReader file1 = new StreamReader("text.txt");
        string line = file1.ReadLine();
        int n = int.Parse(line);
        int[,] matrix = new int [n,n];

        using (file1)
        {
            while (line != null)
            {
                int bestSum = int.MinValue;

                for (int row = 0; row < n; row++)
                {
                    string[] numbers = file1.ReadLine().Split(' ');

                    for (int col = 0; col < n; col++)
                    {
                        matrix[row, col] = int.Parse(numbers[col]);
                    }
                }
             
                bestSum = TakeBestSum(matrix, bestSum);
       
                StreamWriter newFile = new StreamWriter("newFile.txt", false);
                using (newFile)
                {
                    bestSum.ToString();
                    newFile.WriteLine(bestSum);
                }
            }
        }
    }

    private static int TakeBestSum(int[,] matrix, int bestSum)
    {
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {

                int sum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }
        return bestSum;
    }

    
}

