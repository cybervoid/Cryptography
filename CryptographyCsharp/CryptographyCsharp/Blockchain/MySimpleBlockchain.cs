using System;
using System.Security.Cryptography;
using System.Text;

namespace CryptographyCsharp.Blockchain
{
    public class MySimpleBlockchain
    {
        
        public MySimpleBlockchain()
        {
        }

        public void Run()
        {
            bool keepGoing = true;
            string outter = string.Empty;
            DateTime resultTime;
            while(keepGoing)
            {
                DateTime check = DateTime.Now;
                string result = DoubleSha(check.ToString());
                if(result.StartsWith("000"))
                {
                    outter = result;
                    resultTime = check;
                    keepGoing = false;
                }
            }

            Console.WriteLine(outter);
        }

        private string DoubleSha(string input)
        {
            return Sha256(Sha256(input));
        }
        private string Sha256(string input)
        {
			byte[] bytes = Encoding.UTF8.GetBytes(input);
			SHA256Managed hashstring = new SHA256Managed();
			byte[] hash = hashstring.ComputeHash(bytes);
			string hashString = string.Empty;
			foreach (byte x in hash)
			{
				hashString += String.Format("{0:x2}", x);
			}
			return hashString;
        }
    }
}
