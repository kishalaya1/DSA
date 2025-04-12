using Algorithms;
using Algo = Algorithms.Algorithms;
using NUnit.Framework.Legacy;
using System.Collections;




namespace TestDSA
{
    public class AlgorithmTest
    {
        // This is a test class for the Algorithms class
        // It contains unit tests for many algorithms
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

        #region GetAllSubstrings unit test case scenarios
        public static IEnumerable GetAllSubstringsTestCases
        {
            get
            {
                yield return new TestCaseData("abc").Returns(new List<string> { "a", "ab", "abc", "b", "bc", "c" }).SetName("SubstringsOfABC");
                yield return new TestCaseData("ab").Returns(new List<string> { "a", "ab", "b" }).SetName("SubstringsOfAB");
                yield return new TestCaseData("a").Returns(new List<string> { "a" }).SetName("SubstringsOfa");
                yield return new TestCaseData("").Returns(new List<string>()).SetName("SubstringsOfEmptyString");
                yield return new TestCaseData("xyz").Returns(new List<string> { "x", "xy", "xyz", "y", "yz", "z" }).SetName("SubstringsOfxyz");
            }
        }


        [Test, TestCaseSource(nameof(GetAllSubstringsTestCases))]
        public List<string> GetAllSubstrings_ReturnsCorrectSubstrings(string word)
        {
            return Algo.GetAllSubstrings(word);            
        }
        #endregion

        #region Factors of number unit test case scenarios

        public static IEnumerable GetFactorsTestCases
        {
            get
            {
                yield return new TestCaseData(12,new List<int> { 1, 2, 3, 4, 6, 12 });
                yield return new TestCaseData(15, new List<int> { 1, 3, 5, 15 });
                yield return new TestCaseData(28, new List<int> { 1, 2, 4, 7, 14, 28 });
                yield return new TestCaseData(1,new List<int> { 1 });                
                yield return new TestCaseData(0,new List<int>());
            }
        }

        [Test, TestCaseSource(nameof(GetFactorsTestCases))]
        public void GetFactors_ReturnsCorrectFactors(int number, List<int> expectedFactors)
        {
            // Act
            List<int> result = Algo.GetFactors(number);
            // Assert
            Assert.That(result, Is.EqualTo(expectedFactors));
            
        }

        #endregion

        #region GetHCF unit test case scenarios

        public static IEnumerable GetHCFTestCases
        {
            get
            {
                // Test cases for two numbers
                yield return new TestCaseData(new int[] { 48, 18 }, 6).SetName("HCFOfTwoNumbers");
                yield return new TestCaseData(new int[] { 7, 13 }, 1).SetName("HCFOfCoPrimeNumbers");
                yield return new TestCaseData(new int[] { 0, 18 }, 18).SetName("HCFWithZero");
                yield return new TestCaseData(new int[] { 0, 0 }, 0).SetName("HCFOfTwoZeros");

                // Test cases for multiple numbers
                yield return new TestCaseData(new int[] { 48, 18, 30 }, 6).SetName("HCFOfThreeNumbers");
                yield return new TestCaseData(new int[] { 12, 15, 21 }, 3).SetName("HCFOfThreeNumbersWithCommonFactor");
                yield return new TestCaseData(new int[] { 8, 16, 32 }, 8).SetName("HCFOfPowersOfTwo");
                yield return new TestCaseData(new int[] { 1, 1, 1 }, 1).SetName("HCFOfAllOnes");

                // Edge cases
                yield return new TestCaseData(new int[] { 1, 0 }, 1).SetName("HCFOfOneAndZero");
                yield return new TestCaseData(new int[] { 100 }, 100).SetName("HCFOfSingleNumber");
            }
        }

        [Test, TestCaseSource(nameof(GetHCFTestCases))]
        public void GetHCF_ReturnsCorrectHCF(int[] numbers, int expectedHCF)
        {
            // Act
            int result = Algo.GetHCFOfNos(numbers);

            // Assert
            Assert.That(result, Is.EqualTo(expectedHCF));
        }

        #endregion

        #region GetLCM unit test case scenarios 

        public static IEnumerable GetLCMTestCases
        {
            get
            {
                // Test cases for two numbers
                yield return new TestCaseData(new int[] { 4, 6 }, 12).SetName("LCMOfTwoNumbers");
                yield return new TestCaseData(new int[] { 7, 13 }, 91).SetName("LCMOfCoPrimeNumbers");
                yield return new TestCaseData(new int[] { 0, 18 }, 0).SetName("LCMWithZero");
                yield return new TestCaseData(new int[] { 0, 0 }, 0).SetName("LCMOfTwoZeros");

                // Test cases for multiple numbers
                yield return new TestCaseData(new int[] { 4, 6, 8 }, 24).SetName("LCMOfThreeNumbers");
                yield return new TestCaseData(new int[] { 12, 15, 20 }, 60).SetName("LCMOfThreeNumbersWithCommonFactor");
                yield return new TestCaseData(new int[] { 8, 16, 32 }, 32).SetName("LCMOfPowersOfTwo");
                yield return new TestCaseData(new int[] { 1, 1, 1 }, 1).SetName("LCMOfAllOnes");

                // Edge cases
                yield return new TestCaseData(new int[] { 1, 0 }, 0).SetName("LCMOfOneAndZero");
                yield return new TestCaseData(new int[] { 100 }, 100).SetName("LCMOfSingleNumber");
            }
        }

        [Test, TestCaseSource(nameof(GetLCMTestCases))]
        public void GetLCM_ReturnsCorrectLCM(int[] numbers, int expectedLCM)
        {
            // Act
            int result = Algo.GetLCMOfNos(numbers);

            // Assert
            Assert.That(result, Is.EqualTo(expectedLCM));
        }

        #endregion
    }
}