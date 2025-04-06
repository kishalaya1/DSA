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


        #region RemoveDuplicateCharacters

        /// <summary>
        /// This function removes duplicate characters from a string.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string RemoveDuplicateChars(string word)
        {
            string traversedChars = string.Empty;
            if (!string.IsNullOrEmpty(word))
            {
                foreach (char individualChar in word)
                {
                    traversedChars = CleanAppendDistinctChars(traversedChars, individualChar);
                }
            }
            return traversedChars;
        }

        /// <summary>
        /// This function checks if the character is unique and appends it to the traversed characters string.
        /// </summary>
        /// <param name="traversedChars"></param>
        /// <param name="individualChar"></param>
        /// <returns></returns>
        private static string CleanAppendDistinctChars(string traversedChars, char individualChar)
        {
            if (individualChar != ' ')
            {
                if (IsCharUnique(traversedChars, individualChar))
                {
                    traversedChars = AppendChar(traversedChars, individualChar);
                }
            }

            return traversedChars;
        }

        /// <summary>
        /// This function checks if the character is unique in the appended characters string.
        /// </summary>
        /// <param name="traversedChars"></param>
        /// <param name="individualChar"></param>
        /// <returns></returns>
        private static bool IsCharUnique(string traversedChars, char individualChar)
        {
            return traversedChars.IndexOf(individualChar) == -1;
        }

        /// <summary>
        /// This function appends the character to a string.
        /// </summary>
        /// <param name="traversedChars"></param>
        /// <param name="individualChar"></param>
        /// <returns></returns>
        private static string AppendChar(string traversedChars, char individualChar)
        {
            return traversedChars + individualChar;
        }
        #endregion

    }
}
