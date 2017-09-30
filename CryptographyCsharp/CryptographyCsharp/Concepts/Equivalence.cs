using System;
namespace CryptographyCsharp.Concepts
{
    public class Equivalence
    {
        public int Remainder 
        { 
            get
            {
                return this.GetRemainder(this.A);
            } 

        }
        public int Modulus { get; set; }
        public int A { get; set; }


        public Equivalence(int a, int mod)
        {
            //this.Remainder = remainder;
            this.A = a;
            this.Modulus = mod;
        }

        private int GetRemainder(int val)
        {
            if (val < Modulus)
                return val;
            else
                return GetRemainder(val - Modulus);
        }

    }
}
