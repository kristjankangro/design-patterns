namespace BuilderPattern;

public class BMWBuilder : CarBuilder
{
    public BMWBuilder() : base("BMW")
    {
    }

    public override void BuildEngine()
    {
        Car.AddPart("Engine for bmw");
    }

    public override void BuildFrame()
    {
        Car.AddPart("frame for bmw");
    }
}