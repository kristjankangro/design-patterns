using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace Prototype.Abstract.Concrete;

public class Manager : Person
{
    public Manager(string name)
    {
        Name = name;
    }

    public override string Name { get; set; }

    public override Person Clone(bool deepClone = false)
    {
        if (!deepClone) return (Person) MemberwiseClone();

        var objectJson = JsonConvert.SerializeObject(this);
        return JsonConvert.DeserializeObject<Employee>(objectJson);
    }
}