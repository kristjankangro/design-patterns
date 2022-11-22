using Flyweight.Unshared;

namespace Flyweight;

public class CharFactory
{
    private readonly Dictionary<char, IChar> _chars = new();

    public IChar? GetChar(char charId)
    {
        if (_chars.ContainsKey(charId))
        {
            Console.WriteLine("char reuse");
            return _chars[charId];
        }
        
        Console.WriteLine("Char construction...");
        switch (charId)
        {
            case 'a':
                _chars[charId] = new CharA();
                return _chars[charId];
            case 'b':
                _chars[charId] = new CharB();
                return _chars[charId];
        }

        return null;
    }

    public IChar CreateParagraph(List<IChar> chars, int location)
    {
        return new Paragraph(chars, location);
    }
}