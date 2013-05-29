using System;

class MarixArrayFill
{
    static void Main()
    {
        Console.Write("Enter size of matrix: n = ");
        int n = int.Parse(Console.ReadLine());

        int cellCount = 1;
        int[,] matrix = new int[n, n];


        /*****************************************************
                                    A)
        *****************************************************/

        for (int col = 0; col < n; col++)
        {
           for (int row = 0; row < n; row++)
            {
                matrix[row, col] = cellCount;
               cellCount++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("A)");
        PrintCircle(n, matrix);

        /*****************************************************
                                    B)
        *****************************************************/

        for (int col = 0; col < n; col++)
        {
            if ((col % 2) == 0)
            {
               for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = cellCount;
                   cellCount++;
                }
                Console.WriteLine();
            }
            else
            {
               for (int row = n - 1; row >= 0; row--)
                {
                   matrix[row, col] = cellCount;
                    cellCount++;
                }
            }
        }
        Console.WriteLine("B)");
        PrintCircle(n, matrix);


        /*****************************************************
                                    C)
        *****************************************************/
        int tempRow = n - 1;
        int tempCol = 0;
        int startRow = tempRow;
        int startCol = tempCol;

        while (cellCount <= n)
        {
            while (tempCol < n && tempRow < n)
            {
                matrix[tempRow, tempCol] = cellCount;
                cellCount++;
                tempRow++;
                tempCol++;
            }
            if (startRow == 0)
            {
                startCol++;
            }
            else
            {
                startRow--;
            }
            tempCol = startCol;
            tempRow = startRow;
        }
        Console.WriteLine(")");
        PrintCircle(n, matrix);
}

    /*************************************************/


    private static void PrintCircle(int n, int[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,6}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}


