using System;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
    {
        static void Main()
        {
            Random r = new Random();
            List<double> array = new List<double>();
            MergeSortLab ms;
            int N;
            string input;

            Console.WriteLine("How many values in the list?");
            input = Console.ReadLine();
            N = Int32.Parse(input);

            for (int i = N; i > 0; i--) //add random values to List of
            {
                array.Add(r.NextDouble() * 100);
            }

            ms = new MergeSortLab(array);

            Console.WriteLine();
            for (int i = 0; i < ms.Array.Count - 1; i++)
            {
                Console.WriteLine(ms.Array[i]);
            }
            
        }//main
    }
}
