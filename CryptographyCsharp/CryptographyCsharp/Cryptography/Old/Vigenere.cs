using System;
using System.Collections.Generic;

namespace CryptographyCsharp.Cryptography.Old
{
    public class Vigenere
    {
        public string Key{ get; set; }
       
        public Vigenere()
        {
        }

        public Vigenere(string key)
        {
            this.Key = key;
        }

        public void Run(string key)
        {
            int length = key.Length;
        }
    }

    public class Block
    {
        public int Index { get; set; }
        public List<char> Items { get; set; }
    }
}
