using System;

class TheLongestSequenceInMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter row for matrix n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter col for matrix m=");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        string bestElementHor = "null";
        string bestElementVer = "null";
        string bestElementDiag1 = "null";
        string bestElementDiag2 = "null";
        string bestElement1 = "null";
        string bestElement2 = "null";

        int bestCountHor = 1;
        int bestCountVer = 1;
        int bestCountDiag1 = 1;
        int bestCountDiag2 = 1;
        int bestCount1 = 1;
        int bestCount2 = 1;

        int count = 1;
        int currentRow = 1;
        int currentCol = 0;

        /*string[,] matrix ={
                             {"pi", "ha", "fo", "pi"},
                             {"ha", "pi", "pi", "fo"},
                             {"ha", "fo", "fo", "pi"},
                         };*/

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.WriteLine("Enter strings:");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("matrix[{0},{1}]=", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,6}",matrix[row,col]);
            }
            Console.WriteLine();
        }
      //--------------------------------Horizontal-------------------------//
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    count++;
                }
                if (bestCountHor < count)
                {
                    bestElementHor = matrix[row, col];
                    bestCountHor = count;
                }
                count = 1;
            }
            //Console.WriteLine("{0} -> {1}times", bestElementHor, bestCountHor); -->middle check
        }
        //-----------------------------------Vertical-------------------------//
        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    count++;
                }
                if (bestCountVer < count)
                {
                    bestElementVer = matrix[row, col];
                    bestCountVer = count;
                }
                count = 1;
            }
        } 
        //Console.WriteLine("{0} -> {1}times", bestElementVer, bestCountVer);

        if(bestCountHor>bestCountVer)
        {
            bestCount1=bestCountHor;
            bestElement1=bestElementHor;
        }
        else
        {
            bestCount1=bestCountVer;
            bestElement1=bestElementVer;
        }
        // Console.WriteLine("{0} -> {1}times", bestElement1, bestCount2);
       
        //-------------------------------------Diagonals-------------------------//
                /* Main and diagonals above*/
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int row=0, col = currentCol;
                row < matrix.GetLength(0)-1 && col < matrix.GetLength(1) - 1;
                row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    count++;
                }
                if (bestCountVer < count)
                {
                    bestElementDiag1 = matrix[row, col];
                    bestCountDiag1 = count;
                }
                count = 1;
            }
            currentCol++;
        }
        //Console.WriteLine("{0} -> {1}times", bestElementDiag1, bestCountDiag1);

                     /* Diagonals under main*/

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int row = currentRow, col = 0;
                row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1;
                row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    count++;
                }
                if (bestCountVer < count)
                {
                    bestElementDiag2 = matrix[row, col];
                    bestCountDiag2 = count;
                }
                count = 1;
            }
            currentRow++;
        }
        //Console.WriteLine("{0} -> {1}times", bestElementDiag2, bestCountDiag2);

        if(bestCountDiag1>bestCountDiag2)
        {
            bestCount2=bestCountDiag1;
            bestElement2=bestElementDiag1;
        }
        else
        {
            bestCount2=bestCountDiag2;
            bestElement2=bestElementDiag2;
        }
        //Console.WriteLine("{0} -> {1}times", bestElement2, bestCount2);

        /*----------------------------The End------------------------*/
        int bestCount=0;
        string bestElement="null";

        if (bestCount1 > bestCount2)
        {
            bestCount = bestCount1;
            bestElement = bestElement1;
        }
        else 
        {
            bestCount = bestCount2;
            bestElement = bestElement2;
        }
        Console.WriteLine("{0} -> {1}times", bestElement, bestCount);
    }
}

