namespace DotaIt.ReplayParser
{
    using System.IO;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            byte[] data = File.ReadAllBytes(
                @"D:\Code\GO\src\github.com\dotabuff\yasha\examples\fileinfo\1016671075.dem");

            Parser parser = new Parser(data);

            parser.GetHeader();

        }
    }
}