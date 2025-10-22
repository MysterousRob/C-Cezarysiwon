namespace Lab02;

class Program
{
    //static void Main(string[] args)
    //{
    //    Example1();
    //    Task1();
    //    Task2();
    //    Example2();
    //    Example3();
    //    Example4();
    //    Example5();
    //    Example6();
    //}

    public static void Example1()
    {
        int counterBox = 7;
        Console.WriteLine(2 + counterBox);
        Console.WriteLine(counterBox - 3);
        Console.WriteLine(counterBox * 3);
        Console.WriteLine(counterBox / 2);
        Console.WriteLine(counterBox % 2); //reszta z dzielenia, operator modulo
        Console.WriteLine(counterBox);
    }

    public static void Task1()
    {
        Console.WriteLine("Podaj rozmiar boku kwadratu");
        int size = int.Parse(Console.ReadLine()); // wczytywanie danej z klawiatury
        //oblicz i wyświetl pole powierzchni kwadratu
        int polePowierzchni = size * size;
        Console.WriteLine("Pole powierzchni twojego kwadratu: " + polePowierzchni);
        Console.WriteLine($"Pole powierzchni twojego kwadratu: {polePowierzchni}");
        Console.WriteLine($"Pole powierzchni twojego kwadratu: {size * size}"); //interpolacja łańcuchowa
    }
    public static void Example2()
    {
        
        
        Console.WriteLine("Wpisz procent podatku");
        double procent = double.Parse(Console.ReadLine());
        Console.WriteLine("Wpisz cenę");
        double price =  double.Parse(Console.ReadLine());
        Console.WriteLine($"Cena brutto : {price*procent + price}");
    }

    public static void Example3()
    {
        double factor = 0.5;
        Console.WriteLine(factor * factor);
        decimal fac = 0.1m; // wyrażania wartości walutowych
        Console.WriteLine(fac * fac);
        Console.WriteLine(factor / 2);
        int n = 7;
        Console.WriteLine(n / 2.0);
    }

    public static void Task2()
    {
        //oblicz promień koła na podstawie pola powierzchni
        Console.WriteLine("Wpisz pole koła");
        double area = double.Parse(Console.ReadLine());
        
        double radius = Math.Sqrt(area / 3.14); //pierwiastek z liczby to Math.Sqrt(liczba)
        double radius1 = Math.Sqrt(area / Math.PI);
        Console.WriteLine($"Promień wynosi: {radius}");
        Console.WriteLine($"Promień wynosi: {radius1}");
    }

    public static void Example4()
    {
        //wyświetl 5 do potęgi 4 za pomocą Math.Pow
                
        Console.WriteLine("Wpisz liczbę");
        double area = double.Parse(Console.ReadLine());
        double pow = Math.Pow(area, 4);
        Console.WriteLine($"Potęga wynosi: {pow}");
    }

    public static void Example5()
    {
        //char sign = 'a';
        //Console.WriteLine(sign + 2);

        char sign = '0';
        int signVal = sign;
        Console.WriteLine((char)(signVal + 200)); //rzutowanie do typu char
    }

    public static void Example6()
    {
        bool isActive = true;
        Console.WriteLine(isActive);
        bool isActive2 = false;
        Console.WriteLine(isActive2);
    }
}

//poćwiczyć zadania z kusu (lab2)