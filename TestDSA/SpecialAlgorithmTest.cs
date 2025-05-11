using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;
using Algo = Algorithms.Algorithms;
using NUnit.Framework;

namespace TestDSA
{
    public class SpecialAlgorithmTest
    {
        // This is a test class for the SpecialAlgorithms class
        // It contains unit tests for many algorithms
        // Add any necessary using directives here
        // Add any necessary attributes here
        // This method runs before each test in this class
        // You can use it to set up any common resources needed for the tests


        [SetUp]
        public void Setup()
        {
        }

        #region Luhn's Algorithm Unit Test Cases

        public static IEnumerable<TestCaseData> IsValidLuhnTestCases
        {
            get
            {
                // Valid Luhn numbers
                yield return new TestCaseData(4532015112830366L, true).SetName("ValidLuhn_16Digit");
                yield return new TestCaseData(79927398713L, true).SetName("ValidLuhn_11Digit");
                yield return new TestCaseData(0L, true).SetName("ValidLuhn_Zero");

                // Invalid Luhn numbers
                yield return new TestCaseData(4532015112830367L, false).SetName("InvalidLuhn_16Digit");
                yield return new TestCaseData(79927398710L, false).SetName("InvalidLuhn_11Digit");

                // Edge cases
                yield return new TestCaseData(-4532015112830366L, false).SetName("InvalidLuhn_NegativeNumber");
                yield return new TestCaseData(1L, false).SetName("InvalidLuhn_SingleDigit");
            }
        }
        [Test, TestCaseSource(nameof(IsValidLuhnTestCases))]
        public void IsValidLuhn_ValidatesCorrectly(long number, bool expected)
        {
            // Act
            bool result = SpecialAlgorithms.IsValidLuhn(number);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        #endregion
    }
}
