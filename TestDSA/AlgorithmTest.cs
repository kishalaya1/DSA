using DSA;
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
            int[] sortedArray = Algorithms.BubbleSort(unsortedArray);

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
            string result = Algorithms.RemoveDuplicateChars(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion

    }
}