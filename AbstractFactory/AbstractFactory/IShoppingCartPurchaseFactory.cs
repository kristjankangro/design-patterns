using AbstractFactory.AbstractProducts;

namespace AbstractFactory.AbstractFactory;

public interface IShoppingCartPurchaseFactory
{
    IDiscountService CreateDiscountService();
    IShippingCostService CreateShippingCostService();
}
