using System;
using CryptographyCsharp.Concepts;
namespace CryptographyCsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //CryptographyCsharp.Concepts.Equivalence equivalence = new Concepts.Equivalence(22, 12);
            Congruence congruence = new Congruence();
            Console.WriteLine(congruence.IsCongruent(21, 7));
            Console.ReadLine();

        }
    }
}
