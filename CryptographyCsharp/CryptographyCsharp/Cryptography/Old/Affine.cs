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
            var i = Key('m');
            Console.WriteLine(i);
        }
		/// <summary>
		/// key multiplied by 3, add 4
		/// </summary>
		/// <returns>The key.</returns>
		/// <param name="c">C.</param>
		public char Key(char c)
        {
            return (char)ModTo((((int)c) * 3 + 4));
        }

        public int ModTo(int input)
        {
            if(input > 254){
                return input % 255;
            }
            return input;
        }
    }
}
