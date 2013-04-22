using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class MergeSortLab
    {
        public List<double> array { get; set; }

        public MergeSortLab(List<double> X)
        {
            array = MergeSort(X);

        }
        public MergeSortLab(List<double> X, List<double> Y)
        {
            array = Merge(X, Y);
        }//
        public MergeSortLab(int n)
        {
            Random r = new Random();
            array = new List<double>(n);

            for (int i = 0; i < array.Count; i++)
            {
                array.Add(r.Next(n));
            }
        }//constructor

        public List<double> MergeSort(List<double> array)
        {
            int middle = array.Count / 2;
            List<double> A;
            List<double> B;

            if (array.Count == 1)
            {
                return array;
            }

            A = MergeSort(array.Take<double>(middle).ToList());
            B = MergeSort(array.Skip<double>(middle).ToList());

            return Merge(A, B);
        } //MergeSort

        //Merge 2 sorted lists together in sorted order
        public List<double> Merge(List<double> A, List<double> B)
        {
            List<double> C = new List<double>(A.Count * 2 + 1); //List that will be returned

            int i; //iterator for List A
            int j; //iterator for List B

            for (i = 0, j = 0; i < A.Count && j < B.Count; )
            {
                if (A[i] < B[j])
                {
                    C.Add(A[i]);
                    i++;
                }
                else
                {
                    C.Add(B[j]);
                    j++;
                }
            }

            if (j < B.Count) //if List B still has items, add remaining items of B to end of List C
            {
                for (; j < B.Count; j++)
                {
                    C.Add(B[j]);
                }                
            }
            else if (i < A.Count) //if List A still has items, add remaining items of A to end of List C
            {
                for (; i < A.Count; i++)
                {
                    C.Add(A[i]);
                }
            }
            return C;

        }//Merge

    }//class
}
