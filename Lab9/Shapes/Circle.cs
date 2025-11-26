namespace Lab9.Shapes;

public class Circle : Shape
{
    public double Radius { get; init; }
    public double CenterX { get; init; }
    public double CenterY { get; init; }

    public override double Area() => Math.PI * Radius * Radius;

    public override void Draw()
    {
        System.Console.WriteLine($"Circle (R={Radius}, X={CenterX}, Y={CenterY}, Color={Color})");
    }
}