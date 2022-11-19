namespace Composite.AbstractBaseComponent;

public abstract class FileSystemItem
{
    public string Name { get; set; }

    protected FileSystemItem(string name)
    {
        Name = name;
    }

    public abstract long GetSize();
}