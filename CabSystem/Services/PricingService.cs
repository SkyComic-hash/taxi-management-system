public class PricingService
{
    public decimal CalculatePredictedCost(decimal distanceKm, decimal durationMinutes, decimal discountRate)
    {
        const decimal baseRatePerKm = 15.0m;
        const decimal baseRatePerMinute = 2.0m;
        
        decimal cost = (distanceKm * baseRatePerKm) + (durationMinutes * baseRatePerMinute);
        return cost * (1 - discountRate);
    }

    public decimal CalculateActualCost(decimal durationMinutes, decimal discountRate)
    {
        const decimal baseRatePerMinute = 2.0m;
        return durationMinutes * baseRatePerMinute * (1 - discountRate);
    }
}
