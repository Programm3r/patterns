using System;
using System.Diagnostics;

namespace SingletonPattern
{
    public class Logger : ILogger
    {
        private static Logger _logger;

        private Logger()
        {
        }

        public static ILogger Instance => _logger ?? (_logger = new Logger());

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