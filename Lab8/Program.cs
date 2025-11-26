using System;
using System.Globalization;
using System.Text;
using System.Threading;


namespace Lekcje8;

class Program
{
    static void Main(string[] args)
    {
        //ćwiczenie1();
        ćwiczenie2();
    }

    public static void ćwiczenie1()
    {
        string msgEmpty = string.Empty;
        string msgHello = "Hello";
        string msgInterpolated = $"Długość słowa '{msgHello}' to {msgHello.Length}";
        Console.WriteLine(msgInterpolated);


        char[] chars = { 'C', '#', ' ', 'L', 'a', 'b' };
        string msgFromChars = new string(chars);
        Console.WriteLine($"Z tablicy znaków: {msgFromChars}");

        string a = "abcd";
        string b = "efgh";
        a += b;
        Console.WriteLine($"Po połączeniu: {a}");
        Console.WriteLine($"Wielkie litry: {a.ToUpper()}");
        Console.WriteLine($"Orginał pozostał: {a}");

        System.Console.WriteLine("\nIteracja po znakach");
        string str = "C#123";
        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine($"Znak[{i}] = {str[i]}");
        }


        Console.WriteLine("\nZamiana cyfr na '~':");
        char[] tab = str.ToCharArray();
        for (int i = 0; i < tab.Length; i++)
        {
            if (char.IsDigit(tab[i])) tab[i] = '~';
        }
        str = new string(tab);
        Console.WriteLine($"Nowy łancuch: {str}");

        string sample = " ^ąBcDęFgh1234567890*&@#^ ";

        Console.WriteLine("\n*** Methody zmiany wielkości znaków ***");
        Console.WriteLine(sample.ToUpper());
        Console.WriteLine(sample.ToLower());

        Console.WriteLine("\n*** Metoda split ***");
        string data = "adam eva karol";
        string[] names = data.Split(" ");
        Console.WriteLine(string.Join(", ", names));

        Console.WriteLine("\n **** Methoda Replace ****");
        Console.WriteLine(sample.Replace("1234567890", "-DIGITS-"));

        Console.WriteLine("\n**** Methody logiczne ***");
        Console.WriteLine($"zawiera 'Fgh' ? {sample.Contains("Fgh")}");
        Console.WriteLine($"Zaczyna się of '^'? {sample.StartsWith("^")}");
        Console.WriteLine($"Konczy się od '^' ? {sample.EndsWith("^")}");

        Console.WriteLine("\n*** Netoda Trim");
        Console.WriteLine($"| {sample.Trim()}");
    }

    public static void ćwiczenie2()
    {
        Console.WriteLine("=== Ćwiczenie 2: StringBuilder ===\n");

        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= 20; i++)
        {
            sb.Append(i.ToString());
            sb.Append(' ');

            if (sb.Length > 0 && sb[sb.Length - 1] == '0')
            {
                sb.Remove(sb.Length - 1, 1);
            }
        }

        string result = sb.ToString();

        Console.WriteLine("Wynikowy łańcuch:");
        Console.WriteLine(result);
        Console.WriteLine($"\nDługość tekstu: {result.Length}");
    }
}