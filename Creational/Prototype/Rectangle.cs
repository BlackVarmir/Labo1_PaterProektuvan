namespace CreationalPatterns.Creational.Prototype;

public class Rectangle : Shape
{
    public int Width  { get; set; }
    public int Height { get; set; }

    public Rectangle() { }
    private Rectangle(Rectangle source) : base(source)
    {
        Width  = source.Width;
        Height = source.Height;
    }

    public override Shape Clone() => new Rectangle(this);

    public override string ToString() =>
        $"Rectangle{{ X={X}, Y={Y}, Color={Color}, W={Width}, H={Height} }}";
}
