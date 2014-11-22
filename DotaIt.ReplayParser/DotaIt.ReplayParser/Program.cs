// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotaIt.ReplayParser
{
    using System;
    using System.IO;

    using Newtonsoft.Json;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            Parser parser = new Parser(@"E:\1016671075.dem");

            string header = parser.GetDemoHeader();
            Console.WriteLine(header);

            var fileInfo = parser.DirectlyReadFileInfo();
            Console.WriteLine(JsonConvert.SerializeObject(fileInfo));
        }
    }
}