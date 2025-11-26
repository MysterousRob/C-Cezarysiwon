using System;
using System.Diagnostics;

namespace Lab05;

class Program
{
    static string[] options = new string[] {"4", "5", "6", "nie można obliczyć"};
    static void Main(string[] args)
    {
        int option = 0;
        Console.WriteLine("Ile jest 2 + 3?");

        while (true)
        {
            PrintMenu(option);

            var key = Console.ReadKey(true);

            // --- MOVING UP ---
            if (key.Key == ConsoleKey.UpArrow && option > 0)
            {
                option--;
            }

            // --- MOVING DOWN ---
            if (key.Key == ConsoleKey.DownArrow && option < options.Length - 1)
            {
                option++;
            }

            // --- EXIT ON ESC ---
            if (key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("\nZakończono program (ESC).");
                break;
            }

            // --- CONFIRM ENTER ---
            if (key.Key == ConsoleKey.Enter)
            {
                if (option == 1) // correct answer index = 1
                {
                    Console.WriteLine("\nPoprawna odpowiedź!");
                    break;
                }

                Console.WriteLine("\nBłąd, spróbuj jeszcze raz.");
                Console.WriteLine("Naciśnij cokolwiek, aby kontynuować...");
                Console.ReadKey(true);
            }
        }
    }

    public static void PrintMenu(int option)
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);

        for (int i = 0; i < options.Length; i++)
        {
            if (i == option)
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

    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static int Reszta(int a, int b)
    {
        return a % b;
    }

    public static int[] EvenArray(int n)
    {
        int[] result = new int[n / 2 + 1];
        for (int i = 0, a = 0; i < result.Length; i++, a += 2)
        {
            result[i] = a;
        }
        return result;
    }
}
