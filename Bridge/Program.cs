using Bridge;

Console.Title = "Bridge";

var mm = new MeatMenu(new OneCoupon());
Console.WriteLine($"meat menu {mm.CalculatePrice()}");

var vm = new VegMenu(new TwoCoupon());
Console.WriteLine($"veg menu {vm.CalculatePrice()}");