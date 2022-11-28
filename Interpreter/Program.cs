using Interpreter.Context;

Console.Title = "Interpreter";

var expressions = new List<RomanExpression>
{
    new RomanMExpression(),
    new RomanXExpression(),
    new RomanIExpression()
};

var context = new RomanContext(724);
expressions.ForEach(exp => exp.Interpret(context));
Console.WriteLine($"Translating to roman {context.InitInput} => {context.Output}");