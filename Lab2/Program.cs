using System;

namespace Lab2
{
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
        }

        static void Zadanie1()
        {
            int number = 45;
            int cyfraSetek = number / 100;
            int cyfraDziesiatek = (number / 10) % 10;
            int cyfraJednosci = number % 10;

            Console.WriteLine($"Cyfra setek: {cyfraSetek}");
            Console.WriteLine($"Cyfra dziesiątek: {cyfraDziesiatek}");
            Console.WriteLine($"Cyfra jedności: {cyfraJednosci}");
        }

        static void Zadanie2()
        {
            double degree = 45;
            double sinValue;

            sinValue = Math.Sin(degree * (Math.PI / 100));

            Console.WriteLine($"Sinus kąta {degree}° wynosi: {sinValue}");
        }

        static void Zadanie3()
        {
            double area = 100;
            double radius;

            if (area < 0)
                radius = 0;
            else
                radius = Math.Sqrt(area / Math.PI);

            Console.WriteLine($"Mromień koła o polu {area} wynosi: {radius}");
        }

        static void Zadanie4()
        {
            double x = 0.45;
            double a = 1.5;
            double b = 3.2;
            double c = 4;
            double y;


            y = a * Math.Pow(x, 2) + b * x + c;

            Console.WriteLine($"dla x = {x}, wartość równiania kwadratowego wynosi: {y}");
        }

        static void Zadanie5()
        {
            int a = 9;
            int b = 6;
            int c = 2;
            int max;
            int min;

            max = Math.Max(a, Math.Max(b, c));
            min = Math.Min(a, Math.Min(b, c));

            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
        }
        
        static void Zadanie6()
        {
            double time = 1234.45;

            int hours;
            int minutes;
            int seconds;

            hours = (int)(time / 60);

            minutes = (int)(time % 60);

            seconds = (int)((time - Math.Truncate(time)) * 60);

            Console.WriteLine($"{hours:D2} : {minutes}:{seconds:D2}");
        }
    }
}