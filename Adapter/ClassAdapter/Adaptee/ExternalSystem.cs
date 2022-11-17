namespace Adapter.ClassAdapter;
    
public class ExternalSystem
{
    public CityFromExternal GetCity()
    {
        return new CityFromExternal("Antwerpen", "t Stat", 500000);
    }
}