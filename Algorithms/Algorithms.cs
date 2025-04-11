using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
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

        #region Anagram detection
        public static bool AreAnagrams(string firstWord, string secondWord)
        {
            bool areAnagrams = false;
            if (!IsInputEmpty(firstWord, secondWord))
            {
                // clean and sort the characters of both words
                var sortedWords = GetCleanSortedCharArrays(firstWord, secondWord);
                // Compare the sorted character arrays
                areAnagrams = AreBothCharArraysEqual(sortedWords);

            }
            return areAnagrams;
        }

        /// <summary>
        /// this function compares the sorted character arrays of both words.
        /// </summary>
        /// <param name="sortedTuple"></param>
        /// <returns></returns>
        private static bool AreBothCharArraysEqual((char[] firstSorted, char[] secondSorted) sortedTuple)
        {
            return string.Equals(new string(sortedTuple.firstSorted), new string(sortedTuple.secondSorted), StringComparison.OrdinalIgnoreCase);
        }

        private static bool IsInputEmpty(string firstWord, string secondWord)
        {
            return string.IsNullOrEmpty(firstWord) || string.IsNullOrEmpty(secondWord);
        }

        /// <summary>
        /// This function trims and sorts the characters of both words and returns them as a tuple.
        /// </summary>
        /// <param name="firstWord"></param>
        /// <param name="secondWord"></param>
        /// <returns></returns>
        public static (char[] firstSorted, char[] secondSorted) GetCleanSortedCharArrays(string firstWord, string secondWord)
        {
            char[] firstWordChars = firstWord.Trim().ToUpper().ToCharArray();
            char[] secondWordChars = secondWord.Trim().ToUpper().ToCharArray();

            Array.Sort(firstWordChars);
            Array.Sort(secondWordChars);

            return (firstWordChars, secondWordChars);
        }


        #endregion

        #region Palindrome Detection

        public static bool IsPalindrome(string word)
        {
            int forwardCounter = 0;
            int reverseCounter = word.Length - 1;

            while (forwardCounter <= reverseCounter)
            {
                char forwardPosChar = word[forwardCounter];
                char reversePosChar = word[reverseCounter];

                if (char.ToLower(forwardPosChar) != char.ToLower(reversePosChar))
                {
                    return false;
                }
                forwardCounter++;
                reverseCounter--;
            }
            return true;
        }


        #endregion

        #region Heterogram Detection

        /// <summary>
        /// This function checks if a word has all unique characters.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool IsHeterogram(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                HashSet<char> charsInWord = new HashSet<char>();
                foreach (char c in word.ToLower())
                {
                    if (charsInWord.Contains(c))
                    {
                        return false; // Duplicate character found
                    }
                    charsInWord.Add(c);
                }
            }
            return true; // No duplicates found
        }
        #endregion

        #region Get All Subtstrings

        /// <summary>
        /// This function fetches all substrings from a word
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static List<string> GetAllSubstrings(string word)
        {
            List<string> subStrings = new List<string>();
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    for (int j = i + 1; j <= word.Length; j++)
                    {
                        subStrings.Add(word.Substring(i, j - i));
                    }
                }
            }
            return subStrings;
        }

        #endregion

        #region Factors of a number

        /// <summary>
        /// This function returns the factors of a number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> GetFactors(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }
            }
            return factors;
        }

        #endregion

        #region HCF of a number

        /// <summary>
        /// This function calculates the HCF of an array of numbers.
        /// </summary>
        /// <param name="numbers">Array of integers</param>
        /// <returns>HCF of the numbers</returns>
        public static int GetHCFOfNos(params int[] numbers)
        {
            if (numbers.Any())
            {
                int hcf = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    hcf = GetHCF(hcf, numbers[i]);
                }
                return hcf;
            }
            return 1;
        }

        /// <summary>
        /// This function calculates the HCF (Highest Common Factor) of two numbers.
        /// </summary>
        /// <param name="firstNo">First number</param>
        /// <param name="secondNo">Second number</param>
        /// <returns>HCF of the two numbers</returns>
        private static int GetHCF(int firstNo, int secondNo)
        {
            while (secondNo != 0)
            {
                int temp = secondNo;
                secondNo = firstNo % secondNo;
                firstNo = temp;
            }
            return Math.Abs(firstNo); // Ensure the result is always positive
        }

        #endregion

    }
}
