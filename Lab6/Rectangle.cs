namespace Lab06;

public class Rectangle 
{
    private double _width;
    private double _height;

    public double Area
    {
        get
        {
            return _width * _height;
        }
    }
    public double Width
    {
        get { return _width; }
        set
        {
            if (value <= 0)
            {
                return;
            }
            _width = value;
        }
    }
    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
            {
                return;
            }
            _height = value;
        }
    }

    public Rectangle(double height, double width)
    {
        this._height = height;
        this._width = width;
    }

    public static double GetHeight()
    {
        return _height;
    }
}