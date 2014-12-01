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
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        private static StreamWriter sw = new StreamWriter(@"d:\combatlog.json", true, Encoding.Unicode);

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

            parser.Demo.OnCombatLog += Demo_OnCombatLog;
            parser.Parse();
            DateTime t2 = DateTime.Now;
            int ms = (t2 - t1).Milliseconds;
            Console.WriteLine("Total Ms: {0}", ms);

            sw.Close();
        }

        private static void Demo_OnCombatLog(object sender, CombatLogEventArgs args)
        {
            sw.WriteLine(
                JsonConvert.SerializeObject(
                    args.CombatLog,
                    new JsonSerializerSettings() { Formatting = Formatting.Indented }));
        }
    }
}