namespace Lab11;

using System.Collections.Generic;



public class LessonPlan
{
    private readonly SortedSet<string> topics = new();

    public void AddTopic(string topic)
    {
        topics.Add(topic);
    }

    public void RemoveTopic(string topic)
    {
        topics.Remove(topic);
    }

    public IReadOnlyCollection<string> GetTopics()
    {
        return topics;
    }
}