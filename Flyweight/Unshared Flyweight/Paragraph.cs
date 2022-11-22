namespace Flyweight.Unshared;

public class Paragraph : IChar
{
    private int _location;
    private List<IChar> _chars = new();

    public Paragraph(List<IChar> chars, int location)
    {
        _location = location;
        _chars = chars;
    }

    public void Draw(string fontFamily, int fontSize)
    {
        Console.WriteLine($"Drawing paragraph at {_location}");
        foreach (var chr in _chars)
        {
            chr.Draw(fontFamily, fontSize);
        }
    }
}