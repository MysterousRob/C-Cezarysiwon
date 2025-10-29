using System;

namespace Lekcje4;

class Program
{
    static decimal[] lastWeekExpense = {15.5m, 25.3m, 40m, 51.45, 100, 21, 0};
    public static void Main(string[] args)
    {
        System.Console.WriteLine("hwlloq world");
    }

    public static void Example1()
    {
        System.Console.WriteLine($"wydadtkiz wtorku {lastWeekExpense [1]}");
        System.Console.WriteLine($"wydatki z niedzieli{lastWeekExpense[^1]}");
        System.Console.WriteLine($"trzecie od konca {lastWeekExpense[^3]}");

        System.Console.WriteLine($"ile dni w tablicy {lastWeekExpense.Length}");


        lastWeekExpense[0] += 5;
        System.Console.WriteLine($"wyydadtki z poniedzialku {lastWeekExpense[0]}");
    }
}
