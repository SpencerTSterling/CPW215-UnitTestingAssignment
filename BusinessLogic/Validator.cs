using System;
using System.Text.RegularExpressions;

//  The method signature consists of a method name and the type and kind 
// (value, reference, or output) of each of its formal parameters. 
// Method signature does not include the return type.

// Without changing the method signature 
// Ensure the ValidatorTests and Validator class are modified so the unit tests pass and test the correct business logic

namespace BusinessLogic
{
    public static class Validator
    {
        // These numbers are not allowed in valid SSN numbers
        public static string DoubleZeros = "00";
        public static string TripleZeros = "000";
        public static string TripleSixes = "666";
        public static string QuadrupleZeros = "0000";

        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssnDigits"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
           

            // A valid ssn must be 9 digits (without hypens)
            // pattern with or without dashes ^(?:\d{9}|\d{3}-\d{2}-\d{4})$
            Regex pattern = new Regex(@"^(?:\d{9}|\d{3}-\d{2}-\d{4})$");
            if (!pattern.IsMatch(ssn))
            {
                return false; // returns false if input doesn't have 9 numeric characters
            }

            // A valid SSN has 3 rules - a ssn is invalid if
            // The first three digits as “000,” “666,” or be between "900" and "999".
            // The second group that consists of two digits as “00" or exceeds "99".
            // The third group consisting of four digits as “0000.”
            // Any of the groups consist of all 0 ( 000-00-0000 )

            string result = Regex.Replace(ssn, @"[^0-9]", ""); // input without dashes

            // there are specifc rules for each group of digits in a valid ssn ( AAA-BB-CC )
            string groupA = result.Substring(0, 3); // AAA-XX-XXX
            string groupB = result.Substring(4, 2); // XX-BB-XXX
            string groupC = result.Substring(6); // XXX-XX-CCCC


            if ( groupA.Contains(TripleZeros) ||
                 groupA.Contains(TripleSixes) ||
                 groupA.StartsWith("9") ||
                 groupB.Contains(DoubleZeros) ||
                 groupC.Contains(QuadrupleZeros) )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            return numToTest >= minValue && numToTest <= maxValue;
        }
    }
}
