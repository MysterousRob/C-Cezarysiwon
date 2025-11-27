namespace Lab10
{
    public class ColorBoxForDouble : IBox<double>
    {
        private double _value;

        public double Content
        {
            get => _value;
            set => _value = value;
        }
    }
}
