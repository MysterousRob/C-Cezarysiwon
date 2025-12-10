public class LessonPlan
{
    private ICollection<string> topics = new SortedSet<string>();

    public void AddTopic(string topic)
    {
        topics.Add(topic);
    }

    public void RemoveTopic(string topic)
    {
        topics.Remove(topic);
    }

    public void Print()
    {
        System.Console.WriteLine("Lesson topics:");
        foreach (var t in topics) 
            System.Console.WriteLine("-" + t);
    }
}