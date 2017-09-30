using System;
using CryptographyCsharp.Concepts;
using CryptographyCsharp.Cryptography.Old;
namespace CryptographyCsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //CryptographyCsharp.Concepts.Equivalence equivalence = new Concepts.Equivalence(22, 12);
            //Congruence congruence = new Congruence();
            //Console.WriteLine(congruence.IsCongruent(21, 7));
            ShiftCipher cs = new ShiftCipher("Hello World");
            cs.Encrypt();
            Console.WriteLine(cs.EncryptedText);
            cs.Decrypt();
            Console.WriteLine(cs.DecryptedText);
            Console.ReadLine();

        }
    }
}
