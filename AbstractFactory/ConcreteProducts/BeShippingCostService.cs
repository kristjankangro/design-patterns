using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts;

public class BeShippingCostService : IShippingCostService
{
    public decimal ShippingCosts => 20;
}