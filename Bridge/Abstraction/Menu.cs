namespace Bridge.Abstraction;

public abstract class Menu
{
    protected readonly ICoupon _coupon = null!;

    protected Menu(ICoupon coupon)
    {
        _coupon = coupon;
    }

    public abstract int CalculatePrice();
}