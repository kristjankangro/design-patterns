using BuilderPattern;

namespace Builder.Director;

public class Garage
{
    private CarBuilder? _builder;

    public Garage()
    {
    }

    public void Construct(CarBuilder builder)
    {
        _builder = builder;
        _builder.BuildEngine();
        _builder.BuildFrame();
    }
}