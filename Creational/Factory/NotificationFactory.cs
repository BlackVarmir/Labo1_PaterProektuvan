namespace CreationalPatterns.Creational.Factory;

public enum NotificationType { Email, Sms, Push }

// Проста (статична) фабрика: один клас з методом створення, який повертає
// потрібний продукт залежно від параметра. На відміну від Factory Method,
// тут НЕМАЄ ієрархії творців і перевизначення в нащадках — уся логіка вибору
// зосереджена в одному місці.
public static class NotificationFactory
{
    public static INotification Create(NotificationType type) => type switch
    {
        NotificationType.Email => new EmailNotification(),
        NotificationType.Sms   => new SmsNotification(),
        NotificationType.Push  => new PushNotification(),
        _ => throw new ArgumentOutOfRangeException(
            nameof(type), type, "Невідомий тип сповіщення.")
    };
}
