using System;
using System.Collections.Generic;
using System.Linq;
namespace CryptographyCsharp
{
    public static class Extensions
    {
		#region extensions

		public static byte[] HexToBytes(this string str)
		{
			if (str.Length == 0 || str.Length % 2 != 0)
				return new byte[0];

			byte[] buffer = new byte[str.Length / 2];
			char c;
			for (int bx = 0, sx = 0; bx < buffer.Length; ++bx, ++sx)
			{
				// Convert first half of byte
				c = str[sx];
				buffer[bx] = (byte)((c > '9' ? (c > 'Z' ? (c - 'a' + 10) : (c - 'A' + 10)) : (c - '0')) << 4);

				// Convert second half of byte
				c = str[++sx];
				buffer[bx] |= (byte)(c > '9' ? (c > 'Z' ? (c - 'a' + 10) : (c - 'A' + 10)) : (c - '0'));
			}
			return buffer;
		}

		public static string ToHex(this byte[] bytes)
		{
			char[] c = new char[bytes.Length * 2];

			byte b;

			for (int bx = 0, cx = 0; bx < bytes.Length; ++bx, ++cx)
			{
				b = ((byte)(bytes[bx] >> 4));
				c[cx] = (char)(b > 9 ? b + 0x37 + 0x20 : b + 0x30);

				b = ((byte)(bytes[bx] & 0x0F));
				c[++cx] = (char)(b > 9 ? b + 0x37 + 0x20 : b + 0x30);
			}
			return new string(c);
		}


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

        public static bool IsCongruent(this int a, int b, int modulus)
        {
			if (a == b)
				return true;

            if (modulus == 0)
                throw new ArgumentException("Invalid modulus value");
            
            //if (a.GetRemainder(b) == 0 || b.GetRemainder(a) == 0)
            if (a.GetRemainder(modulus) == b.GetRemainder(modulus))
                return true;
            
			int diff = a - b;

            //if (diff / modulus == 1)
            //   return true;
            
            return false;

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
