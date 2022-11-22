namespace Flyweight;

public class CharB : IChar
{
    private readonly char _actualChar = 'b';
    private string _fontFamily = string.Empty;
    private int _fontSize;
    
    public void Draw(string fontFamily, int fontSize)
    {
        _fontFamily = fontFamily;
        _fontSize = fontSize;
        Console.WriteLine($"Drawing {_actualChar} with font {_fontFamily} in size {_fontSize}");        
    }
}