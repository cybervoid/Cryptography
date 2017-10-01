using System;
using CryptographyCsharp.Concepts;
using CryptographyCsharp.Cryptography.Old;
namespace CryptographyCsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.ReadLine();

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
        /// Runs the shift.
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
