namespace Lab9.Shapes;


public abstract class Shape : IDrawable
{
    public int Color { get; init; }
    public abstract double Area();
    public abstract void Draw();
}