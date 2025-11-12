using System.Runtime.CompilerServices;
using Lab06.Task01;
using Lab06.Task02;
using Lab06.Task03;
using Lab06.Task04;
namespace Lab06;
//namespace Lab06.Task01;



class Program
{
    static void Main(string[] args)
    {
        DemoRectangle();
        CircleDemo();
        ComputerDemo();
        WeightDemo();
    }
    public static void stringDemo()
    {
        
    }

    public static void DemoRectangle()
    {
        Rectangle rect = new Rectangle(height: 100, width: 200.5);
        Console.WriteLine(rect.GetHeight);
        Console.WriteLine(rect.Width);
        rect.Width = -5;
        Console.WriteLine(rect.Width);
        rect.Width = 5;
        System.Console.WriteLine(rect.Width);
    }

    public static void CircleDemo()
    {
        Circle circle = new Circle(5.5);
        circle.Print();
    }

    public static void ComputerDemo()
    {
        Computer pc = new Computer
        {
            RAM = 16,
            HDD = 512,
            HasBacklitKeyboard = true
        };
        Console.WriteLine(pc.INFO);
    }

    public static void WeightDemo()
    {
        Weight w1 = Weight.ofKg(5);
        Weight w2 = Weight.ofGram(250);
        Weight w3 = Weight.ofTon(0.5);
        Weight w4 = Weight.ofDag(20);

        w1.Print();
        w2.Print();
        w3.Print();
        w4.Print();
    }
}