using Iterator.Models;

namespace Iterator.Iterator;

public interface IPersonIterator
{
    Person First();
    Person Next();
    Person CurrentItem { get; }
    bool isDone { get; }

}