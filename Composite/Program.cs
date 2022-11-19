using Composite.AbstractBaseComponent.Leaf;
using Directory = Composite.AbstractBaseComponent.Leaf.Directory;
using File = Composite.AbstractBaseComponent.Leaf.File;

Console.Title = "Composite";

var rootDir = new Directory("root", 0);
var rootFile1 = new File("root file 1", 45);
var level1Dir1 = new Directory("level1Dir1", 5);
var level1Dir2 = new Directory("level1Dir2", 5);

rootDir.Add(rootFile1);
rootDir.Add(level1Dir1);
rootDir.Add(level1Dir2);

var level2File1 = new File("level2File1", 65);
var level2File2 = new File("level2File2", 100);

level1Dir2.Add(level2File1);
level1Dir2.Add(level2File2);

Console.WriteLine($"{level1Dir1.Name} level1Dir1 size: {level1Dir1.GetSize()}");
Console.WriteLine($"level1Dir2 size: {level1Dir2.GetSize()}");
Console.WriteLine($"root size: {rootDir.GetSize()}");