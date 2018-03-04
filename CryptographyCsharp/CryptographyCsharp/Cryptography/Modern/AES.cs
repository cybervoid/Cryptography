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
        /// <summary>
        /// Initialize a byte array with 128 bytes
        /// </summary>
        /// <param name="inputBytes">Input bytes.</param>
        public Matrix(List<byte> inputBytes) : this(inputBytes.ToArray())
        {
            
        }
        #region Step 1 byte sub swap
        public void BuildMatrix()
        {
            ByteMatrix = GetMatrix().ToList();
        }

        public byte this[int row, int column]
        {
            get
            {
                if (ByteMatrix == null)
                    throw new Exception("ByteMatrix cannot be null");
                if (ByteMatrix[row] == null)
                    throw new IndexOutOfRangeException("row out of range ");

                if(ByteMatrix[row].Count >= column )
                    throw new  IndexOutOfRangeException("column out of range");                 
                return ByteMatrix[row][column];            
            }
        }

        public bool Exists(int row, int column)
        {
            if (ByteMatrix == null)
                return false;
            if (row >= ByteMatrix.Count || ByteMatrix[row] == null)
                return false;
            if(column >= ByteMatrix[row].Count )
                return true;
            else
                return false;
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
