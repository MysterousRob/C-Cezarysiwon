using System.Runtime.ConstrainedExecution;
using Lab06.Task01;
using Lab06.Task02;
using Lab06.Task03;
using Lab06.Task04;
namespace Lab06;
//namespace Lab06.Task01;



class Program
{
    //uncoment to test
    static void Main(string[] args)
    {
        //DemoRectangle();
        //CircleDemo();
        //Stringdemo();
        //ComputerDemo();
        //WeightDemo();
        //VendingMachineDemo();
    }
    public static void StaticDemo()
    {
        Math.Acos(45);
    }

    public static void DemoRectangle()
        {
            Rectangle squere = Rectangle.Squere(5);
            string result = string.Concat("abc", "def");
            Rectangle rect = new Rectangle(100, 200.5);
            Console.WriteLine(Rectangle.Unit);
            Console.WriteLine(rect.Height);
            Console.WriteLine(rect.Width); // wywołanie akcesora get
            rect.Width = -5; // wywołanie akcesora set
            Console.WriteLine(rect.Width);
            rect.Height = -10;
            Console.WriteLine(rect.Height);
            Console.WriteLine(rect.Area);
            Console.WriteLine(rect.Perimeter);
        }

    public static void CircleDemo()
    {
        Circle circle = new Circle(5.5);
        circle.Print();
    }


    public static void  Stringdemo()
    {
        string str = "Helow World";
        System.Console.WriteLine(str);
        str = "ABCabc";
        System.Console.WriteLine(str.ToUpper());
        System.Console.WriteLine(str.ToLower());
        System.Console.WriteLine(str.Length);

        Console.WriteLine(str.Contains("abc"));
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'A')
            {
                continue;
            }

            if (char.ToLower(str[i]) == 'a')
            {
                continue;
            }

            // if (str[i] == 'A')
            // {
            //     continue;
            // }
            Console.WriteLine(str[i]);
        }

        Console.WriteLine(str.StartsWith("A"));
        Console.WriteLine(str.EndsWith("A"));
        string[] names = ["Adam", "Ewa", "Rafał", "Albert", "Alicja"];
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i].EndsWith("a"))
            {
                Console.WriteLine(names[i]);
            }    
        }

        string line = new string('#', 10);
        Console.WriteLine(line);
        PrintRectangle(4, 3);
    }

    
    public static void PrintRectangle(int width, int height)
    {
        string rec = new string('#', width);
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine(rec);
        }
        
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

    public static void VendingMachineDemo()
    {
        VendingMachine machine = new VendingMachine();

        machine.InsertCoin(5);
        machine.InsertCoin(1);
        machine.InsertCoin(7);

        Console.WriteLine($"Wartość monet w automacie: {machine.Amount}");
    }
}