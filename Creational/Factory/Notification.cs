namespace CreationalPatterns.Creational.Factory;

// Спільний інтерфейс для всіх типів сповіщень.
public interface INotification
{
    void Send(string message);
}

public class EmailNotification : INotification
{
    public void Send(string message) =>
        Console.WriteLine($"  [Email] Надсилаю листа: \"{message}\"");
}

public class SmsNotification : INotification
{
    public void Send(string message) =>
        Console.WriteLine($"  [SMS] Надсилаю SMS: \"{message}\"");
}

public class PushNotification : INotification
{
    public void Send(string message) =>
        Console.WriteLine($"  [Push] Надсилаю push-сповіщення: \"{message}\"");
}
