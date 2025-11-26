namespace Lab9.Shapes;

public class Rectangle : Shape
{
    public double Width { get; init; }
    public double Height { get; init; }
    public double X { get; init; }
    public double Y { get; init; }


    public override double Area() => Width * Height;


    public override void Draw()
    {
        Console.WriteLine($"Rectangle (W={Width}, H={Height}, X={X}, Y={Y}, Color={Color})");
    }
}