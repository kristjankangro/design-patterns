namespace Adapter.ClassAdapter;

public class CityAdapter : ExternalSystem, ICityAdapter
{
    public ExternalSystem ExternalSystem { get; private set; } = new();
    
    public City GetCity()
    {
        var city = base.GetCity();
        return new City($"{city.Name} - {city.NickName}", city.Inhabitants);
    }
}