using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

namespace Lekcje4;

class Program
{
    static decimal[] lastWeekExpense = { 15.5m, 25.3m, 40m, 51.45m, 100m, 21m, 0m };
    private static decimal[] currentWeekExpense = {45.6m, 12.67m, 5.85m};
    public static void Main(string[] args)
    {
        //Example1();
        //Example2();
        Example3();

    }

    public static void Example1()
    {
        Console.WriteLine($"wydadtkiz wtorku {lastWeekExpense[1]}");
        Console.WriteLine($"wydatki z niedzieli{lastWeekExpense[^1]}");
        Console.WriteLine($"trzecie od konca {lastWeekExpense[^3]}");

        Console.WriteLine($"ile dni w tablicy {lastWeekExpense.Length}");


        lastWeekExpense[0] += 5;
        Console.WriteLine($"wyydadtki z poniedzialku {lastWeekExpense[0]}");
    }
    //zaumuj wydadki z środy 
    public static void Task1()
    {

    }

    public static void Example2()
    {
        //dodaj 3.5 do wydadków z dnia bieżącego
        currentWeekExpense[^1] += 3.5;
        currentWeekExpense[currentWeekExpense.Length - 1] += 4.5m;

        Console.WriteLine($"ile dni zawiera tabela wydadków z bieżącego tygodnia {currentWeekExpense.Length}");
    }

    public static void Example3()
    {
         // obliczamy sumę wydatków z bieżącego tygodnia
        decimal sum = 0;
        int i = 0;
        sum += currentWeekExpense[i++];
        sum += currentWeekExpense[i++];
        sum += currentWeekExpense[i++];

        Console.WriteLine($"suma wydatków: {sum}");

        // obliczamy sumę wydatków z bieżącego tygodnia używając pętli for
        sum = 0;
        for (i = 0; i < currentWeekExpense.Length; i++)
        {
            sum += currentWeekExpense[i];
        }
        Console.WriteLine($"suma wydatków z pętli for: {sum}");
    }
    //oblicz sumę wydadków z ostatniego tygodnia lastWeekExpense
    public static void Task2()
    {
        decimal sum = 0;

        for (i = 0; i < currentWeekExpense.Length; i++)
        {
            sum += lastWeekExpense[i];
        }

        Console.WriteLine($"Suma wydatków z ostatniego tygodnia: {sum}");
    }

    public static void Example4()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.WriteLine("#");
            }
            Console.WriteLine();
        }
    }
    // wydrukuj liczby od 1 - n
    //np dla n = 5
    //1
    //2
    //3
    //4
    //5
    public static void Task3()
    {
        int n = int.Parse(Console.ReadLine());
        for (int liczba = 1; liczba <= n; liczba++)
        {
            Console.WriteLine(liczba);
        }
    }

    static void Example5()
    {
        int liczba = 0;

        while ()
    }

    public static void Example6()
    {

    }
    
    public static void Example7()
    {
        int liczba = 0;
        while(true)
        {
            if(Console.ReadKey( intercept: true).Key != ConsoleKey.Q)
            {
                System.Console.WriteLine(

                );
            }
        }
    }
}
