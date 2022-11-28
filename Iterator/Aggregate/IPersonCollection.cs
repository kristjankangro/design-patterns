using Iterator.Iterator;

namespace Iterator.Aggregate;

public interface IPersonCollection
{
    IPersonIterator CreateIterator();
}