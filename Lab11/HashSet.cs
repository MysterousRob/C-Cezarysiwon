namespace Lab11;

public static class UniqueStudents
{
    public static HashSet<string> UniqueNames(List<Student> students)
    {
        HashSet<string> set = new HashSet<string>();

        foreach (var s in students)
            set.Add(s.Name);

        return set;
    }
}

public static class SetOperations
{
    public static HashSet<string> Union(HashSet<string> a, HashSet<string> b)
        => new HashSet<string>(a.Union(b));

    public static HashSet<string> Intersect(HashSet<string> a, HashSet<string> b) 
        => new HashSet<string>(a.Intersect(b));
    
    public static HashSet<string> Difference(HashSet<string> a, HashSet<string> b)
        => new HashSet<string>(a.Except(b)); 
}