namespace Lab10
{
    public interface IBox<T>
    {
        T? Content { get; set; }
        bool isEmpty()
        {
            return Content != null;
        }
    }
}