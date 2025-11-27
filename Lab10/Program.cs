namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GENERIC PAIR DEMO ===");
            PairDemo();

            Console.WriteLine("\n=== GENERIC INTERFACE + BOX DEMO ===");
            BoxDemo();

            Console.WriteLine("\n=== GENERIC METHOD DEMO ===");
            GenericMethodDemo();

            Console.WriteLine("\n=== PIZZA + GENERIC INHERITANCE ===");
            PizzaDemo();

            Console.WriteLine("\n=== GENERIC CONSTRAINT DEMO ===");
            PizzaBoxDemo();

            Console.WriteLine("\n=== COVARIANCE & CONTRAVARIANCE DEMO ===");
            VarianceDemo();
        }

        public static void PairDemo()
        {
            Pair<int> numbers = new Pair<int>() { First = 10, Second = 99 };
            Console.WriteLine($"Before swap: {numbers.First}, {numbers.Second}");
            numbers.Swap();
            Console.WriteLine($"After swap:  {numbers.First}, {numbers.Second}");

            Pair<string> names = new Pair<string>() { First = "Adam", Second = "Ewa" };
            Console.WriteLine($"Before swap: {names.First}, {names.Second}");
            names.Swap();
            Console.WriteLine($"After swap:  {names.First}, {names.Second}");
        }

        public static void BoxDemo()
        {
            IBox<int> intBox = new MetalBox<int>() { Content = 123 };
            Console.WriteLine($"Box content: {intBox.Content}");
            Console.WriteLine($"Is empty?   {intBox.isEmpty()}");

            IBox<string> strBox = new MetalBox<string>() { Content = "Hello" };
            Console.WriteLine($"Box content: {strBox.Content}");
        }

        public static void GenericMethodDemo()
        {
            IBox<int> a = new MetalBox<int>() { Content = 10 };
            IBox<int> b = new MetalBox<int>() { Content = 99 };

            Console.WriteLine($"Before swap: A={a.Content}, B={b.Content}");
            Swap(a, b);
            Console.WriteLine($"After swap:  A={a.Content}, B={b.Content}");
        }

        public static void Swap<T>(IBox<T> a, IBox<T> b)
        {
            T? temp = a.Content;
            a.Content = b.Content;
            b.Content = temp;
        }

        public static void PizzaDemo()
        {
            IBox<Pizza> pizzaBox = new MetalBox<Pizza>()
            {
                Content = new PepperoniPizza()
            };

            Console.WriteLine("Ingredients:");
            Console.WriteLine(string.Join(", ", pizzaBox.Content.Ingredients()));
        }

        public static void PizzaBoxDemo()
        {
            PizzaBox<PepperoniPizza> p = new PizzaBox<PepperoniPizza>();
            p.Content = new PepperoniPizza();

            Console.WriteLine("PizzaBox content:");
            Console.WriteLine(string.Join(", ", p.Content.Ingredients()));

        }

        public static void VarianceDemo()
        {
            IMixIn<Pizza> mixPizza = new Mix<Pizza>();
            IMixIn<PepperoniPizza> mixPepperoni = new Mix<PepperoniPizza>();

            mixPepperoni = mixPizza;

            RemoveItem(0, mixPizza);
            RemoveItem(0, mixPepperoni);

            Console.WriteLine("RemoveItem executed successfully.");
        }

        public static void RemoveItem(int index, IMixIn<PepperoniPizza> arg)
        {
            arg.Remove(index);
        }
    }
}
