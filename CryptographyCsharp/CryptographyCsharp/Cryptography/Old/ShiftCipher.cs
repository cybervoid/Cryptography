using System;
using System.Text;

namespace CryptographyCsharp.Cryptography.Old
{
    public class ShiftCipher
    {
        public string PlainText { get; set; }
        public string EncryptedText { get; set;  }
        public string DecryptedText { get; set; }
        public ShiftCipher()
        {
            
        }

		public ShiftCipher(string plainText)
		{
            this.PlainText = plainText;
		}
        public void Encrypt()
        {
            this.EncryptedText = Shift(this.PlainText);
        }

        public void Decrypt()
        {
            if (string.IsNullOrWhiteSpace(this.EncryptedText))
               Encrypt();
            this.DecryptedText = Decipher(this.EncryptedText);
        }

		public string Shift(string plaintext)
        {
            StringBuilder encryptedText = new StringBuilder();
            for (int i = 0; i < plaintext.Length; i++)
            {
                char c = IntToChar(Key(CharToInt(plaintext[i])));
                encryptedText.Append(c);
            }
            return encryptedText.ToString();
        }

        private int CharToInt(char c)
        {
            return (int)c;
        }

        public char IntToChar(int i)
        {
            return (char)i;
        }

        private int Key(int input)
        {
            return input + 5;
        }

        private int DeKey(int input)
        {
            return input - 5;
        }

        public string Decipher(string cipherText)
        {
			StringBuilder decryptedText = new StringBuilder();
			for (int i = 0; i < cipherText.Length; i++)
			{
				char c = IntToChar(DeKey(CharToInt(cipherText[i])));
				decryptedText.Append(c);
			}
			return decryptedText.ToString();
        }
    }
}
