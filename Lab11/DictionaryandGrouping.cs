namespace Lab11;

public static class StudentDatabase
{
    public static Dictionary<char, List<Student>> GroupByFirstLetter(List<Student> students)
    {
        Dictionary<char, List<Student>> result = new Dictionary<char, List<Student>>();

        foreach (var s in students)
        {
            char first = char.ToUpper(s.Name[0]);

            if (!result.ContainsKey(first))
                result[first] = new List<Student>();

            result[first].Add(s);
        }
        return result;
    }
}