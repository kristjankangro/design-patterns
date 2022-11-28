using Iterator.Iterator;
using Iterator.Models;

namespace Iterator.Aggregate;

public class PersonCollection : List<Person>, IPersonCollection
{
    public IPersonIterator CreateIterator()
    {
        return new PersonIterator(this);
    }
}