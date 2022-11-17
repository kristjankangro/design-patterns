namespace FactoryMethod;

public class CountryDiscountService : DiscountService
{
    private readonly string _countryCode;

    public CountryDiscountService(string countryCode)
    {
        _countryCode = countryCode;
    }

    public override int DiscountPercentage
    {
        get
        {
            return _countryCode switch
            {
                "BE" => 20,
                _ => 10
            };
        }
    }
    
}