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
}