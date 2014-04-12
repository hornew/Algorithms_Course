/************************************************************************
 * File Name         : MaxHeap.cs
 * Purpose            : Represents a maximum heap of strings. Allows element
 *                        : insertion, extraction, sorting and printing.
 *                          
 * Author             : Austin Horne     E-mail: hornew@goldmail.etsu.edu       
 * Course             : CSCI 3230 - Algorithms
 * 
 * Date                 : April 10, 2013
 * Modified by       : Austin Horne
*************************************************************************
*/
using System;

namespace HeapInsertLab
{
    class MaxHeap
    {
        public int Size { get; set; }
        public int MaxSize { get; set; }
        public string[] H { get; set; }

        /// <summary>
        /// Constructor. Accepts the maximum number of items in the heap and constructs the heap of size "max"
        /// </summary>
        /// <param name="max"></param>
        public MaxHeap(int max)
        {
            this.Size = 0;
            this.MaxSize = max++;

            H = new string[max];                        
        }//MaxHeap()

        /// <summary>
        /// Returns a string representing the values in the heap
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            string output = "";
            int s = this.Size + 1;

            //add heap values with spaces in between
            for (int i = 1; i < s; i++)
            {
                output += this.H[i] + " "; 
            }

            return output;
        }//Print()

        /// <summary>
        /// Inserts an item at the end of the heap. Reorders the heap if the item is out of position.
        /// </summary>
        /// <param name="item"></param>
        public void Insert(string item)
        {            
            this.Size++;
            H[Size] = item;    //insert item into last node in the heap

            if (Size > 1)
            {
                int height = (int)Math.Log(Size, 2);    //find the height of the heap
                int index = Size;                //mutable index starting at Size of the heap.
                int parent;

                //up to the height of the tree, swap the child and parent if the child has a greater ordinal
                for (int i = 0; i < height; i++)
                {
                    parent = index >> 1;
                    if (String.CompareOrdinal(H[index], H[parent]) > 0)
                    {
                        Swap(index, (parent));
                        index = parent;
                    } //value swapping if 

                }//parent checking for
            }
        }//insert

        /// <summary>
        /// Swap the last item in the heap with the root and decrease size by 1.
        /// Re-order the tree if out of order.
        /// </summary>
        public void ExtractMax()
        {
            int parent = 1;             //start at the root
            int child = parent << 1;    //left child of the root, initially
            Swap(Size, parent);         //swap the root and the last element

            Size--;
            
            int height = (int) Math.Log(Size, 2);

            for (int i = 0; i < height; i++)
            {
                //If there is a right child and its value is larger than the left child, compare parent to right child instead
                if ((child + 1) < Size && String.CompareOrdinal(H[child + 1], H[child]) > 0)
                    child++;

                if (child < Size && String.CompareOrdinal(H[child], H[parent]) > 0) //if parent is less than child, swap
                {
                    Swap(parent, child);
                    parent = child;
                    child = parent << 1;
                }
                else
                    break;
            }//for

            
        }//ExtactMax()

        public void HeapSort()
        {
            while (Size > 0)
            {
                ExtractMax();
            }
        }//HeapSort()

        /// <summary>
        /// Place the items of the heap in a String for printing purposes.
        /// </summary>
        /// <returns></returns>
        public void Print_Array()
        {
            foreach (string s in H)
            {
                Console.WriteLine(s);
            }
        }

        //swap 2 values in the heap
        public void Swap(int a, int b)
        {
            string temp = H[a];
            H[a] = H[b];
            H[b] = temp;
        }//swap
    }//class
}
