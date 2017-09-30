using System;
namespace CryptographyCsharp.Concepts
{
    public class Congruence
    {
        public Congruence()
        {
        }
        public void Run()
        {
            //Let mtZ^+ and a,btZ, then 
        }

        public bool IsCongruent(int first, int second)
        {
            if (first == second)
                return true;

            Equivalence eq;
			if (first<second)
                eq = new Equivalence(second, first);
            else
                eq = new Equivalence(first, second);
            
            if (eq.Remainder == 0)
                return true;
            //1. Any number is congruent to itself (mod m)

            return false;
        }
    }
}
