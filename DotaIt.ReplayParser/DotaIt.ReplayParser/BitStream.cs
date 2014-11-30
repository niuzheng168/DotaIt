namespace DotaIt.ReplayParser.Class
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Text;

    /// <summary>
    /// The bit stream reader.
    /// </summary>
    internal class BitStreamReader
    {
        #region Constants

        /// <summary>
        /// The bit count per byte.
        /// </summary>
        public const uint BitCountPerByte = 8;

        /// <summary>
        /// The bit count per int.
        /// </summary>
        public const uint BitCountPerInt = 32;

        /// <summary>
        /// The bit count per long.
        /// </summary>
        public const uint BitCountPerLong = 64;

        /// <summary>
        /// The bit count per short.
        /// </summary>
        public const uint BitCountPerShort = 16;

        #endregion

        #region Fields

        /// <summary>
        /// The _buffer length in bits.
        /// </summary>
        private uint _bufferLengthInBits;

        /// <summary>
        /// The _byte array.
        /// </summary>
        private byte[] _byteArray;

        /// <summary>
        /// The _byte array index.
        /// </summary>
        private int _byteArrayIndex;

        /// <summary>
        /// The _cbits in partial byte.
        /// </summary>
        private int _cbitsInPartialByte;

        /// <summary>
        /// The _partial byte.
        /// </summary>
        private byte _partialByte;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BitStreamReader"/> class. 
        /// Create a new BitStreamReader to unpack the bits in a buffer of bytes
        /// </summary>
        /// <param name="buffer">
        /// Buffer of bytes
        /// </param>
        internal BitStreamReader(byte[] buffer)
        {
            Debug.Assert(buffer != null);

            this._byteArray = buffer;
            this._bufferLengthInBits = (uint)buffer.Length * BitCountPerByte;

            for (int i = 0; i < _byteArray.Length; i++)
            {
                //_byteArray[i] = this.Reverse(_byteArray[i]);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BitStreamReader"/> class.
        /// </summary>
        /// <param name="buffer">
        /// The buffer.
        /// </param>
        /// <param name="startIndex">
        /// The start index.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// </exception>
        internal BitStreamReader(byte[] buffer, int startIndex)
        {
            Debug.Assert(buffer != null);

            if (startIndex < 0 || startIndex >= buffer.Length)
            {
                throw new ArgumentOutOfRangeException("startIndex");
            }

            this._byteArray = buffer;
            this._byteArrayIndex = startIndex;
            this._bufferLengthInBits = (uint)(buffer.Length - startIndex) * BitCountPerByte;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     The current read index in the array
        /// </summary>
        internal int CurrentIndex
        {
            get
            {
                // _byteArrayIndex is always advanced to the next index
                // so we always decrement before returning
                return this._byteArrayIndex - 1;
            }
        }

        /// <summary>
        ///     Since the return value of Read cannot distinguish between valid and invalid
        ///     data (e.g. 8 bits set), the EndOfStream property detects when there is no more
        ///     data to read.
        /// </summary>
        /// <value>True if stream end has been reached</value>
        internal bool EndOfStream
        {
            get
            {
                return 0 == this._bufferLengthInBits;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Reads a single bit from the buffer
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        internal bool ReadBit()
        {
            byte b = this.ReadByte(1);
            return ((b & 1) == 1);
        }

        internal string ReadString(int countOfBits)
        {
            StringBuilder sb = new StringBuilder();
            while (countOfBits > 0)
            {
                char c = (char)this.ReadByte(8);
                if (c == 0)
                {
                    break;
                }
                sb.Append(c);
                countOfBits--;
            }
            return sb.ToString();
        }

        /// <summary>
        /// The read byte.
        /// </summary>
        /// <param name="countOfBits">
        /// The count of bits.
        /// </param>
        /// <returns>
        /// The <see cref="byte"/>.
        /// </returns>
        /// <exception cref="EndOfStreamException">
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// </exception>
        internal byte ReadByte(int countOfBits)
        {
            // if the end of the stream has been reached, then throw an exception
            if (this.EndOfStream)
            {
                throw new EndOfStreamException();
            }

            // we only support 1-8 bits currently, not multiple bytes, and not 0 bits
            if (countOfBits > BitCountPerByte || countOfBits <= 0)
            {
                throw new ArgumentOutOfRangeException("countOfBits");
            }

            if (countOfBits > this._bufferLengthInBits)
            {
                throw new ArgumentOutOfRangeException("countOfBits");
            }

            this._bufferLengthInBits -= (uint)countOfBits;

            // initialize return byte to 0 before reading from the cache
            byte returnByte = 0;

            // if the partial bit cache contains more bits than requested, then read the
            //       cache only
            if (this._cbitsInPartialByte >= countOfBits)
            {
                int mask = (1 << countOfBits) - 1;
                returnByte = (byte)(this._partialByte & mask);

                // reposition any unused portion of the cache in the most significant part of the bit cache
                unchecked // disable overflow checking since we are intentionally throwing away
                {
                    //   the significant bits
                    this._partialByte >>= countOfBits;
                }

                // update the bit count in the cache
                this._cbitsInPartialByte -= countOfBits;
            }
                
                // otherwise, we need to retrieve more full bytes from the stream
            else
            {
                // retrieve the next full byte from the stream
                byte nextByte = this._byteArray[this._byteArrayIndex];
                this._byteArrayIndex++;

                int remainingBitsCount = countOfBits - _cbitsInPartialByte;
                int mask = (1 << remainingBitsCount) - 1;
                byte newByteValue = (byte)(nextByte & mask);
                returnByte = (byte)((newByteValue << _cbitsInPartialByte) | _partialByte);

                this._cbitsInPartialByte = (int)BitCountPerByte - remainingBitsCount;

                unchecked
                {
                    this._partialByte = (byte)(nextByte >> remainingBitsCount);
                }
            }

            return returnByte;
        }

        /// <summary>
        /// The read u int 16.
        /// </summary>
        /// <param name="countOfBits">
        /// The count of bits.
        /// </param>
        /// <returns>
        /// The <see cref="ushort"/>.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// </exception>
        internal ushort ReadUInt16(int countOfBits)
        {
            // we only support 1-16 bits currently, not multiple bytes, and not 0 bits
            if (countOfBits > BitCountPerShort || countOfBits <= 0)
            {
                throw new ArgumentOutOfRangeException("countOfBits");
            }

            ushort retVal = 0;
            while (countOfBits > 0)
            {
                int countToRead = (int)BitCountPerByte;
                if (countOfBits < 8)
                {
                    countToRead = countOfBits;
                }

                // make room
                retVal <<= countToRead;
                byte b = this.ReadByte(countToRead);
                retVal |= b;
                countOfBits -= countToRead;
            }

            return retVal;
        }

        /// <summary>
        /// Read a specified number of bits from the stream in reverse byte order
        /// </summary>
        /// <param name="countOfBits">
        /// The count Of Bits.
        /// </param>
        /// <returns>
        /// The <see cref="uint"/>.
        /// </returns>
        internal uint ReadUInt16Reverse(int countOfBits)
        {
            // we only support 1-8 bits currently, not multiple bytes, and not 0 bits
            if (countOfBits > BitCountPerShort || countOfBits <= 0)
            {
                throw new ArgumentOutOfRangeException("countOfBits");
            }

            ushort retVal = 0;
            int fullBytesRead = 0;
            while (countOfBits > 0)
            {
                int countToRead = (int)BitCountPerByte;
                if (countOfBits < 8)
                {
                    countToRead = countOfBits;
                }

                // make room
                ushort b = this.ReadByte(countToRead);
                b <<= (fullBytesRead * (int)BitCountPerByte);
                retVal |= b;
                fullBytesRead++;
                countOfBits -= countToRead;
            }

            return retVal;
        }

        /// <summary>
        /// Read a specified number of bits from the stream into a single byte
        /// </summary>
        /// <param name="countOfBits">
        /// The count Of Bits.
        /// </param>
        /// <returns>
        /// The <see cref="uint"/>.
        /// </returns>
        internal uint ReadUInt32(int countOfBits)
        {
            // we only support 1-8 bits currently, not multiple bytes, and not 0 bits
            if (countOfBits > BitCountPerInt || countOfBits <= 0)
            {
                throw new ArgumentOutOfRangeException("countOfBits");
            }

            uint retVal = 0;
            while (countOfBits > 0)
            {
                int countToRead = (int)BitCountPerByte;
                if (countOfBits < 8)
                {
                    countToRead = countOfBits;
                }

                // make room
                retVal <<= countToRead;
                byte b = this.ReadByte(countToRead);
                retVal |= b;
                countOfBits -= countToRead;
            }

            return retVal;
        }

        internal int ReadInt32(int countOfBits)
        {
            // we only support 1-8 bits currently, not multiple bytes, and not 0 bits
            if (countOfBits > BitCountPerInt || countOfBits <= 0)
            {
                throw new ArgumentOutOfRangeException("countOfBits");
            }

            int retVal = 0;
            int curBit = 0;
            while (countOfBits > 0)
            {
                int countToRead = (int)BitCountPerByte;
                if (countOfBits < 8)
                {
                    countToRead = countOfBits;
                }

                byte b = this.ReadByte(countToRead);
                retVal = (b << curBit) | retVal;
                curBit += 8;
                countOfBits -= countToRead;
            }

            return retVal;
        }

        internal byte[] ReadBytes(int countOfBits)
        {
            List<byte> result = new List<byte>();
            while (countOfBits > 0)
            {
                int countToRead = (int)BitCountPerByte;
                if (countOfBits < 8)
                {
                    countToRead = countOfBits;
                }

                byte b = this.ReadByte(countToRead);
                result.Add(b);
                countOfBits -= countToRead;
            }

            return result.ToArray();
        }

        /// <summary>
        /// Read a specified number of bits from the stream in reverse byte order
        /// </summary>
        /// <param name="countOfBits">
        /// The count Of Bits.
        /// </param>
        /// <returns>
        /// The <see cref="uint"/>.
        /// </returns>
        internal uint ReadUInt32Reverse(int countOfBits)
        {
            // we only support 1-8 bits currently, not multiple bytes, and not 0 bits
            if (countOfBits > BitCountPerInt || countOfBits <= 0)
            {
                throw new ArgumentOutOfRangeException("countOfBits");
            }

            uint retVal = 0;
            int fullBytesRead = 0;
            while (countOfBits > 0)
            {
                int countToRead = (int)BitCountPerByte;
                if (countOfBits < 8)
                {
                    countToRead = countOfBits;
                }

                // make room
                uint b = this.ReadByte(countToRead);
                b <<= (fullBytesRead * (int)BitCountPerByte);
                retVal |= b;
                fullBytesRead++;
                countOfBits -= countToRead;
            }

            return retVal;
        }

        /// <summary>
        /// Read a specified number of bits from the stream into a long
        /// </summary>
        /// <param name="countOfBits">
        /// The count Of Bits.
        /// </param>
        /// <returns>
        /// The <see cref="long"/>.
        /// </returns>
        internal long ReadUInt64(int countOfBits)
        {
            // we only support 1-64 bits currently, not multiple bytes, and not 0 bits
            if (countOfBits > BitCountPerLong || countOfBits <= 0)
            {
                throw new ArgumentOutOfRangeException("countOfBits");
            }

            long retVal = 0;
            while (countOfBits > 0)
            {
                int countToRead = (int)BitCountPerByte;
                if (countOfBits < 8)
                {
                    countToRead = countOfBits;
                }

                // make room
                retVal <<= countToRead;
                byte b = this.ReadByte(countToRead);
                retVal |= b;
                countOfBits -= countToRead;
            }

            return retVal;
        }

        private byte Reverse(byte b)
        {
            int r = ((b & 0x55) << 1) | ((b & 0xAA) >> 1);
            r = ((r & 0x33) << 2) | ((r & 0xCC) >> 2);
            r = ((r & 0x0F) << 4) | ((r & 0xF0) >> 4);

            return (byte)r;
        }

        #endregion
    }
}