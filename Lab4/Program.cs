using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Serialization;

namespace Lab4;


class Program
{
    static void Main(string[] args)
    {
        //Zadanie1();
        //Zadanie2();
        //Zadanie3();
        //Zadanie4();
        //Zadanie5();
        //Zadanie6();
        //Zadanie7();
        //Zadanie8();
        Zadanie9();
    }


    public static void Zadanie1()
    {
        double[] factors = { 2.4, 1.9, -0, 5 };
        double x = 2.3;


        if (factors.Length < 3)
        {
            Console.WriteLine("Nie można obliczyć równiana, nie ma wszystkich współchynników");
            return;
        }
        if (factors.Length > 3)
        {
            Console.WriteLine("Tablica ma więcej niż 3 elementy -- używam tylko pierwszych trzech.");
        }


        double a = factors[0];
        double b = factors[1];
        double c = factors[2];

        double y = a * x * x + b * x + c;
        System.Console.WriteLine($"dla x = {x}, wynik równiania wynosi: {y:F2}");
    }

    public static void Zadanie2()
    {
        double[] arr = { 12.5, 6.7, 2.89, 10.1, 2.45 };

        Console.WriteLine("Elementy tablicy od końca");

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
        // --- or ---
        //int i = arr.Length - 1;
        //while (i >= 0)
        //{
        //    Console.WriteLine(arr[i]);
        //    i--;
        //}
    }

    public static void Zadanie3()
    {
        int suma = 0;
        string input = "";

        Console.WriteLine("Wpisuj liczby całkowit (wpisz cokolwiek innego aby zakończyć)");

        while (true)
        {
            input = Console.ReadLine();

            if (int.TryParse(input, out int liczba))
            {
                suma += liczba;
            }
            else
            {
                Console.WriteLine("Nie wpisałeś liczby całkowitej -- koniec programu.");
                break;
            }
        }

        Console.WriteLine($"Suma wpisanych liczb: {suma}");
    }

    public static void Zadanie4()
    {
        double[,] arr = { { 1.1, 3.5, 2.56 }, { 1.4, 34, 7 }, { 1.5, 56, 2.6 } };
        double b = 4.1;

        Console.WriteLine($"Liczby większe od {b}");

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > b)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }
        }
    }

    public static void Zadanie5()
    {
        int n;

        while (true)
        {
            Console.Write("Podaj dodatnią liczbę całkowitą n: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n))
            {
                if (n > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("liczba musi być dodatnia!");
                }
            }
            else
            {
                System.Console.WriteLine("To nie jest liczba całkowita");
            }
        }

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('#', i));
        }
    }

    public static void Zadanie6()
    {
        Console.Write("Podaj liczbę elementów n:");
        int n = int.Parse(Console.ReadLine());

        double[] values = new double[n];

        Console.WriteLine($"Podaj {n} liczb typu double");

        for (int i = 0; i < n; i++)
        {
            values[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n Co druga liczba (od końca): ");

        for (int i = n - 1; i >= 0; i -= 2)
        {
            Console.WriteLine(values[i]);
        }
    }

    public static void Zadanie7()
    {
        Console.Write("Podaj liczbę wierszy (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę kolumn (m): ");
        int m = int.Parse(Console.ReadLine());


        char[,] rect = new char[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                {
                    rect[i, j] = '#';
                }
                else
                {
                    rect[i, j] = ' ';
                }
            }
        }

        Console.WriteLine("\nProstokąt:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(rect[i, j]);
            }
            Console.WriteLine();
        }
    }

    public static void Zadanie8()
    {
        Console.Write("Podaj liczbę całkowitą typu ling: ");
        long n = long.Parse(Console.ReadLine());

        n = Math.Abs(n);

        int liczbaCyfr = 0;

        if (n == 0)
        {
            liczbaCyfr = 1;
        }
        else
        {
            while (n > 0)
            {
                n /= 10;
                liczbaCyfr++;
            }
        }

        Console.WriteLine($"Liczba cyfr wynisi: {liczbaCyfr}");
    }
    
    public static void Zadanie9()
    {
        Console.Write("Podaj wysokość trójkąta (n): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < (2 * (n - i) - 1); k++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }
    }
}