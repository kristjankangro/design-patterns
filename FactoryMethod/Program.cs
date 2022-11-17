using FactoryMethod;

Console.Title = "Factory Method";

DiscountFactory codeFactory = new CodeDiscountFactory(Guid.NewGuid());
DiscountFactory countryFactory = new CountryDiscountFactory("BE");

var discountService = codeFactory.CreateDiscountService();
Console.WriteLine($"{discountService} discount is {discountService.DiscountPercentage}");

discountService = countryFactory.CreateDiscountService();
Console.WriteLine($"{discountService} discount is {discountService.DiscountPercentage}");