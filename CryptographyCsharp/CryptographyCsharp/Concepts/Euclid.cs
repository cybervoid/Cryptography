using System;
using System.Linq;

namespace CryptographyCsharp.Concepts
{
    public class Euclid
    {
        public Euclid()
        {
        }
        public void Run()
        {
            Console.WriteLine(GCD(121,88));
            Console.WriteLine(GCD(new[] { 121, 88 }));
            //ExtendedEuclidean();
            //Console.WriteLine(GetGCD(12157, 507));
        }

        public int GCD(int[] numbers)
        {
            return numbers.Aggregate(GCD);
        }
		/// <summary>
		/// Get the Greatest common divisor from two numbers.
		/// </summary>
		/// <returns>The greatest common divisor.</returns>
		/// <param name="one">First number.</param>
		/// <param name="two">Second number.</param>
		public int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
            {
                return GCD(b, a % b);
            }
            //return b == 0 ? a : GCD(b, a % b);
        }


        public void ExtendedEuclidean()
        {
            
        }
    }
}
