namespace Lab02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello There!");
    }

    public static void Example()
    {
        int counterBox = 2;

        Console.WriteLine(2 + counterBox);
        Console.WriteLine(2 - counterBox);
        Console.WriteLine(2 * counterBox);
        Console.WriteLine(2 / counterBox);
        Console.WriteLine(2 % counterBox); // rest module / reszta z dzielenia
    }

    public static void Task1()
    {
        Console.WriteLine("podaj rozmiar boku kwadratu");
        int size = int.Parse(Console.ReadLine());
        //find the points of the triangle 

        int polePowierzchni = size * size;
        Console.WriteLine("pole powierzchni twojego kwadratu" + polePowierzchni);
        Console.WriteLine($"pole powierzchni twojego kwadratu: {size * size}");
    }

    public static void Ex2()
    {
        Console.WriteLine("wpisz procent podatku: ");
        double procent = double.Parse(Console.ReadLine());
        Console.WriteLine("wpisz procent powierzchni: ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine($"wpisz procent powierzchni: {price+procent + price}");
    }

    public static void Ex3()
    {
        double factor = 0.1;
        Console.WriteLine(factor * factor);
        decimal fac = 0.1m;
        Console.WriteLine(fac * fac);
        Console.WriteLine(factor / 2);
        int n = 7;
        Console.WriteLine(n / 21);    
    }

    public static void Ex4()
    {
        Console.WriteLine("wpisz pole koła");
        double area = double.Parse(Console.ReadLine());
        double radius = Math.Sqrt(area / Math.PI);
        Console.WriteLine($"reomień wynosi: {radius}");
        Console.WriteLine(Math.Pow(5,4));
    }

    public static void Ex4()
    {
        char sign = 'a';
        int sinVal = sign; 
        Console.WriteLine((char)sinVal + 200);
    }
}