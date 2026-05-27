namespace CreationalPatterns.Creational.Singleton;

// Потокобезпечний Singleton через Lazy<T>.
// Конструктор private — створити екземпляр ззовні неможливо.
public sealed class Logger
{
    private static readonly Lazy<Logger> _instance = new(() => new Logger());

    public static Logger Instance => _instance.Value;

    private Logger()
    {
        Console.WriteLine("[Logger] Створено єдиний екземпляр.");
    }

    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] LOG: {message}");
    }
}
