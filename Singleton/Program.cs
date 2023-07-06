using Singleton;

Console.Title = "Singleton";

var logger1 = Logger.Instance;
var logger2 = Logger.Instance;

if (logger1 == logger2 && logger2 == Logger.Instance)
{
    Console.WriteLine("same same ");
}

Logger.Log($"sdfds1 {nameof(logger1)}");
Logger.Log($"sdfds2 {nameof(logger2)}");
Logger.Log($"sdfds3 {nameof(Logger.Instance)}");