/*
    8.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
    9.Implement an indexer this[row, col] to access the inner matrix cells.
    10.Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).
 */

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Matrix<Т>
    {
        //Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
        private T[,] matrix;
        private readonly int rows;
        private readonly int cols;

        // properties
        public int Rows
        {
            get
            {
                return rows;
            }
        }

        public int Cols
        {
            get
            {
                return cols;
            }
        }

        //indexer this[row, col]
        public T this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < rows && col >= 0 && col < cols)
                {
                    return data[row, col];
                }
                else
                {
                    throw new MatrixException(String.Format("Cell ({0}, {1}) is invalid.", row, col));
                }
            }
            set
            {
                if (row >= 0 && row < rows && col >= 0 && col < cols)
                {
                    data[row, col] = value;
                }
                else
                {
                    throw new MatrixException(String.Format("Cell ({0}, {1}) is invalid.", row, col));
                }
            }
        }




    }

