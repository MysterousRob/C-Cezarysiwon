namespace Lekcje10;

using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Lek1();
    }

    public static void Lek1()
    {
        bool a = true;
        int b = 1_000_000_000;
        char c = '1';
        float d = 0.00001e40f;
        decimal e = 1.0m;
        double f = 0.000001e100;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
    }

    public static void Fun()
    {
        int size = int.Parse(Console.ReadLine());
        double[] input = new double[size];
        for (int i = 0; i < size; i++)
        {
            input[i] = double.Parse(Console.ReadLine());
        }
        Fun(input);
    }

    public static void Fun(double[] input)
    {
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] < input[i - 1])
            {
                Console.WriteLine(input[i]);
            }
        }
    }

    public static void TobeDone()
    {
        class Task
    {
        public bool IsDone { set; get; }
        public DateTime Deadline { get; set; }
        public string Title { get; set; }

            public Task()
            {
                Deadline = new DateTime(DateTime.Now.Year + 1, 1, 1);
                IsDone = DateTime.Now.Day % 2 == 0;
                Title = "Change task title!";
            }
        }
    }   
    
    public static void Tanks()
    {
        class Tank
        {
            private int _level = 0;
            private int _maxLevel = 100;
            public int Level
            {
                get { return _level; }
                set
                {
                    _level += value;
                    if (_level > _maxLevel) _level = _maxLevel;
                    if (_level < 0) _level = 0;
                }
            }
            public bool IsFull
            {
                get { return _level >= _maxLevel; }
            }
        }
    }
    
    
    public abstract class Product
    {
        public string Name { get; set; }
        abstract public decimal Price { get; }
    }

    public class PackedProduct : Product
    {
        private decimal _shippingCost;
        private decimal _contentPrice;

        public decimal ShippingCost
        {
            get => _shippingCost;
            set
            {
                if (value < 0) throw new ArgumentException("ShippingCost cannot be negative.");
                _shippingCost = value;
            }
        }

        public decimal ContentPrice
        {
            get => _contentPrice;
            set
            {
                if (value < 0) throw new ArgumentException("ContentPrice cannot be negative.");
                _contentPrice = value;
            }
        }

        public override decimal Price => ShippingCost + ContentPrice;
    }

    public interface ICommand<T>
    {
        T Execute();
    }

    public class Addition : ICommand<decimal>
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }

        public decimal Execute()
        {
            return X + Y;
        }
    }
    

    public static List<int> Heights(string input)
    {
        string[] parts = input.Split(';');
        List<int> heights = new List<int>();

        for (int i = 0; i < parts.Length; i += 2)
        {
            int height = int.Parse(parts[i]);
            heights.Add(height);
        }
    
        heights.Sort((a, b) => b.CompareTo(a)); 
        return heights;
    }


    
}