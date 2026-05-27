namespace CreationalPatterns.Creational.FactoryMethod;

// Базовий клас містить бізнес-логіку, але делегує створення продукту нащадкам.
public abstract class Logistics
{
    public abstract Transport CreateTransport();

    public void PlanDelivery()
    {
        var transport = CreateTransport();
        transport.Deliver();
    }
}

public class RoadLogistics : Logistics
{
    public override Transport CreateTransport() => new Truck();
}

public class SeaLogistics : Logistics
{
    public override Transport CreateTransport() => new Ship();
}
