using AbstractFactory;
using AbstractFactory.Client;
using AbstractFactory.ConcreteFactories;

Console.Title = "Abstract Factory";

var cartForBelgium = new ShoppingCart(new BeCartPurchaseFactory());
cartForBelgium.CalculateCosts();

var cartForFrance = new ShoppingCart(new FrCartPurchaseFactory());
cartForFrance.CalculateCosts();
