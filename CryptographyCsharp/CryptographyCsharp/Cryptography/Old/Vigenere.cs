using System;
using System.Collections.Generic;

namespace CryptographyCsharp.Cryptography.Old
{
    public class Vigenere
    {
        public string Key{ get; set; }
        public string plainText { get; set; }
        public Vigenere()
        {
        }

        public Vigenere(string key, string plain)
        {
            this.Key = key;
            plainText = plain;
        }

        public void Run(string key)
        {
            int length = key.Length;
        }
    }

    public class BlockKey
    {
        public List<Tuple<Models.Letter, int>> Blocks {get; set; }
        private string Key;
        public BlockKey(string key)
        {
            this.Key = key;
            Initialize();
        }

        private void Initialize()
        {
            Blocks = new List<Tuple<Models.Letter, int>>();
            for (int i = 0; i < Key.Length; i++)
            {
                Blocks.Add(CreateBlock(Key[i], i));
            }
        }

        private Tuple<Models.Letter, int> CreateBlock(char c, int i )
        {
            return new Tuple<Models.Letter, int>(new Models.Letter(c), i);
        }
    }
}
