namespace Lab9.Shapes;


public class Point : IDrawable
{
    public int Color { get; init; }
    public double X { get; init; }
    public double Y { get; init; }

    public void Draw()
    {
        System.Console.WriteLine($"Point at ({X}, {Y}), color={Color}");
    }

    public override string ToString()
    {
        return $"Class point{{ X: {X}, Y: {Y} }}";
    }
}