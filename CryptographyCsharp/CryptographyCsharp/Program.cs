using System;
using CryptographyCsharp.Concepts;
using CryptographyCsharp.Cryptography.Old;
namespace CryptographyCsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Affine aff = new Affine();
            //aff.Run();
            Console.WriteLine(26.IsCongruent(11, 5));
            //Console.WriteLine(1.IsCongruent(7));
            Console.WriteLine(25.GetRemainder(20));
            Console.WriteLine(121.GetGCD(88));
            //RunEuclid();
            Console.ReadLine();

        }


        public static void RunEuclid()
        {
            Concepts.Euclid euc = new Euclid();
            euc.Run();
        }
        /// <summary>
        /// Corresponds to Section 2, Lecture 4
        /// </summary>
        public static void GetCongruence()
        {
			Congruence congruence = new Congruence();
			Console.WriteLine(congruence.IsCongruent(21, 7));
		}
        public static void RunEquivalence()
        {
            Equivalence equivalence = new Equivalence(22, 12);
            Console.WriteLine(equivalence.Remainder);
        }
        /// <summary>
        /// Runs the shift cipher.
        /// </summary>
        public static void RunShift()
        {
			ShiftCipher cs = new ShiftCipher("Hello World");
			cs.Encrypt();
			Console.WriteLine(cs.EncryptedText);
			cs.Decrypt();
			Console.WriteLine(cs.DecryptedText);
        }
    }
}
