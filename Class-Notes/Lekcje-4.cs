namespace Lab04;

class Program
{
    static decimal[] lastWeekExpence =  {15.5m, 25.30m, 40, 51.45m, 100, 20, 0};
    static decimal[] currentWeekExpence = {45.6m, 12.67m, 5.85m};
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static void Example1()
    {
        Console.WriteLine($"Wydatki z wtorku {lastWeekExpence[1]}");
        Console.WriteLine($"Wydatki z niedzieli {lastWeekExpence[^1]}");
        Console.WriteLine($"Wydatki z piątku {lastWeekExpence[^3]}");
        Console.WriteLine($"Ile dni w tablicy {lastWeekExpence.Length}");
        lastWeekExpence[0] += 5; //lastWeekExpence[0] = lastWeekExpence[0] + 5; *,/,%,-
        Console.WriteLine($"Wydatki z poniedziałku {lastWeekExpence[0]}");
    }
    
    public static void Task1()
    {
        Console.WriteLine($"Suma wydatków z środy, czwartku i piątku {lastWeekExpence[2] + lastWeekExpence[3] +  lastWeekExpence[4]}");
        lastWeekExpence[^1] += 10.5m;
        Console.WriteLine($"Aktualizacja niedieli {lastWeekExpence[^1]}");
    }
    
    public static void Example2()
    {
        currentWeekExpence[^1] += 3.5m;
        currentWeekExpence[currentWeekExpence.Length - 1] += 3.5m; //wersja dgy nie ma operatora ^
        Console.WriteLine($"Ile dni zawiera tabela wydatków z bierzącego tygodnia {currentWeekExpence.Length}");
    }
    public static void Example3()
    {
        decimal sum = 0;
        int i = 0;
        sum += currentWeekExpence[i++]; // i -> 0
        sum += currentWeekExpence[i++]; // i -> 1
        sum += currentWeekExpence[i++]; // i -> 2
        Console.WriteLine($"Suma wydatków {sum}");
        sum = 0;
        for (i = 0; i < currentWeekExpence.Length; i++) // zmienna iteracyjna to i
        {
            sum += currentWeekExpence[i];
        }
    
        Console.WriteLine($"Suma wydatków z pętli for {sum}");
    }
    
    public static void Task2()
    {
        decimal sum = 0;
        for ( int i = 0; i < lastWeekExpence.Length; i++)
        {
            sum += lastWeekExpence[i];
        }
    
        Console.WriteLine($"Suma wydatków z ostatniego tygodnia {sum}");
    }

    public static void Example4()
    {
        int n = int.Parse(Console.ReadLine()); //liczba wierszy
        int m = int.Parse(Console.ReadLine()); //liczba znaczków w wierszu
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine("#");  
            }
            Console.WriteLine();
        }
    }
    public static void Task3()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
    // w domu => dukowanie od n do 1, drukowanie co drugiej liczby

    //program drukuje liczby rosnąco do wprowadzenia znaku q
    public static void Example5()
    {
        int liczba = 0;
        while (Console.ReadKey(true).Key != ConsoleKey.Q)
        {
            Console.WriteLine(liczba++);
        }

        Console.WriteLine("Koniec");
    }

    public static void Example6()
    {
        int liczba = 0;
        while (true)
        {
            if(Console.ReadKey(true).Key == ConsoleKey.Q)
            {
                break;
            }

            Console.WriteLine("Koniec");
        }
    }

    public static void Example7()
    {
        int liczba = 0;
        while (true)
        {
            if(Console.ReadKey(true).Key != ConsoleKey.Q)
            {
                Console.WriteLine(liczba++);
                continue;
            }
            break;
            
        }
        Console.WriteLine("Koniec");
    }
}