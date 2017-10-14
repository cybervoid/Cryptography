using System;
using System.Collections.Generic;

namespace CryptographyCsharp.Models
{

    public class Letter
    {
		public int Index { get; set; }
		public int UpperAscii 
        { 
            get 
            {
                return (int)UpperLetter;
            } 
        }
		public int LowerAscii
		{
			get
			{
				return (int)LowerLetter;
			}
		}
		public char UpperLetter { get; set; }
		public char LowerLetter { get; set; }
        public char StartLetter { get; set; }
        public bool IsValid { get; set; }
        public Letter(char letter)
        {
            
            Initialize(letter);
        }

        private void Initialize(char letter)
        {
            bool isUpper = false;
            bool isLower = false;
            int num = (int)letter;
            if (num > 64 && num < 91)
                isUpper = true;
            else if (num > 96 && num < 123)
                isLower = true;
            else
            {
                this.IsValid = false;
                return;
            }
            if (isUpper == true)
            {
                this.Index = num - 65;
            }
            else if (isLower == true)
                this.Index = num - 97;

            this.StartLetter = letter;
            string letterString = letter.ToString();
            this.UpperLetter = letterString.ToUpper()[0];
            this.LowerLetter = letterString.ToLower()[0];
        }
    }
    public static class Alphabet
    {
        private static List<Letter> _Letters;
        public static List<Letter> Letters 
        { 
            get
            {
                if (_Letters == null || _Letters.Count == 0)
                    Generate();
                return _Letters;
            }
        }

        private static void Generate()
        {
            List<Letter> letters = new List<Letter>();

            for (int i = 65; i < 91; i++)
            {
                letters.Add(new Letter((char)i));
            }
            _Letters = letters;
        }
	}
}
