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
            //a =  b 2 + r
            //assume d / a,  d / b => implies => d / r 
            int divrem = DivisionAlgorithmRemainder(GetHigher(one, two), GetLower(one, two));
            //Get the division algorithm again
            int divAgain = DivisionAlgorithmRemainder(GetLower(one, two), divrem);
            return divAgain;
        }

        private decimal GetHigher(int one, int two)
        {
            if (one > two)
                return Convert.ToDecimal(one);
            else
                return Convert.ToDecimal(two);
        }

        private decimal GetLower(int one, int two)
        {
			if (two > one)
				return Convert.ToDecimal(one);
			else
				return Convert.ToDecimal(two);   
        }
        public int DivisionAlgorithmRemainder(decimal numerator, decimal denominator)
        {
			decimal result;
			if (numerator == 0 || denominator == 0)
				return 0;

            result = numerator / denominator;
			if (result == 1)
				return Convert.ToInt32(denominator);

			int rounded = Convert.ToInt32(Math.Floor(result));

			return Convert.ToInt32(numerator - (rounded * denominator));
        }
    }
}
