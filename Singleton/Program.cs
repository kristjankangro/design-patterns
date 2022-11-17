using Singleton;

Console.Title = "Singleton";

var logger1 = Logger.Instance;
var logger2 = Logger.Instance;

if (logger1 == logger2 && logger2 == Logger.Instance)
{
    Console.WriteLine("same same ");
}

logger1.Log($"sdfds1 {nameof(logger1)}");
logger2.Log($"sdfds2 {nameof(logger2)}");
Logger.Instance.Log($"sdfds3 {nameof(Logger.Instance)}");