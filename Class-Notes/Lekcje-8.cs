using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks.Dataflow;

namespace Lekcje8
{
    public interface IFly
    {
        void TakeOff();
        void Fly(int distance);
        void Land();
    }

    public class Duck : IFly
    {
        public void TakeOff()
        {
            Console.WriteLine("Duck: I am taking off");
        }

        public void Fly(int distance)
        {
            Console.WriteLine($"Duck: I am flying for {distance} meters");
        }

        public void Land()
        {
            Console.WriteLine("Duck: I am landing");
        }
    }

    public class Airplane : IFly
    {
        public int FuelLevel { get; set; }

        private bool isTakenOff = false;

        public void TakeOff()
        {
            if (FuelLevel > 5)
            {
                isTakenOff = true;
                Console.WriteLine("Samolot wystartował");
            }
            else
            {
                Console.WriteLine("Insufficient fuel to take off");
            }
        }

        public void Fly(int distance)
        {
            if (!isTakenOff)
            {
                Console.WriteLine("Samolot nie może lecieć, bo nie wystartował");
                return;
            }

            Console.WriteLine($"Samolot leci na dystansie {distance} km");
        }

        public void Land()
        {
            if (!isTakenOff)
            {
                Console.WriteLine("Nie ląduję, bo nie wystartowałem");
                return;
            }

            Console.WriteLine("Samolot ląduje");
            isTakenOff = false; 
        }
    }

// the different pairs
    public class Pair1
    {
        public int A { get; set; }
        public string B { get; set; }   
    }
    public class Pair2
    {
        public string A { get; set; }
        public string B { get; set; }
    }
    public class Pair<T, V>
    {
        public T A { get; set; }
        public V B { get; set; }
    }
    public class Person
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    //Main Program
    class Program
    {
        static void Main(string[] args)
        {
            FlyDemo(new Duck());
            FlyDemo(new Airplane() { FuelLevel = 10 });
        }

        public static void FlyDemo(IFly fly)
        {
            fly.TakeOff();
            fly.Fly(100);
            fly.Land();
            Console.WriteLine("-----------------------");
        }

        public static void PairDemo(IFly fly)
        {
            Pair<int, string> pair = new Pair<int, string>();
            pair.A = 5;
            pair.B = "Hello";
        }

        public static void ICollectionDemo()
        {
            ICollection<string> collection = new List<string>();
            collection.Add("Adam");
            collection.Add("Jack");
            collection.Add("Mary");

            if (collection.Contains("Adam"))
            {
                System.Console.WriteLine("in the collection of adam");
            }
            else
            {
                System.Console.WriteLine("there is no collection of adam");
            }

            System.Console.WriteLine($"the ammount f people int eh collection: {collection.Count}");
        }

        public static void CollectionTask()
        {
            Random random = new Random();
            ICollection<int> collection = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                collection.Add(Random.Shared.Next(1, 10));
            }
            if (collection.Contains(5))
            {
                Console.WriteLine("is in the collection of 5");
            }
            else
            {
                Console.WriteLine("is not in the collection of 5");
            }

            Console.WriteLine($"Liczba elementów w kolekcji: {fcollection.Count}");
            bool isRemoved = collection.Remove(5);
            if (isRemoved)
            {
                System.Console.WriteLine("5 was removed");
            }
            foreach (var item:int in collection) 
            {
                System.Console.WriteLine(item);
            }
        }
    }
    
    public static void ListDemo()
        {
            IList<string> list = new List<string>();
            list.Add("Adam");
            list.Add("Jack");
            list.Add("Mary");
            System.Console.WriteLine(string.Join(", ", list));
            list.Insert(index: 0, "Eva");
            System.Console.WriteLine(string.Join(", ", list));
            int jackIndex = list.IndexOf("Jack");
            if (jackIndex != -1)
            {
                list.Insert(jackIndex + 1, "Bogdam");
            }
            System.Console.WriteLine(string.Join(", ", list));
            //dodaj bogdaan za jack
        }


        //need to ask hubert for code for this module 
        public static void ListTask()
        {

        }


        public static void SetDemo()
        {
            ISet<string> set = new HashSet<string>();
            set.Add("Adam");
            set.Add("Jack");
            set.Add("Mary");
            set.Add("Adam");
            System.Console.WriteLine(string.Join(", ", set));
            System.Console.WriteLine(set.Contains("Adam"));
        }

        public static void SetTask()
        {
            List<int> ints = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                ints.Add(Random.Shared.Next(1, 1000));
            }
            //wyswietl liczby z listy ints, ale bez powtórzeń
            //utwóż zbiór liczb
            //dodaj do niego wszystkie Liczby z listy
            //wyswietl zbior
            ISet<int> uniqueNumbers = new HashSet<int>();
            foreach (var number in ints)
            {
                uniqueNumbers.Add(number);
            }
            System.Console.WriteLine("zbiór liczb bez powtarzan");
            //System.Console.WriteLine(string.Join(", ", uniqueNumbers));
        }


        public static void DictionaryDemo()
        {
            string str = "Pada śnieg od rada Pada snieg snieg snieg snieg";
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] tokens = str.Split(" ");
            //System.Console.WriteLine(string.Join(",", tokens));
            for (int i = 0; i < tokens.Length; i++)
            {
                tokens[i] = tokens[i].ToLower().Trim();
            }
            System.Console.WriteLine(string.Join(",", tokens));
            foreach (var word:string in tokens) {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word, 1);
                }

                foreach (var pair in dictionary)
                {
                    System.Console.WriteLine($"Slowo: {pair.Key} wystepuje {pair.Value} razy");
                }
            }
        }
        public static void DictionaryExample()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            //Klucz to imię osoby
            // wartość to number telefonu
            phoneBook.Add("Adam", "111 111 111");
            phoneBook.Add("Ewa", "222 222 222");
            phoneBook.Add("Alivja", "111 333 111");


            string name = Console.ReadLine();
            if (phoneBook.ContainsKey(name))
            {
                System.Console.WriteLine($"numer telefonu {phoneBook[name]} do {name}");
            }
            else
            {
                System.Console.WriteLine("brak oosoby");
            }

            phoneBook.Remove(key: "Alicja");
            System.Console.WriteLine("list of Everyone in the book");
            foreach (var item:string in phoneBook.Keys) {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("list of everyone in the book");
            foreach (var item:string in phoneBook.Values) {
                System.Console.WriteLine(item);
            }
        }
        
        public static void DictionaryPerson()
        {
            // zdeklaruj słownik people z kluczem string (imię) i wartością klasy Person
            // dodaj słownika trzy osoby

            Dictionary<string, Person> people = new Dictionaary<string, Person>();
            people.Add("Adam", new Person
            {
                PhoneNumber = "111 222 333",
                Email = "Adma@mail.com",
                DateOfBirth = new DateTime?(2000, 5, 12)
            });
            people.Add("Ewa", new Person
            {
                PhoneNumber = "111 222 333",
                Email = "Ewa@mail.com",
                DateOfBirth = new DateTime?(2002, 2, 20)
            });
            people.Add("Ola", new Person
            {
                PhoneNumber = "111 222 333",
                Email = "Ola@mail.com",
                DateOfBirth = new DateTime?(2003, 11, 23)
            });

            System.Console.WriteLine("Imiona w słowniku:");
            foreach (var name in people.Keys)
            {
                System.Console.WriteLine(name);
            }
            System.Console.WriteLine("");
        }
}
