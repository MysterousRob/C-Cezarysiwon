using System;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Lab3;

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
    }

    public static void Zadanie1()
    {
        decimal balans = 56;
        bool isCreditCardValid = false;
        decimal price = 45;

        bool canPay = (balans >= price) && isCreditCardValid;

        Console.WriteLine(canPay);
    }

    public static void Zadanie2()
    {
        double a = 5;
        double b = 1;
        double c = 3;

        bool isTriangle = (a + b > c) && (a + c > b) && (b + c > a);

        Console.WriteLine(isTriangle);
    }

    public static void Zadanie3()
    {
        double cx = 2.56;
        double cy = 4.6;
        double cradius = 5;
        double x = 6.4;
        double y = 2.234;

        double distanceSquared = Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2);
        bool isOutside = distanceSquared > Math.Pow(cradius, 2);

        Console.WriteLine(isOutside);
    }

    public static void Zadanie4()
    {
        int rx = 56;
        int ry = 34;
        int width = 23;
        int height = 12;
        int x = 56;
        int y = 40;

        bool isOnBorder =
                 (x == rx && y >= ry && y <= ry + height) ||        // lewa
                 (x == rx + width && y >= ry && y <= ry + height) || // prawa
                 (y == ry && x >= rx && x <= rx + width) ||          // góra
                 (y == ry + height && x >= rx && x <= rx + width);   // dół

        Console.WriteLine(isOnBorder);
    }

    public static void Zadanie5()
    {
        double a = 2.5;
        double b = -0.5;
        double c = 1.5;

        double delta = a * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"Dwa pierwiastki: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Jeden pierwiastek podwojny: x = {x}");
        }
        else
        {
            Console.WriteLine("Nie mozna otrzymac pierwiastkow rzeczywistych!");
        }
    }

    public static void Zadanie6()
    {
        int code = 4;
        int quantity = 11;
        decimal price = 3.5m;
        decimal sellPrice;


        if (code < 10)
        {
            sellPrice = price;
        }
        else if (code >= 10 && code <= 15)
        {
            sellPrice = price * 0.95m;
        }
        else
        {
            if (quantity <= 10)
                sellPrice = price * 1.05m;
            else if (quantity <= 20)
                sellPrice = price;
            else if (quantity < 100)
            {
                int discount = quantity / 10;
                sellPrice = price * (1 - discount / 100m);
            }
            else
                sellPrice = price * 0.9m;
        }
        Console.WriteLine($"Price: {sellPrice}");
    }

    public static void Zadanie7()
    {
        int decimalNumber = 0;

        switch (decimalNumber)
        {
            case 1: Console.WriteLine("I"); break;
            case 2: Console.WriteLine("II"); break;
            case 3: Console.WriteLine("III"); break;
            case 4: Console.WriteLine("IV"); break;
            case 5: Console.WriteLine("V"); break;
            case 6: Console.WriteLine("VI"); break;
            case 7: Console.WriteLine("VII"); break;
            case 8: Console.WriteLine("VIII"); break;
            case 9: Console.WriteLine("IX"); break;
            case 10: Console.WriteLine("X"); break;
            case 11: Console.WriteLine("XI"); break;
            case 12: Console.WriteLine("XII"); break;
            case 13: Console.WriteLine("XIII"); break;
            case 14: Console.WriteLine("XIV"); break;
            case 15: Console.WriteLine("XV"); break;
            case 16: Console.WriteLine("XVI"); break;
            case 17: Console.WriteLine("XVII"); break;
            case 18: Console.WriteLine("XVIII"); break;
            case 19: Console.WriteLine("XIX"); break;
            case 20: Console.WriteLine("XX"); break;
            case 0:
                Console.WriteLine("Rzymskie nie znali zera!");
                break;
            default:
                Console.WriteLine("Nie obsługuję liczb spoza zakresu od 1 do 20!");
                break;
        }
    }
    
    public static void Zadanie8()
    {
        char hex = 'B';
        int value;


        if (hex >= '0' && hex <= '9')
        {
            value = hex = '0';
        }
        else if (hex >= 'A' && hex <= 'F')
        {
            value = hex - 'A' + 10;
        }
        else if (hex >= 'a' && hex <= 'f')
        {
            value = hex - 'a' + 10;
        }
        else
        {
            Console.WriteLine("To nie jest cyfra szenastkowa");
            return;
        }

        Console.WriteLine($"Wartość całkowita: {value}");
    } 
}