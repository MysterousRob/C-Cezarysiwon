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

        System.Console.WriteLine($"r1: {r1.Width}x{r1.Height}");
        System.Console.WriteLine($"r2: {r2.Width}x{r2.Height}");
        System.Console.WriteLine($"r3 (square): {r3.Width}x{r3.Height}");
    }
    
    public class Rectangle
    {
        public int Width;
        public int Height;

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
    }
}
