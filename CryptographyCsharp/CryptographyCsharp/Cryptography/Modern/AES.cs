using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CryptographyCsharp;
namespace CryptographyCsharp.Cryptography.Modern
{
    public class AES
    {
        //Rijndael
        public AES()
        {
        }

        public void Run()
        {
            //byte sub transformation

        }


    }

    public class Matrix : IEnumerable<List<byte>>
    {
        byte[] _inputBytes;
        private List<List<byte>> ByteMatrix { get; set; }
        public Matrix(byte[] inputBytes)
        {
            this._inputBytes = inputBytes;
            BuildMatrix();
        }

        public Matrix(List<byte> inputBytes) : this(inputBytes.ToArray())
        {
            
        }
        #region Step 1 byte sub swap
        public void BuildMatrix()
        {
            ByteMatrix = GetMatrix().ToList();
        }

        public List<byte> this[int i]
        {
            get
            {
                if (i >= ByteMatrix.Count)
                    throw new IndexOutOfRangeException("out of range");
                return ByteMatrix[i]; 
            }
        }

        public byte GetByte(int row, int column)
        {
            return this[row][column];
        }

        private IEnumerable<List<byte>> GetMatrix()
        {
            //IEnumerable<List<byte>> matrix = new List<List<byte>>();

            int counter = 0;
            for (int i = 0; i < _inputBytes.Length; i++)
            {
                List<byte> bytes = new List<byte>();
                for (int j = 0; j < 4; j++)
                {
                    bytes.Add(_inputBytes[i]);
                    counter++;
                }
                yield return bytes;
            }
        }
        #endregion

        public IEnumerator<List<byte>> GetEnumerator()
        {
            return ByteMatrix.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
