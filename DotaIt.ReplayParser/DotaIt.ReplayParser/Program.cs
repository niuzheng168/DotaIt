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
            DateTime t1 = DateTime.Now;
            Parser parser = new Parser(@"D:\1016671075.dem");
            parser.Parse();
            DateTime t2 = DateTime.Now;
            int ms = (t2 - t1).Milliseconds;
            Console.WriteLine("Total Ms: {0}", ms);
            DemoHelper.ExtractCombatLogs(parser.Demo);
        }
    }
}