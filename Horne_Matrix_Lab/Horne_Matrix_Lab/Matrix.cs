/*************************************************************************
 * File Name         :  Matrix.cs
 * Purpose            : Represents a matrix. Allows adding of 2 matrices
 *                          with + operator, setting of values in a specific 
 *                          matrix location, and printing of matrix values.
 *                          
 * Author               : Austin Horne    E-mail: hornew@goldmail.etsu.edu       
 * Course               : CSCI 3230 - Algorithms
 * Create Date       : February 11, 2013
 * 
 * Modified Date    : February 11, 2013
 * Modified by       : Austin Horne
**************************************************************************
*/
using System;

namespace Horne_Matrix_Lab
{
    class Matrix
    {
        private int nRows;               //stores the number of rows for the matrix
        private int nCols;               //stores the number of columns for the matrix
        private double[,] m;             //2D array that stores the matrix values

        public Matrix(int rows, int col)
        {
            this.nCols = col;
            this.nRows = rows;
            m = new double[nRows, nCols];
        }//2 param constructor

        //Place a value in the 2D array at row, col
        public void SetValue(int row, int col, double value)
        {
            m[row, col] = value;
        }//SetValue(int, int, double)

        //Return the 2D array row by row as a string.
        public string PrintM()
        {
            string print = String.Empty;

            for (int i = 0; i < nRows; i++) //step through each row in the matrix
            {
                for (int k = 0; k < nCols; k++) //print each column in the current row
                {
                    print += m[i, k] + " ";
                }

                print += "\n";
            }

            return print;
        }//PrintM()

        /// <summary>
        /// overload the + operator to give ability to add Matrices
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Matrix operator+ (Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.nRows, A.nCols);
            double sum;

            for (int i = 0; i < A.nRows; i++)
            {
                for (int k = 0; k < A.nCols; k++)
                {
                    sum = A.m[i,k] + B.m[i,k];
                    C.SetValue(i, k, sum);
                }
                                
            }

            return C;
        }//operator+ (Matrix, Matrix)

    }//class
}//namespace
