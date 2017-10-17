using System;
using System.Collections.Generic;
using CryptographyCsharp.Models;

namespace CryptographyCsharp.Cryptography.Old
{
    public class Vigenere
    {
        public string Key{ get; set; }
        public string plainText { get; set; }
        public List<Block> Blocks { get; set; }
        public Vigenere()
        {
            Blocks = new List<Block>();
        }

        public Vigenere(string key, string plain) : this()
        {
            this.Key = key;
            plainText = plain;
        }

        public void Run()
        {
            for (int i = 0; i < plainText.Length; i++)
            {
                Blocks.Add(new Block(plainText[i], Key[i % Key.Length]));
            }

            foreach (var bl in Blocks)
            {
                Console.WriteLine(bl.EncryptedLetter.UpperLetter);
            }
            Console.ReadLine();
        }
    }

    public class Block
    {
        public Letter LetterKey { get; set; }
        public Letter PlainLetter { get; set; }
        public Letter EncryptedLetter  { get { return GetEncryptedLetter(); } }

        public Block(char letterKey, char plainLetter)
        {
            this.LetterKey = new Letter(letterKey);
            this.PlainLetter = new Letter(plainLetter);
        }

        public Block(int letterKey, int plainLetter) : this((char) letterKey, (char)plainLetter)
        {
            
        }

        private Letter GetEncryptedLetter()
        {
            return new Letter((char)(((LetterKey.UpperAscii + PlainLetter.UpperAscii) % 65)+65));
        }
    }
}

