namespace Composite.AbstractBaseComponent.Leaf;

public class Directory : FileSystemItem
{
    private long _size;
    private List<FileSystemItem> _fileSystemItems { get; set; } = new List<FileSystemItem>();

    public Directory(string name, long size) : base(name)
    {
        _size = size;
    }

    public void Add(FileSystemItem item)
    {
        _fileSystemItems.Add(item);
    }

    public void Remove(FileSystemItem item)
    {
        _fileSystemItems.Remove(item);
    }
    
    public override long GetSize()
    {
        var treeSize = _size;
        foreach (var item in _fileSystemItems)
        {
            treeSize += item.GetSize();
        }

        return treeSize;
    }
}