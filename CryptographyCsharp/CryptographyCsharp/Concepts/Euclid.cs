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
            decimal lastDenominator = GetLower(one, two);
            int div = DivisionAlgorithmRemainder(GetHigher(one, two), lastDenominator);

            while (div != 1)
            {
                lastDenominator = (lastDenominator - div);				
                div = DivisionAlgorithmRemainder(div, lastDenominator);
            }
            return Convert.ToInt32(lastDenominator);
        }


        private int DivisionAlgorithmRemainder(decimal numerator, decimal denominator)
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
    }
}
