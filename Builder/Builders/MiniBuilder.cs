namespace BuilderPattern;

public class MiniBuilder : CarBuilder
{
    public MiniBuilder() : base("mini")
    {
    }

    public override void BuildEngine()
    {
        Car.AddPart("Engine for mini");
    }

    public override void BuildFrame()
    {
        Car.AddPart("frame for mini");
    }
}