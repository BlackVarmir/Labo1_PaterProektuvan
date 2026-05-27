namespace CreationalPatterns.Creational.AbstractFactory;

// Абстрактна фабрика оголошує методи створення кожного типу продукту.
public interface IGUIFactory
{
    IButton   CreateButton();
    ICheckbox CreateCheckbox();
}

// Конкретні фабрики створюють узгоджені родини продуктів.
public class WindowsFactory : IGUIFactory
{
    public IButton   CreateButton()   => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}

public class MacFactory : IGUIFactory
{
    public IButton   CreateButton()   => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}
