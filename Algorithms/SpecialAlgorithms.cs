using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SpecialAlgorithms
    {

        #region Luhn's Algorithm

        /// <summary>
        /// Validates a number using Luhn's Algorithm.
        /// </summary>
        /// <param name="number">The number to validate as a long</param>
        /// <returns>True if the number is valid according to Luhn's Algorithm, otherwise false</returns>
        public static bool IsValidLuhn(long number)
        {
            if (!IsValidInput(number))
                return false;

            int sum = CalculateLuhnSum(number);

            // The number is valid if the sum is a multiple of 10
            return sum % 10 == 0;
        }

        /// <summary>
        /// Checks if the input number is valid for Luhn's Algorithm.
        /// </summary>
        /// <param name="number">The number to validate</param>
        /// <returns>True if the input is valid, otherwise false</returns>
        private static bool IsValidInput(long number)
        {
            return number >= 0; // Negative numbers are not valid
        }

        /// <summary>
        /// Calculates the Luhn checksum for a given number.
        /// </summary>
        /// <param name="number">The number to process</param>
        /// <returns>The Luhn checksum</returns>
        private static int CalculateLuhnSum(long number)
        {
            int sum = 0;
            bool doubleDigit = false;

            while (number > 0)
            {
                int digit = (int)(number % 10); // Extract the last digit
                sum += ProcessDigit(digit, doubleDigit);
                doubleDigit = !doubleDigit; // Toggle the doubleDigit flag
                number /= 10; // Remove the last digit
            }

            return sum;
        }

        /// <summary>
        /// Processes a single digit according to Luhn's Algorithm.
        /// </summary>
        /// <param name="digit">The digit to process</param>
        /// <param name="doubleDigit">Whether to double the digit</param>
        /// <returns>The processed digit</returns>
        private static int ProcessDigit(int digit, bool doubleDigit)
        {
            if (doubleDigit)
            {
                digit *= 2;
                if (digit > 9)
                    digit -= 9; // Subtract 9 if the result is greater than 9
            }

            return digit;
        }

        #endregion



    }
}
