
namespace Lab06.Task01 {
    public class Circle
    {
        private double _radius;
        private double _x;
        private double _y;

        public Circle(double radius)
        {
            _radius = radius;
            _x = 0;
            _y = 0;
        }

        public void Print()
        {
            Console.WriteLine($"Koło o promieniu {_radius} ze środkiem w punkcie <{_x}, {_y}>");
        }

    } 
}