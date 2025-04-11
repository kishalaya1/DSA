using Algorithms;
using Algo = Algorithms.Algorithms;
using NUnit.Framework.Legacy;
using System.Collections;




namespace TestDSA
{
    public class AlgorithmTest
    {
        // This is a test class for the Algorithms class
        // It contains unit tests for the BubbleSort method
        // Add any necessary using directives here
        // Add any necessary attributes here
        // This method runs before each test in this class
        // You can use it to set up any common resources needed for the tests

        [SetUp]
        public void Setup()
        {
        }

        #region BubbleSort Algorithm Unit test case scenarios 

       
        public static IEnumerable BubbleSortTestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 64, 34, 25, 12, 22, 11, 90 }, new int[] { 11, 12, 22, 25, 34, 64, 90 });
                yield return new TestCaseData(new int[] { 5, 3, 8, 4, 2 }, new int[] { 2, 3, 4, 5, 8 });
                yield return new TestCaseData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 });
                yield return new TestCaseData(new int[] { 9, 7, 5, 3, 1 }, new int[] { 1, 3, 5, 7, 9 });
                yield return new TestCaseData(new int[] { 9, 28, 35, 54, 52, 2, 0 }, new int[] { 0, 2, 9, 28, 35, 52, 54 });
                yield return new TestCaseData(new int[] { }, new int[] { });
            }
        }

        [Test, TestCaseSource(nameof(BubbleSortTestCases))]
        public void BubbleSort_SortsArrayCorrectly(int[] unsortedArray, int[] expectedSortedArray)
        {
            // Act
            int[] sortedArray = Algo.BubbleSort(unsortedArray);

            // Assert
            CollectionAssert.AreEqual(expectedSortedArray, sortedArray);
        }

        #endregion

        #region removeDuplicateChar unit test case scenarios     

        public static IEnumerable RemoveDuplicateCharsTestCases
        {
            get
            {
                yield return new TestCaseData("hello", "helo");
                yield return new TestCaseData("world", "world");
                yield return new TestCaseData("aabbcc", "abc");
                yield return new TestCaseData("abcabc", "abc");
                yield return new TestCaseData("", "");
                yield return new TestCaseData("a", "a");
                yield return new TestCaseData("Mississippi", "Misp");
                yield return new TestCaseData("voodoo", "vod");
                yield return new TestCaseData("aa", "a");
            }
        }


        [Test, TestCaseSource(nameof(RemoveDuplicateCharsTestCases))]
        public void RemoveDuplicateChars_RemovesDuplicatesCorrectly(string input, string expected)
        {
            // Act
            string result = Algo.RemoveDuplicateChars(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion

        #region AreAnagrams unit test case scenarios

        public struct AnagramTestCase
        {
            public string FirstWord { get; }
            public string SecondWord { get; }
            public bool Expected { get; }

            public AnagramTestCase(string firstWord, string secondWord, bool expected)
            {
                FirstWord = firstWord;
                SecondWord = secondWord;
                Expected = expected;
            }
        }

        public static IEnumerable AreAnagramsTestCases
        {
            get
            {
                yield return new TestCaseData(new AnagramTestCase("listen", "silent", true));
                yield return new TestCaseData(new AnagramTestCase("triangle", "integral", true));
                yield return new TestCaseData(new AnagramTestCase("apple", "pale", false));
                yield return new TestCaseData(new AnagramTestCase("rat", "car", false));
                yield return new TestCaseData(new AnagramTestCase("night", "thing", true));
                yield return new TestCaseData(new AnagramTestCase("dusty", "study", true));
                yield return new TestCaseData(new AnagramTestCase("", "", false));
                yield return new TestCaseData(new AnagramTestCase("a", "a", true));
                yield return new TestCaseData(new AnagramTestCase("a", "b", false));
                yield return new TestCaseData(new AnagramTestCase("rat", "rats", false));
            }
        }

        [Test, TestCaseSource(nameof(AreAnagramsTestCases))]
        public void AreAnagrams_DetectsAnagramsCorrectly(AnagramTestCase testCase)
        {
            // Act
            bool result = Algo.AreAnagrams(testCase.FirstWord, testCase.SecondWord);

            // Assert
            Assert.That(result, Is.EqualTo(testCase.Expected));
        }

        #endregion

        #region Palindrome unit test case scenarios

        public static IEnumerable IsPalindromeTestCases
        {
            get
            {
                yield return new TestCaseData("racecar", true); // Palindrome
                yield return new TestCaseData("RaceCar", true); // Case-insensitive palindrome
                yield return new TestCaseData("hello", false);  // Not a palindrome
                yield return new TestCaseData("A", true);       // Single character
                yield return new TestCaseData("", true);        // Empty string
                yield return new TestCaseData("madam", true);   // Palindrome
                yield return new TestCaseData("Madam", true);   // Case-insensitive palindrome
                yield return new TestCaseData("step on no pets", true); // Not ignoring spaces
                yield return new TestCaseData("Malayalam", true);
                yield return new TestCaseData("civic", true);
                yield return new TestCaseData("hannah", true);
                yield return new TestCaseData("tattarrattat", true);//longest palindrome in english
            }
        }

        [Test, TestCaseSource(nameof(IsPalindromeTestCases))]
        public void IsPalindrome_DetectsPalindromeCorrectly(string input, bool expected)
        {
            // Act
            bool result = Algo.IsPalindrome(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion

        #region Heterogram unit test case scenarios
        public static IEnumerable IsHeterogramTestCases
        {
            get
            {
                yield return new TestCaseData("abcdefg", true).SetName("AllUniqueCharacters"); // All unique characters
                yield return new TestCaseData("hello", false).SetName("DuplicateCharacters");
                yield return new TestCaseData("world", true).SetName("UniqueRealEnglishWord");   // All unique characters
                yield return new TestCaseData("aabbcc", false).SetName("DuplicateMultipleCharacters");  // Duplicates 'a', 'b', 'c'
                yield return new TestCaseData("", true).SetName("EmptyString");// Empty string
                yield return new TestCaseData("abcABC", false).SetName("CaseSensitiveDuplicates");  // Case-insensitive duplicates
                yield return new TestCaseData("Heterogram", false).SetName("SimpleWordWithDuplicate");
                yield return new TestCaseData("a!@#rb", true).SetName("SpecialCharacterUnique");               
            }
        }

        [Test, TestCaseSource(nameof(IsHeterogramTestCases))]
        public void IsHeterogram_DetectsHeterogramCorrectly(string word, bool expected)
        {
            // Act
            bool result = Algo.IsHeterogram(word);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        #endregion
    }
}