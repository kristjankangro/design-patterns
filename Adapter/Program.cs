using Adapter.ClassAdapter;

Console.Title = "Adapter";

//object adapter
ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();
Console.WriteLine($"{city.FullName}, {city.Inhabitants}");

