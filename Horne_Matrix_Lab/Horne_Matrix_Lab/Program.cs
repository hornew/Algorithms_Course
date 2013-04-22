/*************************************************************************
 * File Name         : Program.cs
 * Purpose           : Driver for matrix program. Asks the user to 
 *                     enter sizes and values for 2 matrices. Adds the
 *                     2 matrices and prints the resulting matrix.
 *                          
 * Author            : Austin Horne    E-mail: hornew@goldmail.etsu.edu       
 * Course            : CSCI 3230 - Algorithms
 * Create Date       : February 11, 2013
 * 
 * Modified Date     : February 11, 2013
 * Modified by       : Austin Horne
**************************************************************************
*/
using System;

namespace Horne_Matrix_Lab
{
    class Program
    {
        static void Main()
        {
            Matrix A, B, C;
            string input;
            int Arow, Acol, Brow, Bcol;
            double val;
            
            //ask for rows of matrix A. Parse value from keyboard
            Console.WriteLine("\n\nEnter the number of rows for matrix A");
            input = Console.ReadLine();
            Int32.TryParse(input, out Arow);
            
            //ask for columns of matrix A. Parse value from keyboard
            Console.WriteLine("Enter the number of columns for matrix A");
            input = Console.ReadLine();
            Int32.TryParse(input, out Acol);
            
            //create matrix A
            A = new Matrix(Arow, Acol);

            Console.WriteLine("Enter values for the matrix until the matrix is full\n");                                                        

            //enter values sequentially into matrix.
            for (int i = 0; i < Arow; i++)
            {
                for (int k = 0; k < Acol; k++)
                {
                    Console.Write("Value: ");
                    input = Console.ReadLine();
                    Double.TryParse(input, out val);

                    A.SetValue(i, k, val);
                }//for
            }//for

            //ask for rows of matrix B. Parse value from keyboard
            Console.WriteLine("\n\nEnter the number of rows for matrix B");
            input = Console.ReadLine();
            Int32.TryParse(input, out Brow);

            //ask for columns of matrix B. Parse value from keyboard
            Console.WriteLine("Enter the number of columns for matrix B");
            input = Console.ReadLine();
            Int32.TryParse(input, out Bcol);

            //create matrix B
            B = new Matrix(Arow, Bcol);     

            Console.WriteLine("Enter values for the matrix until the matrix is full\n");

            //enter values sequentially into matrix.
            for (int i = 0; i < Arow; i++)
            {
                for (int k = 0; k < Bcol; k++)
                {
                    Console.Write("Value: ");
                    input = Console.ReadLine();
                    Double.TryParse(input, out val);

                    B.SetValue(i, k, val);
                }//for
            }//for

            //print the result of adding the 2 matrices if the matrices are the same size. Notify if they are not
            try
            {
                C = A + B;  //add matrices. Uses overloaded + operator in Matrix class
                Console.WriteLine("\n\nResulting matrix\n" + C.PrintM());
            }
            catch (Exception)
            {
                Console.WriteLine("\n\nMatrices are not equal in size and cannot be added.");
            }


        }//main

    }//class

}//namespace
