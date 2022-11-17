using Builder.Director;
using BuilderPattern;

Console.Title = "Builder";

var g = new Garage();

var mb = new MiniBuilder(); 
var bb = new BMWBuilder(); 

g.Construct(mb);
Console.WriteLine(mb.Car.ToString());

g.Construct(bb);
Console.WriteLine(bb.Car.ToString());