using System;
using System.Diagnostics;

namespace SingletonPattern
{
    public class Logger : ILogger
    {
        private static readonly Lazy<Logger> Lazy = new Lazy<Logger>(() => new Logger());

        public static Logger Instance => Lazy.Value;

        private Logger() { }

        public void LogDebug(string message)
        {
            Debug.WriteLine(message);
        }

        public void LogTrace(string message)
        {
            Trace.WriteLine(message);
        }

        public void LogConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}