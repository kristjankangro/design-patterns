namespace Singleton
{
    public class Logger
    {
        private static Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

        protected Logger()
        {
        }

        public static Logger Instance => _lazyLogger.Value;

        public static void Log(string message)
        {
            Console.WriteLine($"Message to log: {message} ");
        }
    }
}