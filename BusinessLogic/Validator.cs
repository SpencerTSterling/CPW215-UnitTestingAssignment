using System;

//  The method signature consists of a method name and the type and kind 
// (value, reference, or output) of each of its formal parameters. 
// Method signature does not include the return type.

// Without changing the method signature 
// Ensure the ValidatorTests and Validator class are modified so the unit tests pass and test the correct business logic

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
