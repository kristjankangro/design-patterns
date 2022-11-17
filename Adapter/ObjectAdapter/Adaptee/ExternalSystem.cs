using Adapter.ObjectAdapter.Models;

namespace Adapter.ObjectAdapter.Adaptee;

public class ExternalSystem
{
    public CityFromExternal GetCity()
    {
        return new CityFromExternal("Antwerpen", "t Stat", 500000);
    }
}