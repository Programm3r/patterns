namespace SingletonPattern
{
    public interface ILogger
    {
        void LogDebug(string message);

        void LogTrace(string message);

        void LogConsole(string message);
    }
}