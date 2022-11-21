using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProducts;
using AbstractFactory.ConcreteProducts;

namespace AbstractFactory.ConcreteFactories;

public class FrCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new FrDiscountService();
    }

    public IShippingCostService CreateShippingCostService()
    {
        return new FrShippingCostService();
    }
}