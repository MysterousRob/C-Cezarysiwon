namespace Lab11;
using System;


public class Student
{
    public string Name { get; set; }
    public int Points { get; set; }

    public Student(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override string ToString()
    {
        return $"{Name} ({Points} pkt)";
    }
}

public static class BubbleSort
{
    public static List<Student> Sort(List<Student> students)
    {
        for (int i = 0; i < students.Count - 1; i++)
        {
            for (int j = 0; j < students.Count - i - 1; j++)
            {
                if (students[j].Points > students[j + 1].Points)
                {
                    var temp = students[j];
                    students[j] = students[j + i];
                    students[j + 1] = temp;
                }
            }
        }
        return students;
    }
}


public static class SearchPoint
{
    public static List<int> BinarySearch(List<Student> sorted, int points)
    {
        int left = 0;
        int right = sorted.Count - 1;
        List<int> found = new List<int>();


        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (sorted[mid].Points == points)
            {
                int i = mid;
                while (i >= 0 && sorted[i].Points == points)
                {
                    found.Add(i);
                    i--;
                }
                i = mid + 1;
                while (i < sorted.Count && sorted[i].Points == points)
                {
                    found.Add(i);
                    i++;
                }
                found.Sort();
                return found;
            }
            else if (sorted[mid].Points < points)
                left = mid + 1;
            else 
                right = mid - 1;
        }
        return found;
    }
}