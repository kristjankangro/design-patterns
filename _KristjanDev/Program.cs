using KristjanDev;

Console.WriteLine("Hello, World!");

var type1 = new Type1 { type1Key = "mingkey 1", type1Name = "mingi name 1" };
var type2 = new Type2 { type2Key = "mingkey 22", type2Name = "mingi name 22" };
var type3 = new Type3 { type3Key = "mingkey 333", type3Name = "mingi name 333" };

Console.WriteLine(TranslationObjectService.GetObject(type1).Key);
Console.WriteLine(TranslationObjectService.GetObject(type2).Key);
Console.WriteLine(TranslationObjectService.GetObject(type3).Key);