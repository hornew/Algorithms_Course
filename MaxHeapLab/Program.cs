/************************************************************************
 * File Name         : Program.cs
 * Purpose            : Driver for HW5. First input accepted is the number of
 *                          strings to place in the max heap. All following inputs
 *                          are the strings themselves.
 *                          
 * Author             : Austin Horne     E-mail: hornew@goldmail.etsu.edu       
 * Course             : CSCI 3230 - Algorithms
 * 
 * Date                 : April 10, 2013
 * Modified by       : Austin Horne
*************************************************************************
*/
using System;
using System.Diagnostics;

namespace HeapInsertLab
{
    class Program
    {
        static void Main()
        {
            int num;        //max number of strings in the heap
            string input;   //from keyboard
            MaxHeap m;      //module containing all heap functions

            //get the max number of strings in the heap
            input = Console.ReadLine();
            Int32.TryParse(input, out num);

            //create heap of max size "num"
            m = new MaxHeap(num);

            Stopwatch sw = Stopwatch.StartNew();
            //get all the strings from input
            for (int i = 0; i < num; i++)
            {
                input = Console.ReadLine();
                m.Insert(input);
            }
            Console.Write(num);
            m.HeapSort();                       //sort the heap
            sw.Stop();
            m.Print_Array(); //print sorted elements
            Console.WriteLine("\nElapsed time in seconds: " + sw.ElapsedMilliseconds);
            
        }//main
    }//class
}//namespace
