namespace Lab06.Task04;
public class Weight
{
    private static string[] _units = ["g","dag","kg", "t"];
    private double _weight;
    private string _unit;

    private Weight(double weight, string unit)
    {
        _unit = unit;
        _weight = weight;
    }

    public static Weight ofKg(double value)
    {
        return new Weight(value, _units[2]);
    }

    public static Weight ofGram(double value)
    {
        return new Weight(value, _units[0]);
    }

    public static Weight ofTon(double value)
    {
        return new Weight(value, _units[3]);
    }

    public static Weight ofDag(double value)
    {
        return new Weight(value, _units[1]);
    }

    public static Weight OneKg = new Weight(1, _units[2]);

    public void Print()
    {
        Console.WriteLine($"{_weight} {_unit}");
    }

}