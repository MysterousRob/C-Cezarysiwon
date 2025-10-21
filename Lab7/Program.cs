using System;
using System.Drawing;

namespace Lab7;


class Program
{
    static void Main(string[] args)
    {
        Rectangle r1 = new Rectangle();
        Rectangle r2 = new Rectangle(5, 8);
        Rectangle r3 = new Rectangle(4);

        Console.WriteLine($"r1: {r1.Width}x{r1.Height}");
        Console.WriteLine($"r2: {r2.Width}x{r2.Height}");
        Console.WriteLine($"r3 (square): {r3.Width}x{r3.Height}");

        Rectangle rect = new Rectangle(5, 7);
        Console.WriteLine($"Obwód prostokąta: {rect.GetPerimeter()}");

        rect.Move(3, 2);
        Console.WriteLine("Przesunięto prostokąt o (3,2)");

        rect.X = 10;
        rect.Y = 15;
        Console.WriteLine($"Pozycja: ({rect.X}, {rect.Y})");

        rect.X = -5;
        Console.WriteLine($"Po zmianie X na -5: ({rect.X}, {rect.Y})");

        Console.WriteLine($"Obwód z metody: {rect.GetPerimeter()}");
        Console.WriteLine($"Obwód z właściwości: {rect.Perimeter}");
    }
    
    public class Rectangle
    {
        public int Width;
        public int Height;

        private int _x;
        private int _y;


        public Rectangle()
        {
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        }

        public int X
        {
            get { return _x; }
            set
            {
                if (value >= 0)
                    _x = value;
            }
        }
        
        public int Y
        {
            get { return _y; }
            set
            {
                if (value >= 0)
                {
                    _y = value;
                }
            }
        }
        
        public int Perimeter
        {
            get
            {
                return 2 * (Width + Height);
            }
        }
        // ---- Methods ---- //
        public int GetPerimeter()
        {
            return 2 * (Width + Height);
        }
        
        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
