using AbstractFactory;

Console.Title = "Abstract Factory";

var belgiumCart = new ShoppingCart(new BelgiumShoppingCartPurchaseFactory());
belgiumCart.CalculateCosts();

var franceCart = new ShoppingCart(new FranceShoppingCartPurchaseFactory());
franceCart.CalculateCosts();