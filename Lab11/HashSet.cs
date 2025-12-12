<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;

namespace Lab11 
=======
namespace Lab11;

public static class UniqueStudents
>>>>>>> b2b96c330f73b591c2b931250714e164ed255c79
{
    public static class UniqueStudents
    {
<<<<<<< HEAD
        public static HashSet<string> UniqueNames(List<Student> students)
        {
            HashSet<string> set = new HashSet<string>();
=======
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
>>>>>>> b2b96c330f73b591c2b931250714e164ed255c79
    
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
}