using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class MergeSortLab
    {
        public List<double> Array { get; set; }

        public MergeSortLab(List<double> X)
        {
            Array = MergeSort(X);
        }//constructor

        /// <summary>
        /// Recursively splits the List and then calls Merge function to merge the Lists back into a single List
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public List<double> MergeSort(List<double> array)
        {
            int middle = array.Count >> 1;
            List<double> A;
            List<double> B;

            if (array.Count == 1)   //base case
            {
                return array;
            }

            A = MergeSort(array.Take(middle).ToList()); //linq expressions used to split the list in half
            B = MergeSort(array.Skip(middle).ToList());

            return Merge(A, B);
        } //MergeSort

        /// <summary>
        /// Merge 2 sorted lists together in sorted order
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public List<double> Merge(List<double> A, List<double> B)
        {
            List<double> C = new List<double>(A.Count << 1 + 1); //List that will be returned

            int i; //iterator for List A
            int j; //iterator for List B

            for (i = 0, j = 0; i < A.Count && j < B.Count; )  //Merge the lists until one list runs out of elements
            {
                if (A[i] < B[j]) //smaller element added to list C first
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

}//namespace
