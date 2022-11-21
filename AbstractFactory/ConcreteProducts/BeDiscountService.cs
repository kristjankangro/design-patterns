using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts;

public class BeDiscountService : IDiscountService
{
    public int DiscountPercentage => 20;
}