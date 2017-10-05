using System;
using System.Collections.Generic;

namespace CryptographyCsharp.Concepts
{
    /// <summary>
    /// Set of integers where every integer is congruent to exactly one integer in the set
    /// </summary>
    public class Residues
    {
        public List<int> Set1 { get; set; }
        public List<int> Set2 { get; set; }

        public Residues()
        {
            this.Set1 = new List<int>() { 0, 1, 2 ,3, 4, 5, 6};
            this.Set2 = new List<int>() { 7, 8, 2, -4, 11, 47, 48 };
        }
    }
}
