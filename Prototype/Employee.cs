using Newtonsoft.Json;

namespace Prototype.Abstract.Concrete;

public class Employee : Person
{
    public Manager Manager { get; set; }

    public Employee(string name, Manager manager)
    {
        Name = name;
        Manager = manager;
    }

    public override string Name { get; set; }

    public override Person Clone(bool deepClone = false)
    {
        if (!deepClone) return (Person) MemberwiseClone();

        var objectJson = JsonConvert.SerializeObject(this);
        return JsonConvert.DeserializeObject<Employee>(objectJson);
    }
}