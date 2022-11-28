using Iterator.Aggregate;
using Iterator.Iterator;
using Iterator.Models;

Console.Title = "Iterator";

var persons = new PersonCollection();
persons.Add(new Person("Mart", "EE"));
persons.Add(new Person("Bob", "UK"));
persons.Add(new Person("Jessica", "US"));
persons.Add(new Person("Pekka", "FI"));

var iterator = new PersonIterator(persons);

for (var person = iterator.First(); !iterator.isDone; person = iterator.Next())
{
    Console.WriteLine($"Person name {person?.Name}");
}