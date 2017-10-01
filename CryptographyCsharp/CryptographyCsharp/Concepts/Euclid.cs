using System;
namespace CryptographyCsharp.Concepts
{
    public class Euclid
    {
        public Euclid()
        {
        }
        public void Run()
        {
            Console.WriteLine(GetGCD(12157, 507));
        }

        /// <summary>
        /// Get the Greatest common divisor from two numbers.
        /// </summary>
        /// <returns>The greatest common divisor.</returns>
        /// <param name="one">First number.</param>
        /// <param name="two">Second number.</param>
        public int GetGCD(int one, int two)
        {
            decimal result;
            decimal numerator = Convert.ToDecimal(one);
            decimal denominator = Convert.ToDecimal(two);
            if (one == 0 || two == 0 )
                return 0;
            if (one < two)
            {
                numerator = Convert.ToDecimal(two);
                denominator = Convert.ToDecimal(one);
            }

            result = numerator / denominator;

            if (result == 1)
                return Convert.ToInt32(denominator);
            
            int rounded = Convert.ToInt32(Math.Floor(result)); 
            return 0;
        }


    }
}
