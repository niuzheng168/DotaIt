namespace DotaIt.ReplayParser
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using ProtoBuf;

    /// <summary>
    ///     The helper.
    /// </summary>
    public static class Helper
    {
        #region Public Methods and Operators

        /// <summary>
        /// The sub array.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <param name="length">
        /// The length.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// The <see cref="T[]"/>.
        /// </returns>
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        public static T DeserilizedFromBytes<T>(byte[] buffer)
        {
            using (MemoryStream ms = new MemoryStream(buffer))
            {
                return Serializer.Deserialize<T>(ms);
            }
        }

        public static void Swap<T>(this List<T> list, int x, int y)
        {
            T tmp = list[x];
            list[x] = list[y];
            list[y] = tmp;
        }

        public static int GetBitLength(long num)
        {
            int len = 0;
            while (num > 0)
            {
                num >>= 1;
                len++;
            }

            return len;
        }

        public static int ReadInt32(this BinaryReader br, int count)
        {
            byte[] buffer = new byte[count];
            br.Read(buffer, (int)br.BaseStream.Position, count);
            return BitConverter.ToInt32(buffer, 0);
        }

        public static T[] ConvertEnumToArray<T>() where T : struct
        {
            return (T[])Enum.GetValues(typeof(T));
        }

        #endregion
    }
}