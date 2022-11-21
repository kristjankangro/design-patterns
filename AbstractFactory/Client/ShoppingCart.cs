using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.Client;

public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostService _shippingCostService;
    private int _orderCosts;

    public ShoppingCart(IShoppingCartPurchaseFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostService = factory.CreateShippingCostService();
        _orderCosts = 200;
    }

    public void CalculateCosts()
    {
        Console.WriteLine($"Total costs = {_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostService.ShippingCosts}");
    }
}