using System;
using System.Text;

namespace CryptographyCsharp.Cryptography.Old
{
    public class Affine
    {
        public Affine()
        {
        }

        public void Run()
        {

            //var i = Encoding.UTF8.GetBytes(new char[]{ 'A'});
            Console.WriteLine(6%4);
            Console.WriteLine(ReverseModulus(2, 0, 2));

            var p = Encrypt("Hi");
            Console.WriteLine(p);
        }
		/// <summary>
		/// key multiplied by 3, add 4
		/// </summary>
		/// <returns>The key.</returns>
		/// <param name="c">C.</param>

        public string Encrypt(string plainText)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < plainText.Length; i++)
            {
                builder.Append(Encrypt(plainText[i]));
            }
            return builder.ToString();
        }

        public void Decrypt(string cipherText)
        {
            
        }

        private char Decrypt(char c)
        {
            int number = (int)c - 65;
            return c;
        }
        private char Encrypt(char c)
        {
            int number = Convert(c);
            return (char)(ModTo(Key(number)) + 65);

        }

        private int ReverseModulus(int div, int a, int remainder)
        {
            if (remainder >= div)
                throw new ArgumentException("Remainder cannot be greater than or equal to divisor");

            if(a < remainder)
                return remainder - a;
            return div + remainder - a;

        }

		public char Key(char c)
        {
            return Key((int)c);
        }

        public char Key(int i)
        {
            return (char)(i * 3 + 4);
        }

        public int ModTo(int input)
        {
            return input % 26;
        }

        public int Convert(char c)
        {
            c = c.ToString().ToUpper()[0];
            return (int)c - 65;
        }
    }
}
