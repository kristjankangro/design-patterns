using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts;

public class FrShippingCostService : IShippingCostService
{
    public decimal ShippingCosts => 25;
}