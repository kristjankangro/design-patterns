using Adapter.ObjectAdapter.Adaptee;
using Adapter.ObjectAdapter.Models;

namespace Adapter.ObjectAdapter.Target;

public class CityAdapter : ICityAdapter
{
    public ExternalSystem ExternalSystem { get; private set; } = new();
    
    public City GetCity()
    {
        var city = ExternalSystem.GetCity();
        return new City($"{city.Name} - {city.NickName}", city.Inhabitants);
    }
}