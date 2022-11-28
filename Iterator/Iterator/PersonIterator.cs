using Iterator.Aggregate;
using Iterator.Models;

namespace Iterator.Iterator;

public class PersonIterator : IPersonIterator
{
    private PersonCollection _collection;
    private int _current = 0;

    public PersonIterator(PersonCollection collection)
    {
        _collection = collection;
    }

    public Person First()
    {
        _current = 0;
        return _collection.OrderBy(p => p.Name).ToList()[_current];
    }

    public Person Next()
    {
        _current++;
        return !isDone ? _collection.OrderBy(p => p.Name).ToList()[_current] : null;
    }

    public Person CurrentItem => _collection.OrderBy(p => p.Name).ToList()[_current];
    public bool isDone => _current >= _collection.Count;
    
}