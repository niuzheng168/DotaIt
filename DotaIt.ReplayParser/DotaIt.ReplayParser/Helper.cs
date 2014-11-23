namespace DotaIt.ReplayParser
{
    using System;
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


        #endregion
    }
}