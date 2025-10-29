using System;
using System.Drawing;

namespace Lab7;


class Program
{
    static void Main(string[] args)
    {
        Rectangle rect1 = Rectangle.Square(4);
        Rectangle rect2 = Rectangle.DoubleHeight(3);

        System.Console.WriteLine($"Square -> Width: {rect1.Width}, Height: {rect1.Height}, Perimeter: {rect1.Perimeter}, ");
        System.Console.WriteLine($"DoublHeight -> {rect2.Width}, Height: {rect2.Height}, Perimeter: {rect2.Perimeter}");

        System.Console.WriteLine($"Maksymalny rozmiar prostokąta: {Rectangle.MaxSize}");
    }

    public class Rectangle
    {
        public int Width;
        public int Height;

        private int _x;
        private int _y;

        public static readonly int MaxSize = 1000;

        // --- Konstructors --- //
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
        // ------ Properties ------ // 
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
        public static Rectangle Square(int size)
        {
            return new Rectangle()
            {
                Width = size,
                Height = size
            };
        }
        public static Rectangle DoubleHeight(int width)
        {
            return new Rectangle()
            {
                Width = width,
                Height = width * 2
            };
        }
    }
}
