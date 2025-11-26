using System;
using System.IO.Compression;
namespace Lab5;

//in this exercise we will be referencing multiple functions within all of the homework assignments
class Program
{
    static void Main(string[] args)
    {
        // ---- Uncomment as u go along ---- //

        //Zadanie1();
        //Zadanie2();
        //Zadanie3();
        //Zadanie4();
        //Zadanie5();
    }
    public static void Zadanie1()
    {
        double liczba = 12.34;
        Print(liczba);
        Print(5.678);
        Print(-3.14);
    }

    public static void Print(double value)
    {
        Console.WriteLine($"Wartość argumentu = {value}");
    }

    public static void Zadanie2()
    {
        Console.Write("Podaj promień koła: ");
        double r = double.Parse(Console.ReadLine());

        double area = CircleArea(r);
        Console.WriteLine($"Pole koła: {area}");
    }

    public static double CircleArea(double r)
    {
        if (r < 0)
            return double.NaN;

        return Math.PI * r * r;
    }

    public static void Zadanie3()
    {
        Console.WriteLine("Domyślne wartośći: ");
        Console.WriteLine(QuadraticEquation());

        Console.WriteLine("\nWłasne wartości:");
        Console.WriteLine(QuadraticEquation(2, 2, 3, 4));
    }

    public static double QuadraticEquation(
        double x = 0.0,
        double a = 1.0,
        double b = 1.0,
        double c = 1.0)
    {
        return a * x * x + b * x + c;
    }

    public static void Zadanie4()
    {
        System.Console.WriteLine("=== Obliczone równiana kwadratowego f(x) = a·x² + b·x + c ===");

        double x = ReadDouble("Podaj x: ");
        double a = ReadDouble("Podaj a: ");
        double b = ReadDouble("Podaj b: ");
        double c = ReadDouble("Podaj c: ");

        double result = QuadraticEquation(x, a, b, c);
        Console.WriteLine($"\nWynik równania: {result}");
    }

    public static double ReadDouble(string message)
    {
        double value;
        Console.WriteLine(message);

        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Niepopravny format liczby. Spróbuj ponownie: ");
        }

        return value;
    }
    
    public static void Zadanie5()
    {
        Console.Write("Podaj kod (0, 1, 2 lub inny): ");
        int code = int.Parse(Console.ReadLine()!);

        Console.Write("Podaj cenę: ");
        decimal price = decimal.Parse(Console.ReadLine()!);

        decimal tax = code == 0 ? price * 0.08m :
                  (code == 1 ? price * 0.23m :
                  (code == 2 ? price * 0.17m : price * 0.12m));

        Console.WriteLine($"\nPodatek dla kodu {code}: {tax} zł");
    } 
}