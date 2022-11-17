namespace FactoryMethod;

public class CountryDiscountFactory : DiscountFactory
{
    private readonly string _countryCode;

    public CountryDiscountFactory(string countryCode)
    {
        _countryCode = countryCode;
    }

    public override DiscountService CreateDiscountService()
    {
       return new CountryDiscountService(_countryCode);
    }
}