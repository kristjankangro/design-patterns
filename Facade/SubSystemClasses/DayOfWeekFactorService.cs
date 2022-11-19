namespace Facade;

public class DayOfWeekFactorService
{
    public double CalculateFactor()
    {
        switch (DateTime.UtcNow.DayOfWeek)
        {
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                return 0.8;
            default:
                return 1.2;
        }
    }
}