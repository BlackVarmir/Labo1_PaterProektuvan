namespace CreationalPatterns.Creational.FactoryMethod;

// Спільний інтерфейс продуктів, які створює фабричний метод.
public abstract class Transport
{
    public abstract void Deliver();
}

public class Truck : Transport
{
    public override void Deliver() =>
        Console.WriteLine("  Доставка вантажу автомобілем по землі.");
}

public class Ship : Transport
{
    public override void Deliver() =>
        Console.WriteLine("  Доставка вантажу кораблем по морю.");
}
