namespace Lab10
{
    public interface IMixOut<out T>
    {
        T[] Items { get; }
    }

    public interface IMixIn<in T>
    {
        void Remove(int index);
    }

    public class Mix<T> : IMixOut<T>, IMixIn<T>
    {
        private T[] _items = new T[1];

        public Mix() { }

        public Mix(T[] items)
        {
            _items = items;
        }

        public T[] Items => _items;

        public void Remove(int index)
        {
            if (_items.Length == 0) return;

            T[] result = new T[_items.Length - 1];

            int pos = 0;
            for (int i = 0; i < _items.Length; i++)
            {
                if (i != index)
                {
                    result[pos++] = _items[i];
                }
            }

            _items = result;
        }
    }
}
