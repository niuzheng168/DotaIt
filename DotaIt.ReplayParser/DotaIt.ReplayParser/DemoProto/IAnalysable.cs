namespace DotaIt.ReplayParser
{
    using System.Security.Cryptography.X509Certificates;

    /// <summary>
    /// The MessageHandler interface.
    /// </summary>
    internal interface IAnalysable
    {
        void AnalysisMessage(DemoInfo demo);
    }
}