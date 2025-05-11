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
            if (number < 0)
                return false; // Negative numbers are not valid

            int sum = 0;
            bool doubleDigit = false;

            // Process digits from right to left
            while (number > 0)
            {
                int digit = (int)(number % 10); // Extract the last digit

                if (doubleDigit)
                {
                    digit *= 2;
                    if (digit > 9)
                        digit -= 9; // Subtract 9 if the result is greater than 9
                }

                sum += digit;
                doubleDigit = !doubleDigit; // Toggle the doubleDigit flag
                number /= 10; // Remove the last digit
            }

            // The number is valid if the sum is a multiple of 10
            return sum % 10 == 0;
        }

        #endregion


    }
}
