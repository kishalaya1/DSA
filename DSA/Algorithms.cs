using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Algorithms
    {
        #region BubbleSortAlgo
        /// <summary>
        /// Bubble Sort Algorithm main function
        /// </summary>
        /// <param name="array">nos to be sorted</param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] array)
        {
            int n = array.Length;
            int[] sortedArray = (int[])array.Clone();
            for (int i = 0; i < n - 1; i++)
            {
                PerformSinglePass(sortedArray, n, i);
            }
            return sortedArray;
        }

        private static void PerformSinglePass(int[] array, int n, int i)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(array, j, j + 1);
                }
            }
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        #endregion
    }
}
