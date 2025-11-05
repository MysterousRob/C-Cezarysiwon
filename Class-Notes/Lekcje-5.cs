using System;
using System.Diagnostics;

namespace Lekcje5;


class Program {
    static void Main(string[] args)  
    {
        int option = 0;
        while (true)
        {
            PrintMenu(option);
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                option--;
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                option++;
            }
        }
    }

    public static void PrintMenu(int option)
    {
        var option = new string [] {"Opcja 1", "Opcja 2", "Opcja 3", "Opcja 4"};
        Console.Clear();
        Console.SetCursorPosition(left: 0, top: 0);
        for (int i = 0; i < options.Length; i++)
        {
            if (i == options)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[i]);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(options[i]);
            }
        }   


    }
}
