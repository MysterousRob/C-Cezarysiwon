using System;

namespace Lab03;


class Program
{
    // == calling outside function == //
    const double hot = 25;
    const double warm = 18;
    const double chilly = 5;
    const double freezing = 0;
    static void Main(string[] args)
    {

        //Example1();
        //Example2();
        //Example3();
        //Example4();
        //Example5();
    }


    //1 czerwony 
    //2 niebieski
    //3 zielony
    public static void Example1(){
        System.Console.WriteLine("Write out the number to the color you want: (1 -- Red, 2 -- Blue, 3 -- Green)");
        int color = int.Parse(Console.ReadLine());
        bool isRed = color == 1;
        bool isBlue = color == 2;
        bool isGreen = color == 3;

        if(isRed) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello");
        }
        if(isBlue) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello");
        }
        if(isGreen) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello");
        }
    }

    public static void Example2() {
        System.Console.WriteLine("Whats the temperature?");
        double temp = double.Parse(Console.ReadLine());

        if (temp > 18) {
            System.Console.WriteLine("warm");
        }
        else {
            System.Console.WriteLine("cold");
        }
    }

    public static void Example3() {
        Console.WriteLine("write what the temp is");
        // == orriginal == //
        double temp = double.Parse(Console.ReadLine());

        //if (temp >= 18 && temp <= 25) {
        //    Console.WriteLine("warm");
        //}
        //else {
        //    if(temp < 18) {
        //        Console.WriteLine("cold");
        //    }
        //    else {
        //        Console.WriteLine("hot");
        //    }
        //}

        if(temp > 25) {
            System.Console.WriteLine("hot");
        } else if (temp > 18){
            System.Console.WriteLine("warm");
        }
        else if (temp > 5){
            System.Console.WriteLine("chilly");
        } else if (temp > 0) {
            System.Console.WriteLine("cold");
        } else {
            System.Console.WriteLine("Freezing");
        }
    }

    public static void Example4() {
        Console.WriteLine("write what the temp is");
        // == orriginal == //
        double temp = double.Parse(Console.ReadLine());
        
        // === calling inside function === //
        //const double hot = 25;
        //const double warm = 18;
        //const double chilly = 5;
        //const double freezing = 0;

        //if (temp >= 18 && temp <= 25) {
        //    Console.WriteLine("warm");
        //}
        //else {
        //    if(temp < 18) {
        //        Console.WriteLine("cold");
        //    }
        //    else {
        //        Console.WriteLine("hot");
        //    }
        //}

        if(temp > hot) {
            System.Console.WriteLine("hot");
        } if (temp > warm && temp < hot){
            System.Console.WriteLine("warm");
        } if (temp > chilly && temp < warm){
            System.Console.WriteLine("chilly");
        } if (temp > freezing && temp < chilly) {
            System.Console.WriteLine("cold");
        } if (temp < freezing) {
            System.Console.WriteLine("Freezing");
        }
    }

    public static void Example5() {
        //Console.WriteLine("Write out the number to the color you want: (1 -- Red, 2 -- Blue, 3 -- Green)");
        //int color = int.Parse(Console.ReadLine());
        
        
        System.Console.WriteLine("What is the Grade");
        int grade = int.Parse(Console.ReadLine());


        switch (grade) {
            case 1:
                System.Console.WriteLine("E");
            break;
            case 2:
                System.Console.WriteLine("D");
            break;
            case 3:
                System.Console.WriteLine("C");
            break;
            case 4:
                System.Console.WriteLine("B");
            break;
            case 5:
                System.Console.WriteLine("A");
            break;
            default: 
                System.Console.WriteLine("UNknown grade");
            break;
        }

        //switch (color) {
        //    case 1:
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Im red");
        //        break;
        //    case 2:
        //        Console.ForegroundColor = ConsoleColor.Blue;
        //        Console.WriteLine("Im Blue");
        //        break;
        //    case 3:
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("Im Green");
        //        break;
        //    default: 
        //        Console.WriteLine("Im unknown");
        //        break;
        //}
    }

}
