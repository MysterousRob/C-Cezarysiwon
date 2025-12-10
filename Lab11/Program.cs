namespace Lab11;

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student("Adam", 55),
            new Student("Ola", 72),
            new Student("Bartek", 72),
            new Student("Karol", 31),
            new Student("Zosia", 90),
        };

        Console.WriteLine("Original list:");
        students.ForEach(s => Console.WriteLine(s));

        var sorted = BubbleSort.Sort(students);

        Console.WriteLine("\nSorted list (by points):");
        sorted.ForEach(s => Console.WriteLine(s));

        Console.Write("\nSearch points: ");
        int searchPoints = int.Parse(Console.ReadLine());

        var found = SearchPoint.BinarySearch(sorted, searchPoints);

        if (found.Count == 0)
            Console.WriteLine("No student with that score.");
        else
        {
            Console.WriteLine("Found indexes:");
            found.ForEach(i => Console.WriteLine($"index {i}: {sorted[i]}"));
        }

        var grouped = StudentDatabase.GroupByFirstLetter(students);

        Console.WriteLine("\nGrouping by first letter:");
        foreach (var g in grouped)
        {
            Console.WriteLine($"\n{g.Key}:");
            foreach (var s in g.Value)
                Console.WriteLine("  " + s);
        }

        var uniqueNames = UniqueStudents.UniqueNames(students);

        Console.WriteLine("\nUnique student names:");
        foreach (var name in uniqueNames)
            Console.WriteLine(name);

        LessonPlan lp = new LessonPlan();
        lp.AddTopic("Collections");
        lp.AddTopic("HashSet");
        lp.AddTopic("Dictionary");
        lp.AddTopic("Sorting");
        lp.RemoveTopic("HashSet");

        Console.WriteLine("\nLesson plan:");
        lp.Print();
    }
}