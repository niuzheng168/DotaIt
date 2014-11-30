namespace DotaIt.ReplayParser
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ByteString : IEnumerable<byte>, IEquatable<ByteString>
    {
        private static readonly ByteString empty = new ByteString(new byte[0]);

        private readonly byte[] bytes;

        /// <summary>
        /// Internal use only.  Ensure that the provided array is not mutated and belongs to this instance.
        /// </summary>
        internal static ByteString AttachBytes(byte[] bytes)
        {
            return new ByteString(bytes);
        }

        /// <summary>
        /// Constructs a new ByteString from the given byte array. The array is
        /// *not* copied, and must not be modified after this constructor is called.
        /// </summary>
        private ByteString(byte[] bytes)
        {
            this.bytes = bytes;
        }

        /// <summary>
        /// Returns an empty ByteString.
        /// </summary>
        public static ByteString Empty
        {
            get { return empty; }
        }

        /// <summary>
        /// Returns the length of this ByteString in bytes.
        /// </summary>
        public int Length
        {
            get { return bytes.Length; }
        }

        public bool IsEmpty
        {
            get { return Length == 0; }
        }

        public byte[] ToByteArray()
        {
            return (byte[])bytes.Clone();
        }

        /// <summary>
        /// Constructs a ByteString from the Base64 Encoded String.
        /// </summary>
        public static ByteString FromBase64(string bytes)
        {
            return new ByteString(System.Convert.FromBase64String(bytes));
        }

        /// <summary>
        /// Constructs a ByteString from the given array. The contents
        /// are copied, so further modifications to the array will not
        /// be reflected in the returned ByteString.
        /// </summary>
        public static ByteString CopyFrom(byte[] bytes)
        {
            return new ByteString((byte[])bytes.Clone());
        }

        /// <summary>
        /// Constructs a ByteString from a portion of a byte array.
        /// </summary>
        public static ByteString CopyFrom(byte[] bytes, int offset, int count)
        {
            byte[] portion = new byte[count];
            Array.Copy(bytes, offset, portion, 0, count);
            return new ByteString(portion);
        }

        /// <summary>
        /// Creates a new ByteString by encoding the specified text with
        /// the given encoding.
        /// </summary>
        public static ByteString CopyFrom(string text, Encoding encoding)
        {
            return new ByteString(encoding.GetBytes(text));
        }

        /// <summary>
        /// Creates a new ByteString by encoding the specified text in UTF-8.
        /// </summary>
        public static ByteString CopyFromUtf8(string text)
        {
            return CopyFrom(text, Encoding.UTF8);
        }

        /// <summary>
        /// Retuns the byte at the given index.
        /// </summary>
        public byte this[int index]
        {
            get { return bytes[index]; }
        }

        public string ToString(Encoding encoding)
        {
            return encoding.GetString(bytes, 0, bytes.Length);
        }

        public string ToStringUtf8()
        {
            return ToString(Encoding.UTF8);
        }

        public IEnumerator<byte> GetEnumerator()
        {
            return ((IEnumerable<byte>)bytes).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public override bool Equals(object obj)
        {
            ByteString other = obj as ByteString;
            if (obj == null)
            {
                return false;
            }
            return Equals(other);
        }

        public override int GetHashCode()
        {
            int ret = 23;
            foreach (byte b in bytes)
            {
                ret = (ret << 8) | b;
            }
            return ret;
        }

        public bool Equals(ByteString other)
        {
            if (other.bytes.Length != bytes.Length)
            {
                return false;
            }
            for (int i = 0; i < bytes.Length; i++)
            {
                if (other.bytes[i] != bytes[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Copies the entire byte array to the destination array provided at the offset specified.
        /// </summary>
        public void CopyTo(Array array, int position)
        {
            Array.Copy(bytes, 0, array, position, bytes.Length);
        }

        /// <summary>
        /// Writes the entire byte array to the provided stream
        /// </summary>
        public void WriteTo(System.IO.Stream outputStream)
        {
            outputStream.Write(bytes, 0, bytes.Length);
        }
    }
}