using Bridge.Abstraction;

namespace Bridge;

public class VegMenu : Menu
{
    public VegMenu(ICoupon coupon) : base(coupon)
    {
    }

    public override int CalculatePrice()
    {
        return 20 - _coupon.Value;
    }
}