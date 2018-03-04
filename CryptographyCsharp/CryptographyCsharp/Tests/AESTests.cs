using System;
using System.Collections;

namespace CryptographyCsharp.Tests
{
    public class AESTests
    {
        public AESTests()
        {
        }

        public void Run()
        {
            bool[] start = new bool[] { false, true, true, false, false, true, false, true };

            BitArray bits = new BitArray(start);
            byte[] bytes = new byte[3];
            bits.CopyTo(bytes, 0);
            bool[] multi = new bool[] { false, false, false, false, false, false, true, true };
            bits = new BitArray(multi);
            bits.CopyTo(bytes, 1);

            bytes[2] = CryptoHelpers.GMul(bytes[0], bytes[1]);

            bool[] bitresult = bytes[2].ConvertByteToBoolArray();

            foreach (var item in bitresult)
            {
                if (item == true)
                    Console.Write("1");
                else
                    Console.Write("0");
            }
            Console.ReadLine();
        }
    }
}
