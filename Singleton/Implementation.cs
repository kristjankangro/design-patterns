﻿namespace Singleton;

/*main muudatus singletoni namespace*/

public class Logger
{
    private static Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

    protected Logger()
    {
    }

    public static Logger Instance => _lazyLogger.Value;

    public void Log(string message)
    {
        Console.WriteLine($"Message to log: {message} ");
    }
}