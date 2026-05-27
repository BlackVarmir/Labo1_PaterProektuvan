namespace CreationalPatterns.Creational.AbstractFactory;

// Абстрактні продукти — родини об'єктів, що мають створюватись разом.
public interface IButton   { void Render(); }
public interface ICheckbox { void Render(); }

// Конкретні продукти для Windows.
public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("  [Windows] Кнопка з прямими кутами.");
}
public class WindowsCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("  [Windows] Прямокутний чекбокс.");
}

// Конкретні продукти для macOS.
public class MacButton : IButton
{
    public void Render() => Console.WriteLine("  [macOS] Кнопка з заокругленими кутами.");
}
public class MacCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("  [macOS] Заокруглений чекбокс.");
}
