using System;
namespace CryptographyCsharp
{
    public static class CryptoHelpers
    {
        public static byte GMul(byte a, byte b)
        { // Galois Field (256) Multiplication
            byte p = 0;
            byte counter;
            byte hi_bit_set;
            for (counter = 0; counter < 8; counter++)
            {
                if ((b & 1) != 0)
                {
                    p ^= a;
                }
                hi_bit_set = (byte)(a & 0x80);
                a <<= 1;
                if (hi_bit_set != 0)
                {
                    a ^= 0x1b; /* x^8 + x^4 + x^3 + x + 1 */
                }
                b >>= 1;
            }
            return p;
        }   
    }


}
