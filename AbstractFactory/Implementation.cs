namespace AbstractFactory
{
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();
        IShippingCostsService CreateShippingCostsService();
    }

    public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService() => new BelgiumDiscountService();
        public IShippingCostsService CreateShippingCostsService() => new BelgiumShippingCostsService();
    }

    public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService() => new FranceDiscountService();
        public IShippingCostsService CreateShippingCostsService() => new FranceShippingCostsService();
    }

    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostsService _shippingCostsService;
        private readonly int _totalOrderCost;

        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shippingCostsService = factory.CreateShippingCostsService();
            _totalOrderCost = 200;
        }

        public void CalculateCosts()
        {
            var cost = _totalOrderCost;
            var discount = _totalOrderCost * _discountService.DiscountPercentage / 100;
            var shipping = _shippingCostsService.ShippingCosts;
            Console.WriteLine(cost - discount + shipping);
        }
    }

    public interface IDiscountService
    {
        int DiscountPercentage { get; }
    }

    public class BelgiumDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }

    public class FranceDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;
    }

    public interface IShippingCostsService
    {
        decimal ShippingCosts { get; }
    }

    public class BelgiumShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 20;
    }

    public class FranceShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 25;
    }
}