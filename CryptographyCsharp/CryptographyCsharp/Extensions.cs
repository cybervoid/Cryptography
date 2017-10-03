using System;
using System.Collections.Generic;
using System.Linq;
namespace CryptographyCsharp
{
    public static class Extensions
    {
        #region extensions
        public static int GetRemainder(this int val, int modulus)
        {
            return Remainder(val, modulus);
        }


        public static int GetGCD(this int a, int b)
        {
            return GCD(a, b);
        }

        public static int GetGCD(this List<int> numbers)
        {
            return GCD(numbers.ToArray());
        }

        #endregion

        #region Helpers
        private static int Remainder(int val, int Modulus)
        {
            if (val < Modulus)
                return val;
            else
                return Remainder(val - Modulus, Modulus);
        }



        private static int GCD(int[] numbers)
        {
            return numbers.Aggregate(GCD);
        }


        /// <summary>
        /// Get the Greatest common divisor from two numbers.
        /// </summary>
        /// <returns>The greatest common divisor.</returns>
        /// <param name="one">First number.</param>
        /// <param name="two">Second number.</param>
        private static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
            {
                return GCD(b, a % b);
            }
            //return b == 0 ? a : GCD(b, a % b);
        }
        #endregion
    }
}
