using Bridge;

Console.Title = "Bridge";

var coup1 = new OneCoupon();
var coup2 = new TwoCoupon(); 

var mm = new MeatMenu(coup1);
Console.WriteLine($"meat menu {mm.CalculatePrice()}");

var vm = new VegMenu(coup2);
Console.WriteLine($"veg menu {vm.CalculatePrice()}");