namespace Interpreter.Context;

public class RomanContext
{
    internal int Input { get; set; }
    public int InitInput { get; set; }
    public string Output { get; set; }= string.Empty;

    public RomanContext(int input)
    {
        Input = input;
        InitInput = input;
    }
}