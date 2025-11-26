namespace Lab06
{
    public class Rectangle
    {
        private double _width;
        private double _height;

        public double Area => _width * _height;

        public double Perimeter => 2 * (_width + _height);

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
            _height = height;
            _width = width;
        }

        public double GetHeight()
        {
            return _height;
        }

        public static string Unit = "cm";

        public static Rectangle Squere(double side)
        {
            return new Rectangle(side, side);
        }
    }
}
