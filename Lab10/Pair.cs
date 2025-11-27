namespace Lab10
{
    public class Pair<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public void Swap()
        {
            T temp = First;
            First  = Second;
            Second = temp;
        }
    }
}