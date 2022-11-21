using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProducts;
using AbstractFactory.ConcreteProducts;

namespace AbstractFactory.ConcreteFactories;

public class BeCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new BeDiscountService();
    }

    public IShippingCostService CreateShippingCostService()
    {
        return new BeShippingCostService();
    }
}