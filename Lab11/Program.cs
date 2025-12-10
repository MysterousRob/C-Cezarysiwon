


internal class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student("Adam", 55),
            new Student("Ola", 70),
            new Student("Bartek", 72),
            new Student("Karol", 31),
            new Student("Zosia", 90),
        };

        System.Console.WriteLine("Original List");
        students.ForEach(s => System.Console.WriteLine(s));

        var sorted = BubbleSort.Sort(students);

        System.Console.WriteLine("\nSorted list (by points):");
        sorted.ForEach(s => System.Console.WriteLine(s));

        Console.Write("\nSearch points: ");
        int searchPoints = int.parse(Console.ReadLine());

        var found = searchPoint.BinarySearch(sorted, searchPoints); 

        if (found.Count  == 0)
            System.Console.WriteLine("No student with that score.");
        else
        {
            System.Console.WriteLine("Found indexes:");
            found.ForEach(i => System.Console.WriteLine($"index {i}: {sorted[i]}"));
        }

        var grouped = StudentDatabase.GroupByfirstLetter(students);

        System.Console.WriteLine("\ngrouping by first letter:");
        foreach (var g in grouped)
        {
            System.Console.WriteLine($"\n{g.Key}:");
            foreach (var s in g.Value)
                System.Console.WriteLine(" " + s);
        }

        var uniqueNames = UniqueStudents.UniqueNames(students);

        System.Console.WriteLine("\nUnique student names:");
        foreach (var name in uniqueNames) 
            System.Console.WriteLine(name);

            LessonPlan lp = new LessonPlan();
            lp.AddTopic("Collections");
            lp.AddTopic("HashSet");
            lp.AddTopic("Dictionary");
            lp.AddTopic("Sorting");
            lp.AddTopic("Hashset");

            System.Console.WriteLine("\nLesson plan:");
            lp.Print();
    }
}