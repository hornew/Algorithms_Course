using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<double> array = new List<double>();
            List<double> array2 = new List<double>();
            MergeSortLab ms;
            int N;
            string input;

            Console.WriteLine("How many values in the list?");
            input = Console.ReadLine();
            N = Int32.Parse(input);

            for (int i = N; i > 0; i--) //add random values to List of
            {
                array.Add(i);
                array.Add(i+1);
                array.Add(i-1);
                array.Add(i);
            }

            ms = new MergeSortLab(array);

            for (int i = ms.array.Count - 1; i > 0; i--)
            {
                Console.WriteLine(ms.array[i]);
            }
            
        }//main
    }
}
