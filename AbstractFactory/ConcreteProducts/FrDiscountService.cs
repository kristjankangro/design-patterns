using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts;

public class FrDiscountService: IDiscountService
{
    public int DiscountPercentage => 10;
}