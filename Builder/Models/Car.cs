using System.Text;

namespace BuilderPattern;

public class Car
{
    private readonly List<string> _parts = new();
    private readonly string _carType;

    public Car(string carType)
    {
        _carType = carType;
    }

    public void AddPart(string part)
    {
        _parts.Add(part);
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"car of type {_carType}");
        foreach (var part in _parts)
        {
            stringBuilder.Append($"has part {part}");
        }

        return stringBuilder.ToString();
    }
}