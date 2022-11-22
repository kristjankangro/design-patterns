namespace Flyweight;

public class CharA : IChar
{
    private readonly char _actualChar = 'a';
    private string _fontFamily = string.Empty;
    private int _fontSize;
    
    public void Draw(string fontFamily, int fontSize)
    {
        _fontFamily = fontFamily;
        _fontSize = fontSize;
        Console.WriteLine($"Drawing {_actualChar} with font {_fontFamily} in size {_fontSize}");        
    }
}