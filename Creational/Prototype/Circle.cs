namespace CreationalPatterns.Creational.Prototype;

public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle() { }
    private Circle(Circle source) : base(source) => Radius = source.Radius;

    public override Shape Clone() => new Circle(this);

    public override string ToString() =>
        $"Circle{{ X={X}, Y={Y}, Color={Color}, Radius={Radius} }}";
}
