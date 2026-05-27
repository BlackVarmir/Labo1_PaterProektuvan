namespace CreationalPatterns.Creational.Prototype;

// Базовий клас оголошує метод клонування.
public abstract class Shape
{
    public int    X     { get; set; }
    public int    Y     { get; set; }
    public string Color { get; set; } = "Чорний";

    protected Shape() { }

    // Захищений «копіюючий» конструктор — використовується в Clone().
    protected Shape(Shape source)
    {
        X     = source.X;
        Y     = source.Y;
        Color = source.Color;
    }

    public abstract Shape Clone();
}
