namespace Bridge;

//abstraction
public abstract class Menu
{
    protected readonly ICoupon _coupon = null!;

    protected Menu(ICoupon coupon)
    {
        _coupon = coupon;
    }

    public abstract int CalculatePrice();
}

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

public class MeatMenu : Menu
{
    public MeatMenu(ICoupon coupon) : base(coupon)
    {
    }

    public override int CalculatePrice()
    {
        return 30 - _coupon.Value;
    }
}

public interface ICoupon
{
    int Value { get; }
}

public class OneCoupon : ICoupon
{
    public int Value => 1;
}

public class TwoCoupon : ICoupon
{
    public int Value => 2;
}